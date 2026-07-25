using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmEditProduct : Form
    {
        private Product _product;
        private long _productId;
        private BindingList<ProductUnit> _uiUnitsList = new BindingList<ProductUnit>();

        public frmEditProduct()
        {
            InitializeComponent();
            _product = new Product();
        }

        public frmEditProduct(long productId) : this()
        {
            _productId = productId;
            using (var db = new PharmacyDbContext())
            {
                _product = db.Products.Include(p => p.ProductUnits).FirstOrDefault(p => p.ProductId == productId) ?? new Product();
            }
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            LoadCategoriesToComboBox();
            cboCategories.SelectedIndexChanged += cboCategories_SelectedIndexChanged;
            dgvUnits.AutoGenerateColumns = false;
            dgvUnits.ReadOnly = false;
            dgvUnits.AllowUserToAddRows = false;
            dgvUnits.AllowUserToDeleteRows = false;
            
            if (dgvUnits.Columns["UnitName"] != null) dgvUnits.Columns["UnitName"].ReadOnly = true;
            if (dgvUnits.Columns["ConversionRate"] != null) dgvUnits.Columns["ConversionRate"].ReadOnly = true;  // DisplayRatio
            if (dgvUnits.Columns["ImportPrice"] != null) dgvUnits.Columns["ImportPrice"].ReadOnly = true;
            if (dgvUnits.Columns["Price"] != null)
            {
                dgvUnits.Columns["Price"].ReadOnly = false;
                dgvUnits.Columns["Price"].DefaultCellStyle.Format = "N0";
            }

            this.Text = "Cập nhật thông tin thuốc - Chuẩn nhà thuốc GPP";
            txtProductCode.Text = _product.ProductCode;
            txtProductCode.Enabled = false;

            txtProductName.Text = _product.ProductName;
            cboCategories.SelectedValue = _product.CategoryId;
            UpdateCategoryComboBoxStyle();
            txtUnit.Text = _product.Unit;

            txtNormalPrice.Text = _product.NormalPrice.HasValue ? _product.NormalPrice.Value.ToString("G29", CultureInfo.InvariantCulture) : "";
            txtPrice.Text = _product.Price.ToString("G29", CultureInfo.InvariantCulture);

            chkPrescription.Checked = _product.PrescriptionRequired;
            chkStatus.Checked = _product.Status;
            rtxtDescription.Text = _product.Description;
            txtImageFile.Text = _product.ImageFile;

            if (!string.IsNullOrEmpty(_product.ImageFile))
            {
                string imgPath = Path.Combine(Utility.ImagePath, _product.ImageFile);
                picPreview.Image = Utility.LoadBitmapWithoutLock(imgPath);
            }

            var allUnits = _product.ProductUnits.Where(u => u.ConversionRate > 1).OrderByDescending(u => u.ConversionRate).ToList();
            
            // Tính DisplayRatio cho mỗi đơn vị: 1 ĐV Sỉ = bao nhiêu ĐV lẻ
            // Ví dụ: Viên có ConversionRate=1, Hộp có ConversionRate=100
            // -> DisplayRatio của Hộp = 100 (1 Hộp = 100 Viên)
            foreach (var u in allUnits)
            {
                u.DisplayRatio = u.ConversionRate; // ConversionRate đã là số lượng đv lẻ trong 1 đv sỉ (khi đv gốc là Viên/đv nhỏ nhất)
            }
            
            _uiUnitsList = new BindingList<ProductUnit>(allUnits);
            dgvUnits.DataSource = _uiUnitsList;
        }

        private void btBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                ofd.Title = "Chọn hình ảnh sản phẩm";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImageFile.Text = ofd.FileName;
                    var oldImg = picPreview.Image;
                    picPreview.Image = Utility.LoadBitmapWithoutLock(ofd.FileName);
                    oldImg?.Dispose();
                }
            }
        }

        private void LoadCategoriesToComboBox()
        {
            using (var db = new PharmacyDbContext())
            {
                var categories = db.Categories
                                    .Where(c => c.Status == true || (_product != null && c.CategoryId == _product.CategoryId))
                                    .Select(c => new
                                    {
                                        c.CategoryId,
                                        CategoryName = c.Status == true ? c.CategoryName : c.CategoryName + " [Đã khóa]"
                                    })
                                    .ToList();
                cboCategories.DataSource = categories;
                cboCategories.DisplayMember = "CategoryName";
                cboCategories.ValueMember = "CategoryId";
            }
        }

        private void cboCategories_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateCategoryComboBoxStyle();
        }

        private void UpdateCategoryComboBoxStyle()
        {
            if (cboCategories.SelectedItem != null)
            {
                string catName = cboCategories.Text ?? "";
                if (catName.Contains("[Đã khóa]"))
                {
                    cboCategories.BackColor = Color.FromArgb(255, 235, 235); // Lớp màu nhạt báo hiệu danh mục bị khóa
                }
                else
                {
                    cboCategories.BackColor = Color.White;
                }
            }
            else
            {
                cboCategories.BackColor = Color.White;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text?.Trim() ?? "";
            string baseUnitName = txtUnit.Text?.Trim() ?? "";
            string priceText = txtPrice.Text?.Trim() ?? "";
            string normalPriceText = txtNormalPrice.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(baseUnitName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin cốt lõi bắt buộc của thuốc!", "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal basePriceValue) || basePriceValue <= 0)
            {
                MessageBox.Show("Giá bán đơn vị nhỏ nhất bắt buộc phải là số thực lớn hơn 0!", "Sai định dạng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal? finalNormalPrice = null;
            if (!string.IsNullOrEmpty(normalPriceText))
            {
                if (decimal.TryParse(normalPriceText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal np) && np >= 0)
                {
                    finalNormalPrice = np;
                }
                else
                {
                    MessageBox.Show("Giá niêm yết không hợp lệ hoặc nhỏ hơn 0!", "Sai định dạng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Chỉ kiểm tra giá bán (Price) có hợp lệ không
            foreach (var item in _uiUnitsList)
            {
                if (item.Price <= 0)
                {
                    MessageBox.Show($"Giá bán của đơn vị quy đổi lớn [{item.UnitName}] phải lớn hơn 0đ!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cboCategories.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục thuốc hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    string selectedImagePath = txtImageFile.Text.Trim();
                    if (!string.IsNullOrEmpty(selectedImagePath) && Path.IsPathRooted(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        string currentDest = Path.Combine(Utility.ImagePath, _product.ProductId + Path.GetExtension(selectedImagePath));
                        if (!string.Equals(Path.GetFullPath(selectedImagePath), Path.GetFullPath(currentDest), StringComparison.OrdinalIgnoreCase))
                        {
                            string newHash = Utility.ComputeMD5(selectedImagePath);
                            var otherProducts = db.Products.Where(p => p.ProductId != _product.ProductId && p.ImageFile != null && p.ImageFile != "").ToList();
                            foreach (var otherP in otherProducts)
                            {
                                string otherPath = Path.Combine(Utility.ImagePath, otherP.ImageFile);
                                if (File.Exists(otherPath))
                                {
                                    if (Utility.ComputeMD5(otherPath) == newHash)
                                    {
                                        MessageBox.Show($"Hình ảnh này đã được sử dụng cho Sản phẩm '{otherP.ProductName}' (Mã: {otherP.ProductCode})!\r\nTuyệt đối không sử dụng chung 1 ảnh cho nhiều sản phẩm khác nhau.", "Lỗi trùng lặp hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }
                    }

                    var productToSave = db.Products.Include(p => p.ProductUnits).FirstOrDefault(p => p.ProductId == _product.ProductId);
                    if (productToSave == null) return;

                    productToSave.ProductName = name;
                    productToSave.CategoryId = Convert.ToInt32(cboCategories.SelectedValue);
                    productToSave.Unit = baseUnitName;
                    productToSave.NormalPrice = finalNormalPrice;
                    productToSave.Price = basePriceValue;
                    productToSave.PrescriptionRequired = chkPrescription.Checked;
                    productToSave.Status = chkStatus.Checked;
                    productToSave.Description = rtxtDescription.Text.Trim();

                    var dbBaseUnit = productToSave.ProductUnits.FirstOrDefault(u => u.ConversionRate == 1);
                    if (dbBaseUnit == null)
                    {
                        dbBaseUnit = new ProductUnit { ConversionRate = 1 };
                        productToSave.ProductUnits.Add(dbBaseUnit);
                    }
                    dbBaseUnit.UnitName = baseUnitName;
                    dbBaseUnit.Price = basePriceValue;

                    // Chỉ cập nhật Giá Bán của các đơn vị phụ đã có
                    foreach (var uiUnit in _uiUnitsList)
                    {
                        var dbUnit = productToSave.ProductUnits.FirstOrDefault(u => u.ProductUnitId == uiUnit.ProductUnitId);
                        if (dbUnit != null)
                        {
                            dbUnit.Price = uiUnit.Price;
                        }
                    }

                    db.SaveChanges();

                    selectedImagePath = txtImageFile.Text.Trim();
                    if (!string.IsNullOrEmpty(selectedImagePath) && Path.IsPathRooted(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        string ext = Path.GetExtension(selectedImagePath);
                        string newFileName = productToSave.ProductId + ext;
                        string destPath = Path.Combine(Utility.ImagePath, newFileName);

                        var previewImg = picPreview.Image;
                        picPreview.Image = null;
                        previewImg?.Dispose();

                        string fullSource = Path.GetFullPath(selectedImagePath);
                        string fullDest = Path.GetFullPath(destPath);
                        if (!string.Equals(fullSource, fullDest, StringComparison.OrdinalIgnoreCase))
                        {
                            File.Copy(selectedImagePath, destPath, overwrite: true);
                        }

                        productToSave.ImageFile = newFileName;
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Lưu thông tin sản phẩm và đồng bộ cấu hình quy đổi đơn vị thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.MdiParent is frmMain mainForm)
                {
                    mainForm.OpenChildForm(new frmManageProduct());
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại! Lỗi đồng bộ hệ thống:\n" + ex.Message, "Lỗi kết nối database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmManageProduct());
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
