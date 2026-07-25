using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmManageOrder : Form
    {
        public frmManageOrder()
        {
            InitializeComponent();
            dgvOrders.AutoGenerateColumns = false;
        }

        private void frmManageOrder_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year + 1; i >= 2020; i--)
            {
                cbYear.Items.Add(i);
            }
            cbYear.SelectedItem = DateTime.Now.Year;

            cbMonth.Items.Add("Tất cả");
            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i.ToString());
            }
            cbMonth.SelectedIndex = 0; // Chọn "Tất cả"

            LoadData();
        }

        public void LoadData(bool filterByDate = false)
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    int year = DateTime.Now.Year;
                    if (cbYear.SelectedItem != null && int.TryParse(cbYear.SelectedItem.ToString(), out int parsedYear))
                    {
                        year = parsedYear;
                    }

                    int month = 0;
                    if (cbMonth.SelectedItem != null && cbMonth.SelectedItem.ToString() != "Tất cả")
                    {
                        int.TryParse(cbMonth.SelectedItem.ToString(), out month);
                    }

                    // Lấy danh sách hóa đơn
                    var query = db.Orders
                        .Include(o => o.Customer)
                        .Include(o => o.User)
                        .AsQueryable();

                    // Lọc hóa đơn theo thời gian
                    if (filterByDate)
                    {
                        DateTime targetDate = dtpOrderDate.Value.Date;
                        query = query.Where(o => o.OrderDate.Date == targetDate);
                    }
                    else
                    {
                        if (cbYear.SelectedItem != null)
                        {
                            query = query.Where(o => o.OrderDate.Year == year);
                        }

                        if (month > 0)
                        {
                            query = query.Where(o => o.OrderDate.Month == month);
                        }
                    }

                    string keyword = txtSearch.Text?.Trim().ToLower() ?? "";
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(o => o.OrderCode.ToLower().Contains(keyword) ||
                                                 (o.Customer != null && (o.Customer.FullName.ToLower().Contains(keyword) || o.Customer.Phone.Contains(keyword))) ||
                                                 (o.User != null && o.User.FullName.ToLower().Contains(keyword)));
                    }

                    var list = query.OrderByDescending(o => o.OrderDate).Select(o => new OrderViewModel
                    {
                        OrderId = o.OrderId,
                        OrderCode = o.OrderCode,
                        OrderDate = o.OrderDate,
                        CustomerName = o.Customer != null ? o.Customer.FullName : "Khách lẻ",
                        UserName = o.User != null ? o.User.FullName : "N/A",
                        TotalAmount = o.TotalAmount,
                        Discount = o.Discount,
                        NetAmount = o.NetAmount,
                        Status = o.Status
                    }).ToList();

                    dgvOrders.DataSource = list;
                    lblNumOfOrder.Text = $"Số hóa đơn: {list.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmNewOrder());
            }
            else
            {
                using (var frm = new frmNewOrder())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvOrders.Rows[e.RowIndex].DataBoundItem is OrderViewModel currentItem)
            {
                long orderId = currentItem.OrderId;
                string colName = dgvOrders.Columns[e.ColumnIndex].Name;

                if (colName == "colDetail" || colName == "colEdit")
                {
                    if (this.MdiParent is frmMain mainForm)
                    {
                        mainForm.OpenChildForm(new frmProcessOrderDetails(orderId));
                    }
                    else
                    {
                        using (var frm = new frmProcessOrderDetails(orderId))
                        {
                            frm.ShowDialog();
                            LoadData();
                        }
                    }
                }
                else if (colName == "colPrint")
                {
                    if (this.MdiParent is frmMain mainForm)
                    {
                        mainForm.OpenChildForm(new frmReportInvoice(orderId));
                    }
                    else
                    {
                        using (var frm = new frmReportInvoice(orderId))
                        {
                            frm.StartPosition = FormStartPosition.CenterScreen;
                            frm.ShowDialog();
                        }
                    }
                }
                else if (colName == "colDelete")
                {
                    if (MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn '{currentItem.OrderCode}'?\r\nLưu ý: Các mặt hàng thuốc trong hóa đơn sẽ được hoàn lại vào kho!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteOrder(orderId);
                    }
                }
            }
        }

        private void DeleteOrder(long orderId)
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var order = db.Orders.Include(o => o.OrderDetails).SingleOrDefault(o => o.OrderId == orderId);
                    if (order == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn này trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Hoàn trả tồn kho
                    foreach (var detail in order.OrderDetails)
                    {
                        var batch = db.ImportDetails.Find(detail.ImportDetailId);
                        if (batch != null)
                        {
                            batch.CurrentQuantity += (detail.Quantity * detail.ConversionRate);
                        }
                    }

                    // Xóa hóa đơn
                    long? customerId = order.CustomerId;
                    db.OrderDetails.RemoveRange(order.OrderDetails);
                    db.Orders.Remove(order);
                    db.SaveChanges();
                    
                    if (customerId.HasValue)
                    {
                        var customer = db.Customers.Find(customerId.Value);
                        if (customer != null)
                        {
                            decimal realTotalSpent = db.Orders
                                .Where(o => o.CustomerId == customerId.Value && o.Status == false)
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

                    MessageBox.Show("Xóa hóa đơn thành công và đã hoàn lại tồn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class OrderViewModel
    {
        public long OrderId { get; set; }
        public string OrderCode { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal NetAmount { get; set; }
        public bool Status { get; set; }
        public string StatusText => Status ? "1 - Đã hủy" : "0 - Đã thanh toán";
    }
}
