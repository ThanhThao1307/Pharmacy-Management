using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
            dgvImports.AutoGenerateColumns = false;
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    string keyword = txtSearch.Text?.Trim().ToLower() ?? "";

                    var query = from i in db.Imports
                                join s in db.Suppliers on i.SupplierId equals s.SupplierId
                                select new ImportViewModel
                                {
                                    ImportId = i.ImportId,
                                    ImportCode = i.ImportCode,
                                    SupplierName = s.SupplierName,
                                    ImportDate = i.ImportDate,
                                    TotalAmount = i.TotalAmount,
                                    CreatedBy = i.CreatedBy,
                                    Status = i.Status,
                                    StatusText = i.Status == 0 ? "0 - Lưu nháp" :
                                                 i.Status == 1 ? "1 - Hoàn thành" : "2 - Đã hủy"
                                };

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(i => i.ImportCode.ToLower().Contains(keyword) ||
                                                 i.CreatedBy.ToLower().Contains(keyword));
                    }

                    dgvImports.DataSource = query.OrderByDescending(i => i.ImportDate).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống gặp lỗi khi tải danh sách phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmImportInput inputForm = new frmImportInput();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvImports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvImports.Rows[e.RowIndex].DataBoundItem is ImportViewModel currentItem)
            {
                long importId = currentItem.ImportId;
                string columnName = dgvImports.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    frmImportInput editForm = new frmImportInput(importId);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }
    }

    public class ImportViewModel
    {
        public long ImportId { get; set; }
        public string ImportCode { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public DateTime ImportDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CreatedBy { get; set; } = null!;
        public byte Status { get; set; }
        public string StatusText { get; set; } = null!;
    }
}