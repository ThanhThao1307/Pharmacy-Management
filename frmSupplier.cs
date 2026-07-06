using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    string keyword = txtSearch.Text?.Trim() ?? "";
                    var query = db.Suppliers.AsQueryable();

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(s => s.SupplierName.Contains(keyword) ||
                                                 s.Phone.Contains(keyword) ||
                                                 s.TaxCode.Contains(keyword));
                    }

                    dgvSuppliers.DataSource = query.Select(s => new
                    {
                        s.SupplierId,
                        s.SupplierName,
                        s.Phone,
                        s.TaxCode,
                        s.Email,
                        s.Address,
                        s.Status
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmSupplierInput inputForm = new frmSupplierInput();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var cellIdValue = dgvSuppliers.Rows[e.RowIndex].Cells["SupplierId"].Value;
            if (cellIdValue == null) return;

            long supplierId = Convert.ToInt64(cellIdValue);
            string supplierName = dgvSuppliers.Rows[e.RowIndex].Cells["SupplierName"].Value?.ToString() ?? "";
            string columnName = dgvSuppliers.Columns[e.ColumnIndex].Name ?? "";

            if (columnName == "Edit")
            {
                frmSupplierInput editForm = new frmSupplierInput(supplierId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }

            if (columnName == "Delete")
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà cung cấp [{supplierName}] không?",
                                                      "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (var db = new PharmacyDbContext())
                        {
                            Supplier? supplier = db.Suppliers.Find(supplierId);
                            if (supplier != null)
                            {
                                db.Suppliers.Remove(supplier);
                                db.SaveChanges();
                                MessageBox.Show("Đã xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhà cung cấp này đã phát sinh hóa đơn hoặc chứng từ nhập kho thuốc, không thể xóa vật lý! Bạn hãy bấm [Sửa] và bỏ chọn [Đang hoạt động hợp tác] để ngưng giao dịch.",
                                        "Bảo vệ dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}