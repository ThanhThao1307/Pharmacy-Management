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

        public frmProcessOrderDetails()
        {
            InitializeComponent();
        }

        private void frmProcessOrderDetails_Load(object sender, EventArgs e)
        {
            dgvOrderDetails.AutoGenerateColumns = false;

            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = db.Products.Select(p => new { p.ProductId, Name = p.ProductName }).ToList();
            cbProducts.Text = null;

            LoadCbOrders();

            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DataSource = db.Customers.Select(c => new { c.CustomerId, Name = c.FullName }).ToList();
            cbCustomer.Text = null;
            cbCustomer.Enabled = false; // Khóa cố định khách hàng khi xử lý chi tiết theo đúng quy trình bước 2
        }

        private void LoadCbOrders()
        {
            cbOrders.DataSource = db.Orders.Select(o => o.OrderId).ToList();
            cbOrders.Text = null;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadOrderDetails()
        {
            // Truy vấn bắc cầu qua ImportDetail để lấy ProductId và ProductName (vì OrderDetail không có ProductId)
            var details = db.OrderDetails
                .Include(d => d.ImportDetail)
                .ThenInclude(id => id.Product)
                .Where(d => d.OrderId == mOrderID)
                .Select(d => new 
                { 
                    d.OrderDetailId, 
                    d.OrderId, 
                    ProductId = d.ImportDetail.ProductId, // Truy vấn từ lô nhập ra ProductId
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
                txtOrderDate.Text = order.OrderDate.ToString("dd/MM/yyyy HH:mm");
                txtTotalAmount.Text = order.TotalAmount.ToString("N0") + " VNĐ";
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
                        // Hoàn lại tồn kho cho lô nhập tương ứng
                        var batch = db.ImportDetails.Find(orderdetail.ImportDetailId);
                        if (batch != null) batch.CurrentQuantity += (orderdetail.Quantity * orderdetail.ConversionRate);

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

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            mOrderDetailID = Convert.ToInt64(dgvOrderDetails.Rows[e.RowIndex].Cells["colOrderDetailId"].Value);
            cbProducts.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["colProductName"].Value.ToString();
            mQuantity.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["colQuantity"].Value.ToString();
            mPrice.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["colPrice"].Value.ToString();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedValue != null && long.TryParse(cbProducts.SelectedValue.ToString(), out long productId))
            {
                var product = db.Products.Where(p => p.ProductId == productId).FirstOrDefault();
                if (product != null)
                {
                    mPrice.Text = product.Price.ToString();

                    // Hiển thị hình ảnh sản phẩm
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

                // Kiểm tra thuốc kê đơn GPP
                var prodCheck = db.Products.Find(productID);
                var orderCheck = db.Orders.Find(mOrderID);
                if (prodCheck != null && prodCheck.PrescriptionRequired && orderCheck != null && orderCheck.PrescriptionFileId == null)
                {
                    if (MessageBox.Show($"Sản phẩm '{prodCheck.ProductName}' là THUỐC KÊ ĐƠN (GPP).\r\nĐơn hàng số #{mOrderID} hiện chưa có hồ sơ Toa thuốc thẩm định!\r\n\r\nBạn có muốn mở form lập hồ sơ Toa thuốc ngay bây giờ không?", "Yêu cầu Toa thuốc (GPP)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (var frm = new frmPrescriptionDetail(0, mOrderID))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                cbOrders_SelectionChangeCommitted(null!, EventArgs.Empty);
                            }
                        }
                    }
                }

                // Kiểm tra xem sản phẩm đã có trong danh sách hiển thị chưa
                if (list.Any(o => o.OrderID == mOrderID && o.ProductID == productID))
                {
                    toolTip1.Show("Đơn hàng đã có sản phẩm này. Vui lòng chọn sửa số lượng ở danh sách bên dưới!", cbProducts, 0, 0, 1500);
                    cbProducts.Focus();
                    return;
                }

                // Lấy các lô nhập hợp lệ (còn hạn sử dụng và còn tồn kho), ưu tiên lô hết hạn trước (FIFO / FEFO)
                var validBatches = db.ImportDetails
                    .Where(id => id.ProductId == productID && id.CurrentQuantity > 0 && id.ExpiryDate >= DateTime.Today)
                    .OrderBy(id => id.ExpiryDate)
                    .ToList();

                int totalAvailable = validBatches.Sum(b => b.CurrentQuantity);
                if (totalAvailable < qty)
                {
                    MessageBox.Show($"Sản phẩm không đủ tồn kho hợp lệ! (Tổng tồn kho hiện tại: {totalAvailable})", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Phân bổ số lượng bán vào các lô theo thứ tự ưu tiên
                int remainingQty = qty;
                foreach (var batch in validBatches)
                {
                    if (remainingQty <= 0) break;

                    int takeQty = Math.Min(remainingQty, batch.CurrentQuantity);

                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderId = mOrderID,
                        ImportDetailId = batch.ImportDetailId, // Gán ID của lô nhập (không dùng ProductId trực tiếp)
                        Quantity = takeQty,
                        Price = price,
                        SoldUnit = "Đơn vị cơ bản",
                        ConversionRate = 1
                    };

                    batch.CurrentQuantity -= takeQty;
                    db.OrderDetails.Add(orderDetail);
                    remainingQty -= takeQty;
                }

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
                toolTip1.Show("Hãy chọn chi tiết đơn hàng cần sửa!", btSaveOrderDetail, 0, 0, 1000);
                return;
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

                // Kiểm tra trùng sản phẩm ở dòng khác
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

                // Hoàn lại tồn kho cho lô cũ
                var oldBatch = db.ImportDetails.Find(orderDetail.ImportDetailId);
                if (oldBatch != null)
                {
                    oldBatch.CurrentQuantity += (orderDetail.Quantity * orderDetail.ConversionRate);
                }

                // Kiểm tra tồn kho khả dụng của sản phẩm
                var validBatches = db.ImportDetails
                    .Where(id => id.ProductId == newProductID && id.CurrentQuantity > 0 && id.ExpiryDate >= DateTime.Today)
                    .OrderBy(id => id.ExpiryDate)
                    .ToList();

                int totalAvailable = validBatches.Sum(b => b.CurrentQuantity);
                if (totalAvailable < newQty)
                {
                    // Nếu không đủ, hoàn tác lại số lượng vừa cộng trả cho lô cũ
                    if (oldBatch != null) oldBatch.CurrentQuantity -= (orderDetail.Quantity * orderDetail.ConversionRate);
                    MessageBox.Show($"Không đủ tồn kho để sửa số lượng! (Tổng tồn kho khả dụng: {totalAvailable})", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa dòng chi tiết cũ và phân bổ lại theo lô (FIFO / FEFO)
                db.OrderDetails.Remove(orderDetail);

                int remainingQty = newQty;
                foreach (var batch in validBatches)
                {
                    if (remainingQty <= 0) break;

                    int takeQty = Math.Min(remainingQty, batch.CurrentQuantity);

                    OrderDetail newDetail = new OrderDetail
                    {
                        OrderId = mOrderID,
                        ImportDetailId = batch.ImportDetailId,
                        Quantity = takeQty,
                        Price = newPrice,
                        SoldUnit = "Đơn vị cơ bản",
                        ConversionRate = 1
                    };

                    batch.CurrentQuantity -= takeQty;
                    db.OrderDetails.Add(newDetail);
                    remainingQty -= takeQty;
                }

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
                order.NetAmount = total - order.Discount;
                txtTotalAmount.Text = total.ToString("N0") + " VNĐ";
            }
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
                    using (var frm = new frmPrescriptionDetail(0, mOrderID))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            cbOrders_SelectionChangeCommitted(null!, EventArgs.Empty);
                        }
                    }
                }
                return;
            }

            using (var frm = new frmPrescriptionDetail(pId, mOrderID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cbOrders_SelectionChangeCommitted(null!, EventArgs.Empty);
                }
            }
        }
    }
}
