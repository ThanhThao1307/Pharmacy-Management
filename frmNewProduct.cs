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
    public partial class frmNewProduct : Form
    {

        public frmNewProduct()
        {
            InitializeComponent();
        }

        private void frmNewProduct_Load(object sender, EventArgs e)
        {
            LoadCategoriesToComboBox();

            this.Text = "Thêm mới sản phẩm thuốc";
            chkStatus.Checked = true;
            txtProductCode.Focus();
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

            if (cboCategories.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục thuốc hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    if (db.Products.Any(p => p.ProductCode.ToLower() == code.ToLower()))
                    {
                        MessageBox.Show($"Mã sản phẩm thuốc [{code}] đã tồn tại trong hệ thống!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string selectedImagePath = txtImageFile.Text.Trim();
                    if (!string.IsNullOrEmpty(selectedImagePath) && Path.IsPathRooted(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        string newHash = Utility.ComputeMD5(selectedImagePath);
                        var otherProducts = db.Products.Where(p => p.ImageFile != null && p.ImageFile != "").ToList();
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

                    var productToSave = new Product
                    {
                        ProductCode = code,
                        ProductName = name,
                        CategoryId = Convert.ToInt32(cboCategories.SelectedValue),
                        Unit = baseUnitName,
                        NormalPrice = finalNormalPrice,
                        Price = basePriceValue,
                        PrescriptionRequired = chkPrescription.Checked,
                        Status = chkStatus.Checked,
                        Description = rtxtDescription.Text.Trim()
                    };

                    db.Products.Add(productToSave);
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
