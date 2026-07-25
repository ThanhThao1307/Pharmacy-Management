using System;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmEditCustomer : Form
    {
        private long _customerId;

        public frmEditCustomer()
        {
            InitializeComponent();
        }

        public frmEditCustomer(long customerId) : this()
        {
            _customerId = customerId;
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            cboGender.Items.Clear();
            cboGender.Items.Add("-- Chưa xác định --");
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.SelectedIndex = 0;

            this.Text = "Cập nhật thông tin khách hàng";

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var customer = db.Customers.FirstOrDefault(c => c.CustomerId == _customerId);
                    if (customer != null)
                    {
                        txtName.Text = customer.FullName;

                        if (customer.Gender == true) cboGender.SelectedIndex = 1;
                        else if (customer.Gender == false) cboGender.SelectedIndex = 2;
                        else cboGender.SelectedIndex = 0;

                        dtpBirthDate.Value = customer.BirthDate ?? DateTime.Today.AddYears(-20);

                        txtPhone.Text = customer.Phone;
                        txtAddress.Text = customer.Address;
                        txtEmail.Text = customer.Email;
                        chkStatus.Checked = customer.IsActive;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin khách hàng: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Họ tên khách hàng không được bỏ trống!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var customerToSave = db.Customers.FirstOrDefault(c => c.CustomerId == _customerId);
                    if (customerToSave == null)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu khách hàng cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool phoneExists = db.Customers.Any(c => c.Phone == phone && c.CustomerId != _customerId);
                    if (phoneExists)
                    {
                        MessageBox.Show($"Số điện thoại [{phone}] đã được đăng ký bởi khách hàng khác!",
                            "Trùng thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPhone.Focus();
                        return;
                    }

                    customerToSave.FullName = name;

                    if (cboGender.SelectedIndex == 1) customerToSave.Gender = true;
                    else if (cboGender.SelectedIndex == 2) customerToSave.Gender = false;
                    else customerToSave.Gender = null;

                    customerToSave.BirthDate = dtpBirthDate.Value.Date;
                    customerToSave.Phone = phone;
                    customerToSave.Address = txtAddress.Text.Trim();
                    customerToSave.Email = txtEmail.Text.Trim();
                    customerToSave.IsActive = chkStatus.Checked;

                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.MdiParent is frmMain mainForm)
                {
                    mainForm.OpenChildForm(new frmManageCustomer());
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmManageCustomer());
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
