using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmEditOrder : Form
    {
        private long _orderId;

        public frmEditOrder()
        {
            InitializeComponent();
        }

        public frmEditOrder(long orderId) : this()
        {
            _orderId = orderId;
        }

        private void frmEditOrder_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadUsers();
            LoadPrescriptions();
            LoadOrderData();
        }

        private void LoadCustomers()
        {
            using (var db = new PharmacyDbContext())
            {
                var list = db.Customers.Select(c => new CustomerItem
                {
                    Id = c.CustomerId,
                    Name = c.FullName + " (" + c.Phone + ")"
                }).ToList();

                list.Insert(0, new CustomerItem { Id = 0, Name = "-- [Khách mua lẻ - Không lưu tên] --" });

                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "Name";
                cbCustomer.ValueMember = "Id";
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
            }
        }

        private void LoadPrescriptions()
        {
            using (var db = new PharmacyDbContext())
            {
                var list = db.PrescriptionFiles.Where(p => p.Status).Select(p => new PrescriptionItem
                {
                    Id = p.PrescriptionFileId,
                    Name = $"[{p.PrescriptionFileId}] {p.FileName} | {(string.IsNullOrEmpty(p.Note) ? "Toa thuốc" : p.Note)}"
                }).ToList();

                list.Insert(0, new PrescriptionItem { Id = 0, Name = "-- [Không có toa - Thuốc không kê đơn / OTC] --" });

                cbPrescription.DataSource = list;
                cbPrescription.DisplayMember = "Name";
                cbPrescription.ValueMember = "Id";
            }
        }

        private void LoadOrderData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var order = db.Orders.Find(_orderId);
                    if (order == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin hóa đơn này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    txtOrderCode.Text = order.OrderCode;
                    dtpOrderDate.Value = order.OrderDate;
                    cbCustomer.SelectedValue = order.CustomerId ?? 0;
                    cbUser.SelectedValue = order.UserId;
                    cbPrescription.SelectedValue = order.PrescriptionFileId ?? 0;
                    nudDiscount.Value = order.Discount;
                    cbStatus.SelectedIndex = order.Status ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin hóa đơn: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
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
                    var order = db.Orders.Find(_orderId);
                    if (order == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    long? customerId = null;
                    if (cbCustomer.SelectedValue != null && (long)cbCustomer.SelectedValue > 0)
                    {
                        customerId = (long)cbCustomer.SelectedValue;
                    }

                    long? prescriptionId = null;
                    if (cbPrescription.SelectedValue != null && (long)cbPrescription.SelectedValue > 0)
                    {
                        prescriptionId = (long)cbPrescription.SelectedValue;
                    }

                    order.OrderDate = dtpOrderDate.Value;
                    order.CustomerId = customerId;
                    order.UserId = (long)cbUser.SelectedValue;
                    order.PrescriptionFileId = prescriptionId;
                    order.Discount = nudDiscount.Value;
                    order.Status = cbStatus.SelectedIndex == 1; // 1: Hủy, 0: Đã thanh toán

                    // Tính lại NetAmount
                    order.NetAmount = order.TotalAmount - order.Discount < 0 ? 0 : order.TotalAmount - order.Discount;

                    db.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thông tin hóa đơn: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
