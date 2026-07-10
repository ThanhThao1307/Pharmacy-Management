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
    public partial class frmProductInput : Form
    {
        private readonly Product _product;
        private readonly bool _isEditMode = false;
        private BindingList<ProductUnit> _uiUnitsList = new BindingList<ProductUnit>();

        public frmProductInput()
        {
            InitializeComponent();
            _product = new Product();
            _isEditMode = false;
        }

        public frmProductInput(long productId)
        {
            InitializeComponent();
            using (var db = new PharmacyDbContext())
            {
                _product = db.Products.Include(p => p.ProductUnits).FirstOrDefault(p => p.ProductId == productId) ?? new Product();
            }
            _isEditMode = true;
        }

        private void frmProductInput_Load(object sender, EventArgs e)
        {
            LoadCategoriesToComboBox();
            dgvUnits.AutoGenerateColumns = false;

            if (_isEditMode)
            {
                this.Text = "Cập nhật thông tin thuốc - Chuẩn nhà thuốc GPP";
                txtProductCode.Text = _product.ProductCode;
                txtProductCode.Enabled = false;
                txtProductCode.BackColor = Color.FromArgb(240, 240, 240);

                txtProductName.Text = _product.ProductName;
                cboCategories.SelectedValue = _product.CategoryId;
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

                var subUnits = _product.ProductUnits.Where(u => u.ConversionRate > 1).ToList();
                _uiUnitsList = new BindingList<ProductUnit>(subUnits);
            }
            else
            {
                this.Text = "Thêm mới sản phẩm thuốc & Đơn vị tính quy đổi";
                chkStatus.Checked = true;
                _uiUnitsList = new BindingList<ProductUnit>();
            }

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
                                    .Where(c => c.Status == true)
                                    .Select(c => new { c.CategoryId, c.CategoryName })
                                    .ToList();
                cboCategories.DataSource = categories;
                cboCategories.DisplayMember = "CategoryName";
                cboCategories.ValueMember = "CategoryId";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string code = txtProductCode.Text?.Trim() ?? "";
            string name = txtProductName.Text?.Trim() ?? "";
            string baseUnitName = txtUnit.Text?.Trim() ?? "";
            string priceText = txtPrice.Text?.Trim() ?? "";
            string normalPriceText = txtNormalPrice.Text?.Trim() ?? "";

            // Kiểm tra tính hợp lệ của thông tin cơ bản và giá bán
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(baseUnitName))
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

            // Kiểm tra ràng buộc cho các đơn vị tính phụ và tỷ lệ quy đổi
            foreach (var item in _uiUnitsList)
            {
                if (string.IsNullOrEmpty(item.UnitName))
                {
                    MessageBox.Show("Tên đơn vị quy đổi trên danh sách lưới không được bỏ trống!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.ConversionRate <= 1)
                {
                    MessageBox.Show($"Đơn vị tính phụ [{item.UnitName}] bắt buộc phải có hệ số quy đổi lớn hơn 1!", "Sai nguyên lý nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                    // Thêm mới hoặc cập nhật thông tin sản phẩm trong cơ sở dữ liệu
                    Product? productToSave;
                    if (_isEditMode)
                    {
                        productToSave = db.Products.Include(p => p.ProductUnits).FirstOrDefault(p => p.ProductId == _product.ProductId);
                        if (productToSave == null) return;
                    }
                    else
                    {
                        productToSave = new Product { ProductCode = code };
                        if (db.Products.Any(p => p.ProductCode.ToLower() == code.ToLower()))
                        {
                            MessageBox.Show($"Mã sản phẩm thuốc [{code}] đã tồn tại trong hệ thống!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    productToSave.ProductName = name;
                    productToSave.CategoryId = Convert.ToInt32(cboCategories.SelectedValue);
                    productToSave.Unit = baseUnitName;
                    productToSave.NormalPrice = finalNormalPrice;
                    productToSave.Price = basePriceValue;
                    productToSave.PrescriptionRequired = chkPrescription.Checked;
                    productToSave.Status = chkStatus.Checked;
                    productToSave.Description = rtxtDescription.Text.Trim();

                    // Cập nhật đơn vị tính cơ bản (hệ số quy đổi = 1)
                    var dbBaseUnit = productToSave.ProductUnits.FirstOrDefault(u => u.ConversionRate == 1);
                    if (dbBaseUnit == null)
                    {
                        dbBaseUnit = new ProductUnit { ConversionRate = 1 };
                        productToSave.ProductUnits.Add(dbBaseUnit);
                    }
                    dbBaseUnit.UnitName = baseUnitName;
                    dbBaseUnit.Price = basePriceValue;

                    // Đồng bộ danh sách đơn vị tính phụ (thêm mới, sửa, xóa các đơn vị không còn sử dụng)
                    var dbSubUnits = productToSave.ProductUnits.Where(u => u.ConversionRate > 1).ToList();
                    foreach (var oldUnit in dbSubUnits)
                    {
                        if (!_uiUnitsList.Any(u => u.ProductUnitId == oldUnit.ProductUnitId))
                        {
                            db.ProductUnits.Remove(oldUnit);
                        }
                    }

                    foreach (var uiUnit in _uiUnitsList)
                    {
                        if (uiUnit.ProductUnitId == 0)
                        {
                            uiUnit.ProductId = productToSave.ProductId;
                            productToSave.ProductUnits.Add(uiUnit);
                        }
                        else
                        {
                            var dbUnit = productToSave.ProductUnits.FirstOrDefault(u => u.ProductUnitId == uiUnit.ProductUnitId);
                            if (dbUnit != null)
                            {
                                dbUnit.UnitName = uiUnit.UnitName ?? "Đơn vị phụ";
                                dbUnit.ConversionRate = uiUnit.ConversionRate;
                                dbUnit.Price = uiUnit.Price;
                            }
                        }
                    }

                    if (!_isEditMode)
                    {
                        db.Products.Add(productToSave);
                    }

                    db.SaveChanges();

                    // Xử lý sao chép file hình ảnh sản phẩm theo ID thuốc vào thư mục Images
                    string selectedImagePath = txtImageFile.Text.Trim();
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại! Lỗi đồng bộ hệ thống:\n" + ex.Message, "Lỗi kết nối database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}