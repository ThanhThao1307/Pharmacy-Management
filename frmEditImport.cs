using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmEditImport : Form
    {
        private Import? _import;
        private BindingList<frmNewImport.ImportDetailWrapper> _importDetailsGridList = new BindingList<frmNewImport.ImportDetailWrapper>();
        private List<ProductUnit> _uiProductUnitsList = new List<ProductUnit>();

        // Danh sách đơn vị sỉ cố định (dùng chung với frmNewImport)
        private static readonly string[] WholesaleUnitOptions =
            { "Hộp", "Thùng", "Chai", "Lọ", "Tuýp", "Gói", "Túi", "Bình", "Ống", "Cái", "Bịch" };

        public frmEditImport(long importId)
        {
            InitializeComponent();
            using (var db = new PharmacyDbContext())
            {
                _import = db.Imports
                    .Include(i => i.ImportDetails)
                    .ThenInclude(d => d.Product)
                    .FirstOrDefault(i => i.ImportId == importId);
            }
        }

        private void frmEditImport_Load(object sender, EventArgs e)
        {
            dgvProductUnits.AutoGenerateColumns = false;
            dgvImportDetails.AutoGenerateColumns = false;
            dgvImportDetails.DataSource = _importDetailsGridList;

            // Điền đơn vị sỉ cố định vào cboWholesaleUnit
            LoadWholesaleUnitCombo();

            LoadSuppliers();
            LoadProducts();

            cboStatus.DisplayMember = "Text";
            cboStatus.ValueMember = "Value";
            cboStatus.DataSource = new[]
            {
                new { Value = (byte)0, Text = "Nháp" },
                new { Value = (byte)1, Text = "Hoàn thành" },
                new { Value = (byte)2, Text = "Hủy" }
            };

            txtCreatedBy.Enabled = false;

            if (_import != null)
            {
                this.Text = "Cập nhật phiếu nhập kho";
                txtImportCode.Text = _import.ImportCode;
                txtImportCode.Enabled = false;
                cboSupplier.SelectedValue = _import.SupplierId;
                dtpImportDate.Value = _import.ImportDate;
                txtCreatedBy.Text = _import.CreatedBy;
                cboStatus.SelectedValue = _import.Status;

                // Load các lô đã nhập trước đó
                foreach (var detail in _import.ImportDetails)
                {
                    if (detail.Product == null) continue;
                    _importDetailsGridList.Add(new frmNewImport.ImportDetailWrapper
                    {
                        ProductId = detail.ProductId,
                        ProductCode = detail.Product.ProductCode,
                        ProductName = detail.Product.ProductName,
                        WholesaleUnitName = "Hộp",      // mặc định khi load cũ
                        ConversionRatioDisplay = "Hộp", // hiển thị đơn vị sỉ
                        InputQuantity = detail.OriginalQuantity,
                        InputPrice = detail.ImportPrice,
                        BatchNumber = detail.BatchNumber ?? "LOT",
                        ExpiryDate = detail.ExpiryDate
                    });
                }
            }
            else
            {
                this.Text = "Cập nhật phiếu nhập kho";
                txtImportCode.Text = "PNK-EDIT";
                txtCreatedBy.Text = Utility.CurrentUser?.FullName ?? "";
                cboStatus.SelectedValue = (byte)1;
            }

            if (string.IsNullOrWhiteSpace(txtBatchNumber.Text))
                txtBatchNumber.Text = "LOT-" + DateTime.Now.ToString("yyMM") + "-01";
                
            txtBatchNumber.ReadOnly = true;

            dgvImportDetails.SelectionChanged += dgvImportDetails_SelectionChanged;
            dgvImportDetails.CellClick += (s, ev) => dgvImportDetails_SelectionChanged(s, ev);
            if (_importDetailsGridList.Count > 0)
            {
                cboProduct.SelectedValue = _importDetailsGridList[0].ProductId;
            }

            UpdateTotalAmountLabel();
        }

        // ─────────────────────────────────────────────────────────────────────
        // Điền danh sách đơn vị sỉ cố định vào combo ĐV nhập
        // ─────────────────────────────────────────────────────────────────────
        // Chỉ hiển thị các đơn vị có trong bảng quy đổi của thuốc đang chọn
        private void LoadWholesaleUnitCombo()
        {
            cboWholesaleUnit.SelectedIndexChanged -= cboWholesaleUnit_SelectedIndexChanged;
            cboWholesaleUnit.Items.Clear();

            if (_uiProductUnitsList != null && _uiProductUnitsList.Count > 0)
            {
                foreach (var unit in _uiProductUnitsList)
                    if (!string.IsNullOrWhiteSpace(unit.UnitName))
                        cboWholesaleUnit.Items.Add(unit.UnitName);
            }

            if (cboWholesaleUnit.Items.Count > 0)
                cboWholesaleUnit.SelectedIndex = 0;
            cboWholesaleUnit.SelectedIndexChanged += cboWholesaleUnit_SelectedIndexChanged;
        }

        private void LoadSuppliers()
        {
            using (var db = new PharmacyDbContext())
            {
                cboSupplier.DataSource = db.Suppliers.Where(s => s.Status == true).ToList();
                cboSupplier.DisplayMember = "SupplierName";
                cboSupplier.ValueMember = "SupplierId";
            }
        }

        private void LoadProducts()
        {
            using (var db = new PharmacyDbContext())
            {
                cboProduct.DataSource = db.Products.Where(p => p.Status == true).ToList();
                cboProduct.DisplayMember = "ProductName";
                cboProduct.ValueMember = "ProductId";
            }
            ShowSelectedProductImage();
            LoadProductConversionTable();
        }

        // Hiển thị hình ảnh thuốc đang chọn
        private void ShowSelectedProductImage()
        {
            var selected = cboProduct.SelectedItem as Product;
            var oldImage = picProductImage.Image;
            if (selected != null)
            {
                string imgName = !string.IsNullOrEmpty(selected.ImageFile) ? selected.ImageFile : $"{selected.ProductId}.png";
                string imgPath = System.IO.Path.Combine(Utility.ImagePath, imgName);
                if (System.IO.File.Exists(imgPath))
                    picProductImage.Image = Utility.LoadBitmapWithoutLock(imgPath);
                else
                    picProductImage.Image = null;
            }
            else
            {
                picProductImage.Image = null;
            }
            oldImage?.Dispose();
        }

        /// <summary>
        /// Tải bảng quy đổi (Section 1) cho thuốc đang chọn.
        /// Bảng này gồm các đơn vị nhỏ hơn (Vỉ, Viên...) được quy đổi từ đơn vị sỉ đã chọn.
        /// Cột Giá Nhập = giá sỉ ÷ tỷ lệ quy đổi (tự động, không nhập tay).
        /// </summary>
        private void LoadProductConversionTable()
        {
            var selectedProduct = cboProduct.SelectedItem as Product;
            if (selectedProduct == null)
            {
                _uiProductUnitsList = new List<ProductUnit>();
                dgvProductUnits.DataSource = null;
                return;
            }

            using (var db = new PharmacyDbContext())
            {
                _uiProductUnitsList = db.ProductUnits
                    .Where(u => u.ProductId == selectedProduct.ProductId)
                    .OrderByDescending(u => u.ConversionRate)
                    .ToList();
            }

            dgvProductUnits.DataSource = new BindingList<ProductUnit>(_uiProductUnitsList);

            // Cập nhật combo đơn vị nhập theo đơn vị có trong bảng quy đổi
            LoadWholesaleUnitCombo();
            RecalcDisplayRatios();
        }

        // ─────────────────────────────────────────────────────────────────────
        // Tính toán tỷ lệ hiển thị: Số lượng ĐV lẻ trong 1 ĐV Sỉ
        // = ConversionRate của ĐV Sỉ / ConversionRate của ĐV lẻ
        // ─────────────────────────────────────────────────────────────────────
        private void RecalcDisplayRatios()
        {
            string wholesaleUnit = cboWholesaleUnit.SelectedItem?.ToString() ?? "";
            var wholesaleMatch = _uiProductUnitsList.FirstOrDefault(u =>
                string.Equals(u.UnitName, wholesaleUnit, StringComparison.OrdinalIgnoreCase));
            
            decimal wholesaleRate = (wholesaleMatch != null && wholesaleMatch.ConversionRate > 0)
                ? wholesaleMatch.ConversionRate : 1;

            foreach (var unit in _uiProductUnitsList)
            {
                if (unit.ConversionRate > 0)
                {
                    unit.DisplayRatio = Math.Round((decimal)wholesaleRate / unit.ConversionRate, 4);
                }
                else
                {
                    unit.DisplayRatio = 1;
                }
            }
            RecalcConversionPrices();
            dgvProductUnits.Refresh();
        }

        // ─────────────────────────────────────────────────────────────────────
        // Tự tính cột Giá Nhập trong bảng quy đổi theo DisplayRatio
        // = giá sỉ / tỷ lệ quy đổi hiển thị (DisplayRatio)
        // ─────────────────────────────────────────────────────────────────────
        private void RecalcConversionPrices()
        {
            decimal wholesalePrice = nudWholesalePrice.Value;

            bool changed = false;
            foreach (var unit in _uiProductUnitsList)
            {
                decimal calc = unit.DisplayRatio > 0 ? Math.Round(wholesalePrice / unit.DisplayRatio, 0) : 0;
                if (unit.ImportPrice != calc)
                {
                    unit.ImportPrice = calc;
                    changed = true;
                }
            }
            if (changed)
                dgvProductUnits.Refresh();
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedProductImage();
            LoadProductConversionTable();
        }

        private void nudWholesalePrice_ValueChanged(object sender, EventArgs e)
        {
            RecalcConversionPrices();
        }

        private void cboWholesaleUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalcDisplayRatios();
            
            if (cboProduct.SelectedItem == null || _uiProductUnitsList == null) return;
            
            string wholesaleUnit = cboWholesaleUnit.SelectedItem?.ToString() ?? "";
            if (!string.IsNullOrEmpty(wholesaleUnit))
            {
                bool exists = _uiProductUnitsList.Any(u => string.Equals(u.UnitName, wholesaleUnit, StringComparison.OrdinalIgnoreCase));
                if (!exists)
                {
                    MessageBox.Show($"Đơn vị sỉ '{wholesaleUnit}' chưa có trong Bảng quy đổi.\nVui lòng thêm '{wholesaleUnit}' vào bảng bên trên với tỷ lệ quy đổi tương ứng, hoặc chọn đơn vị khác.", 
                        "Lưu ý đơn vị quy đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvProductUnits_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Nếu đổi tên đơn vị → cập nhật lại combo ĐV nhập
            if (e.ColumnIndex == colUnitName.Index)
                LoadWholesaleUnitCombo();
            RecalcConversionPrices();
        }

        private void dgvProductUnits_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProductUnits.IsCurrentCellDirty)
                dgvProductUnits.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btAddDetail_Click(object sender, EventArgs e)
        {
            var selectedProduct = cboProduct.SelectedItem as Product;
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm thuốc!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string batch = txtBatchNumber.Text.Trim();
            if (string.IsNullOrEmpty(batch))
            {
                MessageBox.Show("Vui lòng nhập số lô sản xuất!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string wholesaleUnit = cboWholesaleUnit.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(wholesaleUnit))
            {
                MessageBox.Show("Vui lòng chọn đơn vị nhập!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_uiProductUnitsList.Any(u => string.Equals(u.UnitName, wholesaleUnit, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Đơn vị sỉ '{wholesaleUnit}' chưa có trong Bảng quy đổi.\nVui lòng thêm '{wholesaleUnit}' vào bảng bên trên với tỷ lệ quy đổi tương ứng trước khi thêm lô nhập.", 
                    "Thiếu đơn vị quy đổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal wholesalePrice = nudWholesalePrice.Value;
            if (wholesalePrice <= 0)
            {
                MessageBox.Show("Giá nhập phải lớn hơn 0 VNĐ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)nudWholesaleQty.Value;

            var existing = _importDetailsGridList.FirstOrDefault(x =>
                x.ProductId == selectedProduct.ProductId &&
                x.BatchNumber.Equals(batch, StringComparison.OrdinalIgnoreCase) &&
                x.WholesaleUnitName.Equals(wholesaleUnit, StringComparison.OrdinalIgnoreCase));

            if (existing != null)
            {
                existing.InputQuantity += qty;
                existing.InputPrice = wholesalePrice;
                _importDetailsGridList.ResetBindings();
            }
            else
            {
                _importDetailsGridList.Add(new frmNewImport.ImportDetailWrapper
                {
                    ProductId = selectedProduct.ProductId,
                    ProductCode = selectedProduct.ProductCode,
                    ProductName = selectedProduct.ProductName,
                    WholesaleUnitName = wholesaleUnit,
                    ConversionRatioDisplay = wholesaleUnit,  // hiển thị đơn vị sỉ nhập
                    InputQuantity = qty,
                    InputPrice = wholesalePrice,
                    BatchNumber = batch,
                    ExpiryDate = dtpExpiryDate.Value
                });
            }

            // Tự động tăng số lô lên 1 đơn vị cho lần nhập tiếp theo
            txtBatchNumber.Text = GetNextBatchNumber(batch);

            UpdateTotalAmountLabel();
        }

        private string GetNextBatchNumber(string currentBatch)
        {
            var match = System.Text.RegularExpressions.Regex.Match(currentBatch, @"\d+$");
            if (match.Success)
            {
                string numStr = match.Value;
                if (long.TryParse(numStr, out long num))
                {
                    num++;
                    string newNumStr = num.ToString().PadLeft(numStr.Length, '0');
                    return currentBatch.Substring(0, match.Index) + newNumStr;
                }
            }
            return currentBatch + "-01";
        }

        private void dgvImportDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvImportDetails.Columns[e.ColumnIndex].Name == "colDelete")
            {
                _importDetailsGridList.RemoveAt(e.RowIndex);
                UpdateTotalAmountLabel();
            }
        }

        private void dgvImportDetails_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvImportDetails.CurrentRow == null || dgvImportDetails.CurrentRow.Index < 0 || dgvImportDetails.CurrentRow.Index >= _importDetailsGridList.Count)
                return;

            var wrapper = _importDetailsGridList[dgvImportDetails.CurrentRow.Index];
            if (wrapper != null && wrapper.ProductId > 0)
            {
                cboProduct.SelectedValue = wrapper.ProductId;
                if (!string.IsNullOrEmpty(wrapper.WholesaleUnitName))
                    cboWholesaleUnit.SelectedItem = wrapper.WholesaleUnitName;
                if (!string.IsNullOrEmpty(wrapper.BatchNumber))
                    txtBatchNumber.Text = wrapper.BatchNumber;
                nudWholesaleQty.Value = wrapper.InputQuantity > 0 ? wrapper.InputQuantity : 1;
                nudWholesalePrice.Value = wrapper.InputPrice >= 0 ? wrapper.InputPrice : 0;
                dtpExpiryDate.Value = wrapper.ExpiryDate;
            }
        }

        private void UpdateTotalAmountLabel()
        {
            decimal total = _importDetailsGridList.Sum(x => x.TotalAmount);
            lblTotal.Text = $"Tổng số tiền:";
            if (txtTotalAmount != null) txtTotalAmount.Text = $"{total:N0} VNĐ";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_importDetailsGridList.Count == 0)
            {
                MessageBox.Show("Phiếu nhập kho phải có ít nhất một mặt hàng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    Import? importToSave = null;
                    if (_import != null)
                    {
                        importToSave = db.Imports.Include(i => i.ImportDetails).FirstOrDefault(i => i.ImportId == _import.ImportId);
                        if (importToSave == null) return;
                        db.ImportDetails.RemoveRange(importToSave.ImportDetails);
                    }
                    else
                    {
                        importToSave = new Import { ImportCode = txtImportCode.Text.Trim() };
                    }

                    importToSave.SupplierId = Convert.ToInt64(cboSupplier.SelectedValue);
                    importToSave.ImportDate = dtpImportDate.Value;
                    importToSave.TotalAmount = _importDetailsGridList.Sum(x => x.TotalAmount);
                    importToSave.CreatedBy = txtCreatedBy.Text.Trim();
                    importToSave.Status = cboStatus.SelectedValue != null ? Convert.ToByte(cboStatus.SelectedValue) : (byte)1;

                    foreach (var wrapper in _importDetailsGridList)
                    {
                        importToSave.ImportDetails.Add(new ImportDetail
                        {
                            ProductId = wrapper.ProductId,
                            BatchNumber = string.IsNullOrEmpty(wrapper.BatchNumber) ? "LOT" : wrapper.BatchNumber,
                            ExpiryDate = wrapper.ExpiryDate,
                            OriginalQuantity = wrapper.InputQuantity,
                            CurrentQuantity = wrapper.InputQuantity,
                            ImportPrice = wrapper.InputPrice
                        });
                    }

                    // ── Cập nhật bảng quy đổi ProductUnit ─────────────────
                    long currentProdId = Convert.ToInt64(cboProduct.SelectedValue);
                    decimal currentWholesalePrice = nudWholesalePrice.Value;
                    string currentWholesaleUnit = cboWholesaleUnit.SelectedItem?.ToString() ?? "";
                    
                    // Lấy tỷ lệ gốc (DB Rate) của ĐV Sỉ làm mỏ neo
                    var dbWholesaleUnit = db.ProductUnits.FirstOrDefault(u => 
                        u.ProductId == currentProdId && u.UnitName.ToLower() == currentWholesaleUnit.ToLower());
                    decimal wholesaleRate = (dbWholesaleUnit != null && dbWholesaleUnit.ConversionRate > 0)
                        ? dbWholesaleUnit.ConversionRate : 1;

                    foreach (var uiUnit in _uiProductUnitsList)
                    {
                        if (string.IsNullOrWhiteSpace(uiUnit.UnitName) || uiUnit.DisplayRatio <= 0) continue;

                        // Tính lại DB Rate (Quy đổi ra ĐV Gốc) từ DisplayRatio
                        int newConversionRate = (int)Math.Round(wholesaleRate / uiUnit.DisplayRatio, 0);
                        if (newConversionRate <= 0) newConversionRate = 1;

                        // Giá nhập = Giá sỉ / DisplayRatio
                        decimal importPriceForUnit = Math.Round(currentWholesalePrice / uiUnit.DisplayRatio, 0);

                        string lowerUnitName = uiUnit.UnitName.Trim().ToLower();
                        var dbUnit = db.ProductUnits.FirstOrDefault(u =>
                            u.ProductId == currentProdId &&
                            u.UnitName.ToLower() == lowerUnitName);

                        if (dbUnit != null)
                        {
                            dbUnit.ConversionRate = uiUnit.ConversionRate;
                            if (importPriceForUnit > 0)
                                dbUnit.ImportPrice = importPriceForUnit;
                        }
                        else
                        {
                            db.ProductUnits.Add(new ProductUnit
                            {
                                ProductId = currentProdId,
                                UnitName = uiUnit.UnitName.Trim(),
                                ConversionRate = uiUnit.ConversionRate,
                                ImportPrice = importPriceForUnit,
                                Price = 0   // Giá bán sẽ do dược sĩ cấu hình trong frmEditProduct
                            });
                        }
                    }

                    if (_import == null) db.Imports.Add(importToSave);
                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật phiếu nhập kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.MdiParent is frmMain mainForm)
                    mainForm.OpenChildForm(new frmManageImport());
                else { this.DialogResult = DialogResult.OK; this.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
                mainForm.OpenChildForm(new frmManageImport());
            else
                this.Close();
        }
    }
}
