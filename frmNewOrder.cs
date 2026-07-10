using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmNewOrder : Form
    {
        public frmNewOrder()
        {
            InitializeComponent();
        }

        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            txtOrderCode.Text = "HD-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            dtpOrderDate.Value = DateTime.Now;
            cbStatus.SelectedIndex = 0; // Đã thanh toán

            LoadCustomers();
            LoadUsers();
            LoadPrescriptions();
        }

        private void LoadCustomers()
        {
            using (var db = new PharmacyDbContext())
            {
                // Lấy danh sách khách hàng và bổ sung tùy chọn khách mua lẻ vãng lai
                var list = db.Customers.Select(c => new CustomerItem
                {
                    Id = c.CustomerId,
                    Name = c.FullName + " (" + c.Phone + ")"
                }).ToList();

                list.Insert(0, new CustomerItem { Id = 0, Name = "-- [Khách mua lẻ - Không lưu tên] --" });

                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "Name";
                cbCustomer.ValueMember = "Id";
                cbCustomer.SelectedIndex = 0;
            }
        }

        private void LoadUsers()
        {
            using (var db = new PharmacyDbContext())
            {
                // Tải danh sách nhân viên và mặc định chọn nhân viên đang đăng nhập
                var list = db.Users.Select(u => new UserItem
                {
                    Id = u.UserId,
                    Name = u.FullName + " (" + u.Username + ")"
                }).ToList();

                cbUser.DataSource = list;
                cbUser.DisplayMember = "Name";
                cbUser.ValueMember = "Id";

                if (Utility.CurrentUser != null)
                {
                    cbUser.SelectedValue = Utility.CurrentUser.UserId;
                }
                else if (list.Count > 0)
                {
                    cbUser.SelectedIndex = 0;
                }
            }
        }

        private void LoadPrescriptions()
        {
            using (var db = new PharmacyDbContext())
            {
                // Lấy danh sách hồ sơ toa thuốc còn hiệu lực để gán vào hóa đơn
                var list = db.PrescriptionFiles.Where(p => p.Status).Select(p => new PrescriptionItem
                {
                    Id = p.PrescriptionFileId,
                    Name = $"[{p.PrescriptionFileId}] {p.FileName} | {(string.IsNullOrEmpty(p.Note) ? "Toa thuốc" : p.Note)}"
                }).ToList();

                list.Insert(0, new PrescriptionItem { Id = 0, Name = "-- [Không có toa - Thuốc không kê đơn / OTC] --" });

                cbPrescription.DataSource = list;
                cbPrescription.DisplayMember = "Name";
                cbPrescription.ValueMember = "Id";
                cbPrescription.SelectedIndex = 0;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderCode.Focus();
                return;
            }

            if (cbUser.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUser.Focus();
                return;
            }

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    // Kiểm tra tính duy nhất của mã hóa đơn
                    string code = txtOrderCode.Text.Trim();
                    if (db.Orders.Any(o => o.OrderCode == code))
                    {
                        MessageBox.Show("Mã hóa đơn này đã tồn tại trong hệ thống, vui lòng đổi mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOrderCode.Focus();
                        return;
                    }

                    // Xác định liên kết khách hàng (nếu không phải khách vãng lai)
                    long? customerId = null;
                    if (cbCustomer.SelectedValue != null && (long)cbCustomer.SelectedValue > 0)
                    {
                        customerId = (long)cbCustomer.SelectedValue;
                    }

                    // Xác định liên kết toa thuốc (nếu có)
                    long? prescriptionId = null;
                    if (cbPrescription.SelectedValue != null && (long)cbPrescription.SelectedValue > 0)
                    {
                        prescriptionId = (long)cbPrescription.SelectedValue;
                    }

                    // Khởi tạo hóa đơn mới với tổng tiền ban đầu bằng 0
                    decimal discount = nudDiscount.Value;
                    var order = new Order
                    {
                        OrderCode = code,
                        OrderDate = dtpOrderDate.Value,
                        CustomerId = customerId,
                        UserId = (long)cbUser.SelectedValue,
                        PrescriptionFileId = prescriptionId,
                        Discount = discount,
                        TotalAmount = 0,
                        NetAmount = 0,
                        Status = cbStatus.SelectedIndex == 1 // 1: Hủy, 0: Đã thanh toán
                    };

                    db.Orders.Add(order);
                    db.SaveChanges();

                    if (MessageBox.Show($"Lập hóa đơn '{order.OrderCode}' thành công!\r\nBạn có muốn mở ngay màn hình nhập chi tiết các mặt hàng thuốc cho hóa đơn này không?", "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        using (var frm = new frmProcessOrderDetails(order.OrderId))
                        {
                            frm.ShowDialog();
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập hóa đơn mới: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public class CustomerItem
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
    }

    public class UserItem
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
    }

    public class PrescriptionItem
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
