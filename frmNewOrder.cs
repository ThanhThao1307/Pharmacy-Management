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
        private long? _currentPrescriptionId = null;

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

            txtPrescriptionInfo.Text = "Chưa có hồ sơ Toa thuốc (Thuốc OTC / Không kê đơn)";
            txtTotalAmount.Text = "0 VNĐ";
            txtNetAmount.Text = "0 VNĐ";
        }

        private void LoadCustomers()
        {
            using (var db = new PharmacyDbContext())
            {
                var list = db.Customers.Where(c => c.IsActive == true).Select(c => new CustomerItem
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
                cbUser.Enabled = false;
            }
        }

        private void btPrescriptionDetail_Click(object sender, EventArgs e)
        {
            if (_currentPrescriptionId.HasValue && _currentPrescriptionId.Value > 0)
            {
                using (var frm = new frmEditPrescription(_currentPrescriptionId.Value, 0))
                {
                    if (frm.ShowDialog() == DialogResult.OK && frm.SavedPrescriptionFileId > 0)
                    {
                        _currentPrescriptionId = frm.SavedPrescriptionFileId;
                        UpdatePrescriptionDisplay();
                    }
                }
            }
            else
            {
                using (var frm = new frmNewPrescription(0))
                {
                    if (frm.ShowDialog() == DialogResult.OK && frm.SavedPrescriptionFileId > 0)
                    {
                        _currentPrescriptionId = frm.SavedPrescriptionFileId;
                        UpdatePrescriptionDisplay();
                        btPrescriptionDetail.Text = "✏ Sửa Toa thuốc GPP";
                    }
                }
            }
        }

        private void UpdatePrescriptionDisplay()
        {
            if (_currentPrescriptionId.HasValue && _currentPrescriptionId.Value > 0)
            {
                using (var db = new PharmacyDbContext())
                {
                    var p = db.PrescriptionFiles.Find(_currentPrescriptionId);
                    if (p != null)
                    {
                        string note = string.IsNullOrEmpty(p.Note) ? "Toa thuốc GPP" : p.Note;
                        txtPrescriptionInfo.Text = $"✔ [{p.PrescriptionFileId}] {p.FileName} | {note}";
                    }
                }
            }
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            decimal net = (0 - nudDiscount.Value) < 0 ? 0 : (0 - nudDiscount.Value);
            txtNetAmount.Text = net.ToString("N0") + " VNĐ";
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
                    string code = txtOrderCode.Text.Trim();
                    if (db.Orders.Any(o => o.OrderCode == code))
                    {
                        MessageBox.Show("Mã hóa đơn này đã tồn tại trong hệ thống, vui lòng đổi mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOrderCode.Focus();
                        return;
                    }

                    long? customerId = null;
                    if (cbCustomer.SelectedValue != null && (long)cbCustomer.SelectedValue > 0)
                    {
                        customerId = (long)cbCustomer.SelectedValue;
                    }

                    decimal discount = nudDiscount.Value;
                    var order = new Order
                    {
                        OrderCode = code,
                        OrderDate = dtpOrderDate.Value,
                        CustomerId = customerId,
                        UserId = (long)cbUser.SelectedValue,
                        PrescriptionFileId = _currentPrescriptionId,
                        Discount = discount,
                        TotalAmount = 0,
                        NetAmount = 0,
                        Status = cbStatus.SelectedIndex == 1
                    };

                    db.Orders.Add(order);
                    db.SaveChanges();

                    if (MessageBox.Show($"Lập hóa đơn '{order.OrderCode}' thành công!\r\nBạn có muốn mở ngay màn hình nhập chi tiết các mặt hàng thuốc cho hóa đơn này không?", "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (this.MdiParent is frmMain mainForm)
                        {
                            mainForm.OpenChildForm(new frmProcessOrderDetails(order.OrderId));
                            return;
                        }
                        else
                        {
                            this.Hide();
                            using (var frm = new frmProcessOrderDetails(order.OrderId))
                            {
                                frm.ShowDialog();
                            }
                        }
                    }

                    if (this.MdiParent is frmMain mainForm2)
                    {
                        mainForm2.OpenChildForm(new frmManageOrder());
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập hóa đơn mới: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmManageOrder());
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
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
}
