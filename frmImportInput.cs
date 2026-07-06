using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmImportInput : Form
    {
        private Import? _import;
        private bool _isEditMode = false;
        private BindingList<ImportDetailWrapper> _importDetailsGridList = new BindingList<ImportDetailWrapper>();

        public class ImportDetailWrapper
        {
            public long ProductId { get; set; }
            public string ProductCode { get; set; } = string.Empty;
            public string ProductName { get; set; } = string.Empty;
            public string SelectedUnitName { get; set; } = string.Empty;
            public int SelectedConversionRate { get; set; }
            public int InputQuantity { get; set; }
            public decimal InputPrice { get; set; }
            public string BatchNumber { get; set; } = string.Empty;
            public DateTime ExpiryDate { get; set; } = DateTime.Today.AddYears(1);
            public decimal TotalAmount => InputQuantity * InputPrice;
        }

        public frmImportInput()
        {
            InitializeComponent();
            _import = new Import { ImportCode = "", ImportDate = DateTime.Now, Status = 0 };
            _isEditMode = false;
        }

        public frmImportInput(long importId)
        {
            InitializeComponent();
            using (var db = new PharmacyDbContext())
            {
                _import = db.Imports.Include(i => i.ImportDetails).ThenInclude(d => d.Product)
                             .FirstOrDefault(i => i.ImportId == importId);
            }
            _isEditMode = true;
        }

        private void frmImportInput_Load(object sender, EventArgs e)
        {
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

            dgvImportDetails.AutoGenerateColumns = false;

            txtCreatedBy.Enabled = false;

            if (_isEditMode && _import != null)
            {
                this.Text = "Cập nhật thông tin phiếu nhập kho";
                txtImportCode.Text = _import.ImportCode;
                txtImportCode.Enabled = false;

                cboSupplier.SelectedValue = _import.SupplierId;
                dtpImportDate.Value = _import.ImportDate;
                txtCreatedBy.Text = _import.CreatedBy;
                cboStatus.SelectedValue = _import.Status;

                foreach (var detail in _import.ImportDetails)
                {
                    if (detail.Product != null)
                    {
                        _importDetailsGridList.Add(new ImportDetailWrapper
                        {
                            ProductId = detail.ProductId,
                            ProductCode = detail.Product.ProductCode,
                            ProductName = detail.Product.ProductName,
                            SelectedUnitName = detail.Product.Unit,
                            SelectedConversionRate = 1,
                            InputQuantity = detail.OriginalQuantity,
                            InputPrice = detail.ImportPrice,
                            BatchNumber = detail.BatchNumber ?? "LOT",
                            ExpiryDate = detail.ExpiryDate
                        });
                    }
                }
            }
            else
            {
                this.Text = "Lập phiếu nhập kho dược mới";
                txtImportCode.Text = "PNK-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                txtCreatedBy.Text = Utility.CurrentUser?.Username ?? "admin";
                cboStatus.SelectedValue = (byte)1;
                dtpExpiryDate.Value = DateTime.Today.AddYears(2);
                txtBatchNumber.Text = "LOT-" + DateTime.Now.ToString("MM-yy");
            }

            dgvImportDetails.DataSource = _importDetailsGridList;
            UpdateTotalAmountLabel();
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
        }

        private void ShowSelectedProductImage()
        {
            var selected = cboProduct.SelectedItem as Product;
            var oldImage = picProductImage.Image;
            if (selected != null && !string.IsNullOrEmpty(selected.ImageFile))
            {
                string imgPath = Path.Combine(Utility.ImagePath, selected.ImageFile);
                picProductImage.Image = Utility.LoadBitmapWithoutLock(imgPath);
            }
            else
            {
                picProductImage.Image = null;
            }
            oldImage?.Dispose();
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedProductImage();
        }

        private void btAddDetail_Click(object sender, EventArgs e)
        {
            if (cboProduct.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm thuốc để thêm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = (Product?)cboProduct.SelectedItem;
            string batch = txtBatchNumber.Text.Trim();
            if (string.IsNullOrEmpty(batch))
            {
                MessageBox.Show("Vui lòng nhập số lô sản xuất!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)nudOriginalQuantity.Value;
            decimal price = nudImportPrice.Value;

            var existing = _importDetailsGridList.FirstOrDefault(x => x.ProductId == selectedProduct!.ProductId && x.BatchNumber.Equals(batch, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                existing.InputQuantity += qty;
                _importDetailsGridList.ResetBindings();
            }
            else
            {
                _importDetailsGridList.Add(new ImportDetailWrapper
                {
                    ProductId = selectedProduct!.ProductId,
                    ProductCode = selectedProduct.ProductCode,
                    ProductName = selectedProduct.ProductName,
                    SelectedUnitName = selectedProduct.Unit,
                    SelectedConversionRate = 1,
                    InputQuantity = qty,
                    InputPrice = price,
                    BatchNumber = batch,
                    ExpiryDate = dtpExpiryDate.Value
                });
            }

            UpdateTotalAmountLabel();
        }

        private void dgvImportDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvImportDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                _importDetailsGridList.RemoveAt(e.RowIndex);
                UpdateTotalAmountLabel();
            }
        }

        private void dgvImportDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotalAmountLabel();
        }

        private void UpdateTotalAmountLabel()
        {
            decimal total = _importDetailsGridList.Sum(x => x.TotalAmount);
            lblTotal.Text = $"Tổng số tiền: {total:N0} VNĐ";
            txtTotalAmount.Text = total.ToString("F0");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng lựa chọn nhà cung cấp hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_importDetailsGridList.Count == 0)
            {
                MessageBox.Show("Phiếu nhập kho bắt buộc phải chứa ít nhất một mặt hàng thuốc!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    Import? importToSave;
                    if (_isEditMode && _import != null)
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
                        int finalQuantity = wrapper.InputQuantity * wrapper.SelectedConversionRate;
                        decimal finalPrice = wrapper.InputPrice / wrapper.SelectedConversionRate;

                        var detail = new ImportDetail
                        {
                            ProductId = wrapper.ProductId,
                            BatchNumber = string.IsNullOrEmpty(wrapper.BatchNumber) ? "LOT" : wrapper.BatchNumber,
                            ExpiryDate = wrapper.ExpiryDate,
                            OriginalQuantity = finalQuantity,
                            CurrentQuantity = finalQuantity,
                            ImportPrice = finalPrice
                        };

                        importToSave.ImportDetails.Add(detail);
                    }

                    if (!_isEditMode)
                    {
                        db.Imports.Add(importToSave);
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Lập phiếu nhập kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi lưu kho: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}