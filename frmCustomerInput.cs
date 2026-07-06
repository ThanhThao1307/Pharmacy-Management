using System;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmCustomerInput : Form
    {
        private Customer? _customer;
        private readonly bool _isEditMode = false;

        public frmCustomerInput()
        {
            InitializeComponent();
            _customer = new Customer();
            _isEditMode = false;
        }

        public frmCustomerInput(long customerId)
        {
            InitializeComponent();
            using (var db = new PharmacyDbContext())
            {
                _customer = db.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            }
            _isEditMode = true;
        }

        private void frmCustomerInput_Load(object sender, EventArgs e)
        {
            cboGender.Items.Clear();
            cboGender.Items.Add("-- Chưa xác định --");
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.SelectedIndex = 0;

            if (_isEditMode && _customer != null)
            {
                this.Text = "Cập nhật thông tin khách hàng";
                txtName.Text = _customer.FullName;

                if (_customer.Gender == true) cboGender.SelectedIndex = 1;
                else if (_customer.Gender == false) cboGender.SelectedIndex = 2;
                else cboGender.SelectedIndex = 0;

                dtpBirthDate.Value = _customer.BirthDate ?? DateTime.Today.AddYears(-20);

                txtPhone.Text = _customer.Phone;
                txtAddress.Text = _customer.Address;
                txtEmail.Text = _customer.Email;
                chkStatus.Checked = _customer.IsActive;
            }
            else
            {
                this.Text = "Đăng ký khách hàng mới";
                chkStatus.Checked = true;
                dtpBirthDate.Value = DateTime.Today.AddYears(-20);
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
                    Customer? customerToSave;

                    if (_isEditMode && _customer != null)
                    {
                        customerToSave = db.Customers.FirstOrDefault(c => c.CustomerId == _customer.CustomerId);
                        if (customerToSave == null) return;
                    }
                    else
                    {
                        bool phoneExists = db.Customers.Any(c => c.Phone == phone);
                        if (phoneExists)
                        {
                            MessageBox.Show($"Số điện thoại [{phone}] đã được đăng ký bởi khách hàng khác!",
                                "Trùng thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPhone.Focus();
                            return;
                        }

                        customerToSave = new Customer();
                        long nextId = db.Customers.Any() ? db.Customers.Max(c => c.CustomerId) + 1 : 1;
                        customerToSave.CustomerCode = "KH" + nextId.ToString("D3");
                        customerToSave.CreatedDate = DateTime.Now;
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

                    if (!_isEditMode)
                        db.Customers.Add(customerToSave);

                    db.SaveChanges();
                }

                MessageBox.Show("Lưu thông tin khách hàng thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
