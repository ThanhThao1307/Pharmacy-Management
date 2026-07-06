using System;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    string keyword = txtSearch.Text?.Trim() ?? "";

                    var query = db.Customers.AsQueryable();

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(c => c.FullName.Contains(keyword) || c.Phone.Contains(keyword));
                    }

                    dgvCustomers.DataSource = query.OrderBy(c => c.FullName).ToList().Select(c => new
                    {
                        c.CustomerId,
                        c.CustomerCode,
                        c.FullName,
                        GenderText = c.Gender == true ? "Nam" : (c.Gender == false ? "Nữ" : "Khác"),
                        BirthDateText = c.BirthDate.HasValue ? c.BirthDate.Value.ToString("dd/MM/yyyy") : "",
                        c.Phone,
                        c.Email,
                        c.Address,
                        CreatedDateText = c.CreatedDate.ToString("dd/MM/yyyy"),
                        c.TotalSpent,
                        c.LoyaltyPoints,
                        c.CustomerGroup,
                        c.IsActive
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách khách hàng!\n" + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch_Click(object sender, EventArgs e) => LoadData();

        private void btNew_Click(object sender, EventArgs e)
        {
            var inputForm = new frmCustomerInput();
            if (inputForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var idCell = dgvCustomers.Rows[e.RowIndex].Cells["colCustomerId"].Value;
            if (idCell == null) return;

            long customerId = Convert.ToInt64(idCell);
            string colName = dgvCustomers.Columns[e.ColumnIndex].Name;

            if (colName == "colEdit")
            {
                var editForm = new frmCustomerInput(customerId);
                if (editForm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
            else if (colName == "colDelete")
            {
                string customerName = dgvCustomers.Rows[e.RowIndex].Cells["colFullName"].Value?.ToString() ?? "";
                var result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa khách hàng [{customerName}]?",
                    "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (var db = new PharmacyDbContext())
                        {
                            bool hasOrders = db.Orders.Any(o => o.CustomerId == customerId);
                            if (hasOrders)
                            {
                                MessageBox.Show(
                                    "Khách hàng này đã có lịch sử giao dịch, không thể xóa.\n" +
                                    "Hãy vào [Sửa] và đổi trạng thái sang Ngừng hoạt động.",
                                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var c = db.Customers.FirstOrDefault(x => x.CustomerId == customerId);
                            if (c != null)
                            {
                                db.Customers.Remove(c);
                                db.SaveChanges();
                                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa! " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
