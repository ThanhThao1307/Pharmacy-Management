using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmProcessOrderDetails : Form
    {
        private PharmacyDbContext db = new PharmacyDbContext();
        private List<OrderDetailsAndProduct> list = new List<OrderDetailsAndProduct>();
        private long mOrderID;
        private long mOrderDetailID;

        private long _initialOrderId = 0;

        public frmProcessOrderDetails()
        {
            InitializeComponent();
        }

        public frmProcessOrderDetails(long initialOrderId) : this()
        {
            _initialOrderId = initialOrderId;
        }

        private void frmProcessOrderDetails_Load(object sender, EventArgs e)
        {
            dgvOrderDetails.AutoGenerateColumns = false;

            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = db.Products.Where(p => p.Status == true).Select(p => new { p.ProductId, Name = p.ProductName }).ToList();
            cbProducts.Text = null;

            LoadCbOrders();

            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DataSource = db.Customers.Where(c => c.IsActive == true).Select(c => new { c.CustomerId, Name = c.FullName }).ToList();
            cbCustomer.Text = null;
            cbCustomer.Enabled = false;

            if (_initialOrderId > 0)
            {
                cbOrders.SelectedValue = _initialOrderId;
                cbOrders_SelectionChangeCommitted(cbOrders, EventArgs.Empty);
            }

            // Nạp danh sách đơn vị mặc định
            cbUnits.Items.Clear();
            cbUnits.Items.AddRange(new object[] { "Viên", "Vỉ", "Hộp", "Lọ", "Chai", "Tuýp", "Ống", "Gói", "Cái", "Chiếc" });
            cbUnits.DropDownStyle = ComboBoxStyle.DropDown; // Cho phép gõ thêm nếu thiếu
            cbUnits.TextChanged += cbUnits_TextChanged;
        }

        private void LoadCbOrders()
        {
            cbOrders.DisplayMember = "DisplayInfo";
            cbOrders.ValueMember = "OrderId";
            cbOrders.DataSource = db.Orders.Select(o => new { o.OrderId, DisplayInfo = $"{o.OrderId} - {o.OrderCode}" }).ToList();
            cbOrders.Text = null;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmManageOrder());
            }
            else
            {
                Close();
            }
        }

        private void loadOrderDetails()
        {
            var details = db.OrderDetails
                .Include(d => d.ImportDetail)
                .ThenInclude(id => id.Product)
                .Where(d => d.OrderId == mOrderID)
                .Select(d => new 
                { 
                    d.OrderDetailId, 
                    d.OrderId, 
                    ProductId = d.ImportDetail.ProductId,
                    d.Quantity, 
                    d.Price, 
                    ProductName = d.ImportDetail.Product.ProductName 
                })
                .ToList();

            list = new List<OrderDetailsAndProduct>();
            foreach (var d in details)
            {
                OrderDetailsAndProduct detail = new OrderDetailsAndProduct();
                detail.OrderDetailID = d.OrderDetailId;
                detail.ProductID = d.ProductId;
                detail.OrderID = d.OrderId;
                detail.Quantity = d.Quantity;
                detail.Price = d.Price;
                detail.Name = d.ProductName;
                list.Add(detail);
            }

            dgvOrderDetails.DataSource = list;
            dgvOrderDetails.ClearSelection();
            mOrderDetailID = 0;
            mQuantity.Text = "1";
            cbOrders.Focus();
        }

        private void cbOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbOrders.SelectedValue == null) return;
            mOrderID = Convert.ToInt64(cbOrders.SelectedValue);

            Order? order = db.Orders.Include(o => o.Customer).Include(o => o.User).Include(o => o.PrescriptionFile).SingleOrDefault(o => o.OrderId == mOrderID);
            if (order != null)
            {
                Text = "Xử lý chi tiết đơn hàng " + order.OrderId.ToString();
                txtOrderCode.Text = order.OrderCode;
                dtpOrderDate.Value = order.OrderDate;
                txtTotalAmount.Text = order.TotalAmount.ToString("N0") + " VNĐ";
                nudDiscount.Value = order.Discount;
                txtNetAmount.Text = order.NetAmount.ToString("N0") + " VNĐ";
                cbStatus.SelectedIndex = order.Status ? 1 : 0; // 0: Đã thanh toán, 1: Hủy
                if (order.Customer != null)
                {
                    cbCustomer.SelectedValue = order.Customer.CustomerId;
                }
                else
                {
                    cbCustomer.Text = null;
                }

                txtEmployeeName.Text = order.User != null ? order.User.FullName : "";

                if (order.PrescriptionFile != null)
                {
                    string statusStr = order.PrescriptionFile.Status ? "Hợp lệ" : "Hết hiệu lực";
                    txtPrescription.Text = $"[{order.PrescriptionFile.PrescriptionFileId}] {order.PrescriptionFile.FileName} | {statusStr} | {order.PrescriptionFile.Note}";
                    txtPrescription.Tag = order.PrescriptionFile.PrescriptionFileId;
                }
                else
                {
                    txtPrescription.Text = "";
                    txtPrescription.Tag = null;
                }

                loadOrderDetails();
            }
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvOrderDetails.Columns[e.ColumnIndex].Name == "colDelete")
            {
                try
                {
                    long detailID = Convert.ToInt64(dgvOrderDetails.Rows[e.RowIndex].Cells["colOrderDetailId"].Value);
                    OrderDetail orderdetail = db.OrderDetails.Single(o => o.OrderDetailId == detailID);
                    if (MessageBox.Show("Bạn muốn xóa chi tiết số " + detailID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Hoàn trả lại số lượng tồn kho vào đúng lô hàng đã xuất
                        var batch = db.ImportDetails.Find(orderdetail.ImportDetailId);
                        if (batch != null) batch.CurrentQuantity += (orderdetail.Quantity * orderdetail.ConversionRate);

                        // Xóa chi tiết hóa đơn và cập nhật tổng tiền
                        db.OrderDetails.Remove(orderdetail);
                        UpdateOrderTotal();
                        db.SaveChanges();
                        loadOrderDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }

        // Đã bỏ class UnitItem cũ vì yêu cầu dùng danh sách tĩnh (string)

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= list.Count) return;
            mOrderDetailID = Convert.ToInt64(dgvOrderDetails.Rows[e.RowIndex].Cells["colOrderDetailId"].Value);
            var item = list[e.RowIndex];
            cbProducts.Text = item.Name;
            mQuantity.Text = item.Quantity.ToString();
            mPrice.Text = item.Price.ToString("G");

            if (cbUnits != null)
            {
                cbUnits.Text = item.SoldUnit;
            }
        }

        private void UpdatePrice()
        {
            if (cbProducts.SelectedValue != null && long.TryParse(cbProducts.SelectedValue.ToString(), out long productId))
            {
                var product = db.Products.FirstOrDefault(p => p.ProductId == productId);
                if (product != null)
                {
                    string selectedUnit = cbUnits.Text.Trim();
                    if (string.IsNullOrWhiteSpace(selectedUnit)) selectedUnit = product.Unit;

                    if (selectedUnit.Equals(product.Unit, StringComparison.OrdinalIgnoreCase))
                    {
                        mPrice.Text = product.Price.ToString("G");
                    }
                    else
                    {
                        var su = db.ProductUnits.FirstOrDefault(u => u.ProductId == productId && u.UnitName.ToLower() == selectedUnit.ToLower());
                        if (su != null)
                        {
                            mPrice.Text = su.Price.ToString("G");
                        }
                        else
                        {
                            mPrice.Text = "0"; // Chưa có quy đổi, trả về 0 để tránh tính sai
                        }
                    }
                }
            }
        }

        private void cbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void cbUnits_TextChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedValue != null && long.TryParse(cbProducts.SelectedValue.ToString(), out long productId))
            {
                var product = db.Products.Where(p => p.ProductId == productId).FirstOrDefault();
                if (product != null)
                {
                    mPrice.Text = product.Price.ToString();

                    var oldImg = picProductImage.Image;
                    if (!string.IsNullOrEmpty(product.ImageFile))
                    {
                        string imgPath = Path.Combine(Utility.ImagePath, product.ImageFile);
                        picProductImage.Image = Utility.LoadBitmapWithoutLock(imgPath);
                    }
                    else
                    {
                        picProductImage.Image = null;
                    }
                    oldImg?.Dispose();

                    UpdatePrice(); // Tự động lấy giá dựa vào Unit đang hiển thị
                }
                mQuantity.Focus();
            }
        }

        private void btAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbOrders.Text))
            {
                toolTip1.Show("Hãy chọn Order?", cbOrders, 0, 0, 1000);
                cbOrders.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbProducts.Text) || cbProducts.FindStringExact(cbProducts.Text) < 0)
            {
                toolTip1.Show("Hãy chọn sản phẩm hợp lệ?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text) || !int.TryParse(mQuantity.Text, out int qty) || qty <= 0)
            {
                toolTip1.Show("Hãy nhập số lượng hợp lệ (> 0)?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text) || !decimal.TryParse(mPrice.Text, out decimal price) || price < 0)
            {
                toolTip1.Show("Hãy nhập đơn giá hợp lệ?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }

            try
            {
                long productID = Convert.ToInt64(cbProducts.SelectedValue);

                // Kiểm tra ràng buộc thuốc kê đơn GPP và toa thuốc của đơn hàng
                var prodCheck = db.Products.Find(productID);
                var orderCheck = db.Orders.Include(o => o.PrescriptionFile).SingleOrDefault(o => o.OrderId == mOrderID);
                if (prodCheck != null && prodCheck.PrescriptionRequired)
                {
                    bool hasValidPrescription = false;
                    if (orderCheck != null && orderCheck.PrescriptionFileId != null && orderCheck.PrescriptionFileId > 0 && orderCheck.PrescriptionFile != null)
                    {
                        var pf = orderCheck.PrescriptionFile;
                        if (pf.Status && !string.IsNullOrWhiteSpace(pf.FilePath) && pf.FileName != "Toa_Thuoc_GPP")
                        {
                            hasValidPrescription = true;
                        }
                    }

                    if (!hasValidPrescription)
                    {
                        MessageBox.Show($"Sản phẩm '{prodCheck.ProductName}' là THUỐC KÊ ĐƠN (GPP).\r\nHồ sơ Toa thuốc của Đơn hàng #{mOrderID} hiện tại chưa có hình ảnh/file toa hợp lệ từ bác sĩ (hoặc chỉ mới lập thông tin trống Toa_Thuoc_GPP).\r\n\r\nTheo chuẩn GPP, bạn bắt buộc phải bổ sung hình ảnh/file Toa thuốc thẩm định từ bác sĩ trước khi thêm bán thuốc kê đơn này!\r\n(Lưu ý: Nếu khách mua nhiều thuốc cho các bệnh khác nhau như dạ dày, cảm... bạn có thể chọn hoặc bấm [➕ Thêm ảnh toa khác...] để đính kèm nhiều ảnh vào cùng một hồ sơ).", "Yêu cầu Toa thuốc bắt buộc (GPP)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        long pIdToOpen = (orderCheck != null && orderCheck.PrescriptionFileId != null && orderCheck.PrescriptionFileId > 0) ? orderCheck.PrescriptionFileId.Value : 0;
                        if (pIdToOpen > 0)
                        {
                            using (var frm = new frmEditPrescription(pIdToOpen, mOrderID))
                            {
                                if (frm.ShowDialog() == DialogResult.OK)
                                {
                                    cbOrders_SelectionChangeCommitted(cbOrders, EventArgs.Empty);
                                    orderCheck = db.Orders.Include(o => o.PrescriptionFile).SingleOrDefault(o => o.OrderId == mOrderID);
                                }
                            }
                        }
                        else
                        {
                            using (var frm = new frmNewPrescription(mOrderID))
                            {
                                if (frm.ShowDialog() == DialogResult.OK && frm.SavedPrescriptionFileId > 0)
                                {
                                    cbOrders_SelectionChangeCommitted(cbOrders, EventArgs.Empty);
                                    orderCheck = db.Orders.Include(o => o.PrescriptionFile).SingleOrDefault(o => o.OrderId == mOrderID);
                                }
                            }
                        }

                        if (orderCheck == null || orderCheck.PrescriptionFileId == null || orderCheck.PrescriptionFileId <= 0 || orderCheck.PrescriptionFile == null || !orderCheck.PrescriptionFile.Status || string.IsNullOrWhiteSpace(orderCheck.PrescriptionFile.FilePath) || orderCheck.PrescriptionFile.FileName == "Toa_Thuoc_GPP")
                        {
                            MessageBox.Show($"Hồ sơ Toa thuốc cho Đơn hàng #{mOrderID} vẫn chưa có file/ảnh hợp lệ từ bác sĩ.\r\nHệ thống từ chối thêm thuốc kê đơn '{prodCheck.ProductName}' để đảm bảo tuân thủ chuẩn GPP!", "Ràng buộc GPP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (list.Any(o => o.OrderID == mOrderID && o.ProductID == productID))
                {
                    toolTip1.Show("Đơn hàng đã có sản phẩm này. Vui lòng chọn sửa số lượng ở danh sách bên dưới!", cbProducts, 0, 0, 1500);
                    cbProducts.Focus();
                    return;
                }

                string soldUnitName = cbUnits.Text.Trim();
                if (string.IsNullOrWhiteSpace(soldUnitName)) soldUnitName = "Đơn vị cơ bản";
                
                int convRate = 1;
                if (prodCheck != null && !soldUnitName.Equals(prodCheck.Unit, StringComparison.OrdinalIgnoreCase))
                {
                    var su = db.ProductUnits.FirstOrDefault(u => u.ProductId == productID && u.UnitName.ToLower() == soldUnitName.ToLower());
                    if (su != null) convRate = su.ConversionRate;
                }
                
                int neededBaseQty = qty * convRate;

                // Lấy danh sách các lô nhập còn hạn sử dụng, ưu tiên xuất lô cận hạn trước (FEFO)
                var validBatches = db.ImportDetails
                    .Where(id => id.ProductId == productID && id.CurrentQuantity > 0 && id.ExpiryDate >= DateTime.Today)
                    .OrderBy(id => id.ExpiryDate)
                    .ToList();

                int totalAvailable = validBatches.Sum(b => b.CurrentQuantity);
                if (totalAvailable < neededBaseQty)
                {
                    MessageBox.Show($"Sản phẩm không đủ tồn kho hợp lệ! (Tổng tồn kho hiện tại: {totalAvailable} đơn vị gốc, cần {neededBaseQty})", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Phân bổ số lượng xuất bán trừ dần theo thứ tự lô hàng
                int remainingBaseQty = neededBaseQty;
                foreach (var batch in validBatches)
                {
                    if (remainingBaseQty <= 0) break;

                    int takeBaseQty = Math.Min(remainingBaseQty, batch.CurrentQuantity);

                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderId = mOrderID,
                        ImportDetailId = batch.ImportDetailId,
                        SoldUnit = soldUnitName,
                        ConversionRate = convRate
                    };

                    if (takeBaseQty == neededBaseQty)
                    {
                        orderDetail.Quantity = qty;
                        orderDetail.Price = price;
                    }
                    else if (takeBaseQty % convRate == 0 && convRate > 1)
                    {
                        orderDetail.Quantity = takeBaseQty / convRate;
                        orderDetail.Price = price;
                    }
                    else
                    {
                        orderDetail.Quantity = takeBaseQty;
                        orderDetail.Price = convRate > 0 ? (price / convRate) : price;
                        orderDetail.SoldUnit = "Đơn vị cơ bản (tách lô)";
                        orderDetail.ConversionRate = 1;
                    }

                    batch.CurrentQuantity -= takeBaseQty;
                    db.OrderDetails.Add(orderDetail);
                    remainingBaseQty -= takeBaseQty;
                }

                // Cập nhật lại tổng tiền hóa đơn và lưu thay đổi
                UpdateOrderTotal();
                db.SaveChanges();

                cbProducts.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                loadOrderDetails();
                toolTip1.Show("Thêm thành công.", btAddOrderDetail, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btAddOrderDetail, 0, 0, 1000);
            }
        }

        private void btSaveOrderDetail_Click(object sender, EventArgs e)
        {
            if (mOrderDetailID == 0)
            {
                // Khi mOrderDetailID == 0 (không chọn dòng nào trong bảng chi tiết để sửa), nút LƯU dùng để chốt & hoàn tất đơn hàng với các mặt hàng ĐÃ THÊM VÀO LƯỚI.
                if (list.Count > 0)
                {
                    if (MessageBox.Show($"Đơn hàng #{mOrderID} hiện có {list.Count} mặt hàng (Tổng tiền: {txtTotalAmount.Text}).\r\nBạn có muốn chốt lưu và hoàn tất xử lý đơn hàng này không?", "Xác nhận hoàn tất đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        btClose_Click(sender, e);
                    }
                    return;
                }
                else
                {
                    toolTip1.Show("Đơn hàng chưa có sản phẩm nào trong bảng chi tiết. Hãy chọn sản phẩm rồi bấm [➕ THÊM MỚI] trước khi chốt lưu!", btSaveOrderDetail, 0, 0, 2000);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(cbOrders.Text))
            {
                toolTip1.Show("Hãy chọn Order?", cbOrders, 0, 0, 1000);
                cbOrders.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbProducts.Text) || cbProducts.FindStringExact(cbProducts.Text) < 0)
            {
                toolTip1.Show("Hãy chọn sản phẩm hợp lệ?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text) || !int.TryParse(mQuantity.Text, out int newQty) || newQty <= 0)
            {
                toolTip1.Show("Hãy nhập số lượng hợp lệ (> 0)?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text) || !decimal.TryParse(mPrice.Text, out decimal newPrice) || newPrice < 0)
            {
                toolTip1.Show("Hãy nhập đơn giá hợp lệ?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }

            try
            {
                long newProductID = Convert.ToInt64(cbProducts.SelectedValue);
                var prodCheck = db.Products.Find(newProductID);
                var orderCheck = db.Orders.Include(o => o.PrescriptionFile).SingleOrDefault(o => o.OrderId == mOrderID);
                if (prodCheck != null && prodCheck.PrescriptionRequired)
                {
                    bool hasValidPrescription = false;
                    if (orderCheck != null && orderCheck.PrescriptionFileId != null && orderCheck.PrescriptionFileId > 0 && orderCheck.PrescriptionFile != null)
                    {
                        var pf = orderCheck.PrescriptionFile;
                        if (pf.Status && !string.IsNullOrWhiteSpace(pf.FilePath) && pf.FileName != "Toa_Thuoc_GPP")
                        {
                            hasValidPrescription = true;
                        }
                    }

                    if (!hasValidPrescription)
                    {
                        MessageBox.Show($"Sản phẩm '{prodCheck.ProductName}' là THUỐC KÊ ĐƠN (GPP).\r\nHồ sơ Toa thuốc của Đơn hàng #{mOrderID} hiện tại chưa có hình ảnh/file toa hợp lệ từ bác sĩ.\r\n\r\nTheo chuẩn GPP, bạn bắt buộc phải bổ sung hình ảnh/file Toa thuốc thẩm định từ bác sĩ trước khi cập nhật chi tiết sang thuốc kê đơn này!", "Yêu cầu Toa thuốc bắt buộc (GPP)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        long pIdToOpen = (orderCheck != null && orderCheck.PrescriptionFileId != null && orderCheck.PrescriptionFileId > 0) ? orderCheck.PrescriptionFileId.Value : 0;
                        if (pIdToOpen > 0)
                        {
                            using (var frm = new frmEditPrescription(pIdToOpen, mOrderID))
                            {
                                if (frm.ShowDialog() == DialogResult.OK)
                                {
                                    cbOrders_SelectionChangeCommitted(cbOrders, EventArgs.Empty);
                                    orderCheck = db.Orders.Include(o => o.PrescriptionFile).SingleOrDefault(o => o.OrderId == mOrderID);
                                }
                            }
                        }
                        else
                        {
                            using (var frm = new frmNewPrescription(mOrderID))
                            {
                                if (frm.ShowDialog() == DialogResult.OK && frm.SavedPrescriptionFileId > 0)
                                {
                                    cbOrders_SelectionChangeCommitted(cbOrders, EventArgs.Empty);
                                    orderCheck = db.Orders.Include(o => o.PrescriptionFile).SingleOrDefault(o => o.OrderId == mOrderID);
                                }
                            }
                        }

                        if (orderCheck == null || orderCheck.PrescriptionFileId == null || orderCheck.PrescriptionFileId <= 0 || orderCheck.PrescriptionFile == null || !orderCheck.PrescriptionFile.Status || string.IsNullOrWhiteSpace(orderCheck.PrescriptionFile.FilePath) || orderCheck.PrescriptionFile.FileName == "Toa_Thuoc_GPP")
                        {
                            MessageBox.Show($"Hồ sơ Toa thuốc cho Đơn hàng #{mOrderID} vẫn chưa có file/ảnh hợp lệ từ bác sĩ.\r\nHệ thống từ chối cập nhật thuốc kê đơn '{prodCheck.ProductName}' để đảm bảo tuân thủ chuẩn GPP!", "Ràng buộc GPP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (list.Any(o => o.ProductID == newProductID && o.OrderDetailID != mOrderDetailID))
                {
                    toolTip1.Show("Đơn hàng đã có sản phẩm này ở dòng khác!", cbProducts, 0, 0, 1500);
                    cbProducts.Focus();
                    return;
                }

                OrderDetail? orderDetail = db.OrderDetails.SingleOrDefault(o => o.OrderDetailId == mOrderDetailID);
                if (orderDetail == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hoàn trả lại số lượng của chi tiết cũ vào lô hàng tương ứng trước khi tính toán lại
                var oldBatch = db.ImportDetails.Find(orderDetail.ImportDetailId);
                if (oldBatch != null)
                {
                    oldBatch.CurrentQuantity += (orderDetail.Quantity * orderDetail.ConversionRate);
                }

                string soldUnitName = cbUnits.Text.Trim();
                if (string.IsNullOrWhiteSpace(soldUnitName)) soldUnitName = "Đơn vị cơ bản";
                
                int convRate = 1;
                if (prodCheck != null && !soldUnitName.Equals(prodCheck.Unit, StringComparison.OrdinalIgnoreCase))
                {
                    var su = db.ProductUnits.FirstOrDefault(u => u.ProductId == newProductID && u.UnitName.ToLower() == soldUnitName.ToLower());
                    if (su != null) convRate = su.ConversionRate;
                }

                int neededBaseQty = newQty * convRate;

                // Lấy các lô hàng hợp lệ và kiểm tra khả năng đáp ứng số lượng mới
                var validBatches = db.ImportDetails
                    .Where(id => id.ProductId == newProductID && id.CurrentQuantity > 0 && id.ExpiryDate >= DateTime.Today)
                    .OrderBy(id => id.ExpiryDate)
                    .ToList();

                int totalAvailable = validBatches.Sum(b => b.CurrentQuantity);
                if (totalAvailable < neededBaseQty)
                {
                    if (oldBatch != null) oldBatch.CurrentQuantity -= (orderDetail.Quantity * orderDetail.ConversionRate);
                    MessageBox.Show($"Không đủ tồn kho để sửa số lượng! (Tổng tồn kho khả dụng: {totalAvailable} đơn vị gốc, cần {neededBaseQty})", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.OrderDetails.Remove(orderDetail);

                // Phân bổ số lượng mới theo thứ tự lô ưu tiên hạn sử dụng gần nhất (FEFO)
                int remainingBaseQty = neededBaseQty;
                foreach (var batch in validBatches)
                {
                    if (remainingBaseQty <= 0) break;

                    int takeBaseQty = Math.Min(remainingBaseQty, batch.CurrentQuantity);

                    OrderDetail newDetail = new OrderDetail
                    {
                        OrderId = mOrderID,
                        ImportDetailId = batch.ImportDetailId,
                        SoldUnit = soldUnitName,
                        ConversionRate = convRate
                    };

                    if (takeBaseQty == neededBaseQty)
                    {
                        newDetail.Quantity = newQty;
                        newDetail.Price = newPrice;
                    }
                    else if (takeBaseQty % convRate == 0 && convRate > 1)
                    {
                        newDetail.Quantity = takeBaseQty / convRate;
                        newDetail.Price = newPrice;
                    }
                    else
                    {
                        newDetail.Quantity = takeBaseQty;
                        newDetail.Price = convRate > 0 ? (newPrice / convRate) : newPrice;
                        newDetail.SoldUnit = "Đơn vị cơ bản (tách lô)";
                        newDetail.ConversionRate = 1;
                    }

                    batch.CurrentQuantity -= takeBaseQty;
                    db.OrderDetails.Add(newDetail);
                    remainingBaseQty -= takeBaseQty;
                }

                // Cập nhật lại tổng tiền hóa đơn sau khi chỉnh sửa
                UpdateOrderTotal();
                db.SaveChanges();

                mOrderDetailID = 0;
                cbProducts.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                loadOrderDetails();
                toolTip1.Show("Lưu thành công.", btSaveOrderDetail, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveOrderDetail, 0, 0, 1000);
            }
        }

        private void UpdateOrderTotal()
        {
            var order = db.Orders.Find(mOrderID);
            if (order != null)
            {
                decimal total = db.OrderDetails.Where(d => d.OrderId == mOrderID).Sum(d => d.Quantity * d.Price);
                order.TotalAmount = total;
                order.Discount = nudDiscount.Value;
                order.NetAmount = total - order.Discount;
                if (order.NetAmount < 0) order.NetAmount = 0;
                txtTotalAmount.Text = total.ToString("N0") + " VNĐ";
                txtNetAmount.Text = order.NetAmount.ToString("N0") + " VNĐ";
                
                db.SaveChanges(); // Ensure order is saved before recalculating loyalty
                if (order.CustomerId.HasValue)
                {
                    UpdateCustomerLoyalty(order.CustomerId.Value);
                }
            }
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (mOrderID <= 0) return;
            try
            {
                var order = db.Orders.Find(mOrderID);
                if (order != null)
                {
                    order.Discount = nudDiscount.Value;
                    order.NetAmount = order.TotalAmount - order.Discount;
                    if (order.NetAmount < 0) order.NetAmount = 0;
                    txtNetAmount.Text = order.NetAmount.ToString("N0") + " VNĐ";
                    db.SaveChanges();
                    
                    if (order.CustomerId.HasValue)
                    {
                        UpdateCustomerLoyalty(order.CustomerId.Value);
                    }
                }
            }
            catch { }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mOrderID <= 0) return;
            try
            {
                var order = db.Orders.Find(mOrderID);
                if (order != null && cbStatus.SelectedIndex >= 0)
                {
                    order.Status = cbStatus.SelectedIndex == 1; // 0: Đã thanh toán, 1: Hủy
                    db.SaveChanges();
                    
                    if (order.CustomerId.HasValue)
                    {
                        UpdateCustomerLoyalty(order.CustomerId.Value);
                    }
                }
            }
            catch { }
        }

        private void UpdateCustomerLoyalty(long customerId)
        {
            try
            {
                var customer = db.Customers.Find(customerId);
                if (customer != null)
                {
                    decimal realTotalSpent = db.Orders
                        .Where(o => o.CustomerId == customerId && o.Status == false)
                        .Sum(o => (decimal?)o.NetAmount) ?? 0;

                    customer.TotalSpent = realTotalSpent;
                    customer.LoyaltyPoints = (int)(realTotalSpent / 10000);

                    if (customer.TotalSpent >= 10000000)
                        customer.CustomerGroup = "Vip";
                    else if (customer.TotalSpent >= 3000000)
                        customer.CustomerGroup = "Thân thiết";
                    else
                        customer.CustomerGroup = "Thường";
                        
                    db.SaveChanges();
                }
            }
            catch { }
        }

        private void btViewPrescription_Click(object sender, EventArgs e)
        {
            if (mOrderID <= 0)
            {
                MessageBox.Show("Vui lòng chọn Đơn hàng cần xem toa thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long pId = 0;
            if (txtPrescription.Tag != null && long.TryParse(txtPrescription.Tag.ToString(), out long tagId))
            {
                pId = tagId;
            }
            else
            {
                var order = db.Orders.Find(mOrderID);
                if (order != null && order.PrescriptionFileId != null)
                {
                    pId = order.PrescriptionFileId.Value;
                }
            }

            if (pId <= 0)
            {
                if (MessageBox.Show("Đơn hàng này chưa có hồ sơ Toa thuốc. Bạn có muốn tạo mới hồ sơ Toa thuốc ngay bây giờ không?", "Chưa có Toa thuốc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var frm = new frmNewPrescription(mOrderID))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            cbOrders_SelectionChangeCommitted(null!, EventArgs.Empty);
                        }
                    }
                }
                return;
            }

            using (var frm = new frmEditPrescription(pId, mOrderID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cbOrders_SelectionChangeCommitted(null!, EventArgs.Empty);
                }
            }
        }
    }
}
