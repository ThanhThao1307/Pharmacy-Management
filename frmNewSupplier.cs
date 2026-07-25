using System;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmNewSupplier : Form
    {
        private readonly PharmacyDbContext _db = new PharmacyDbContext();

        public frmNewSupplier()
        {
            InitializeComponent();
        }

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm mới nhà cung cấp";
            chkStatus.Checked = true;
            txtSupplierName.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text?.Trim() ?? "";
            string phone = txtPhone.Text?.Trim() ?? "";
            string taxCode = txtTaxCode.Text?.Trim() ?? "";
            string email = txtEmail.Text?.Trim() ?? "";
            string address = txtAddress.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(taxCode))
            {
                MessageBox.Show("Mã số thuế không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaxCode.Focus();
                return;
            }

            try
            {
                var supplier = new Supplier
                {
                    SupplierName = name,
                    Phone = phone,
                    TaxCode = taxCode,
                    Email = string.IsNullOrEmpty(email) ? null : email,
                    Address = string.IsNullOrEmpty(address) ? null : address,
                    Status = chkStatus.Checked
                };

                _db.Suppliers.Add(supplier);
                _db.SaveChanges();

                MessageBox.Show("Lưu thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.MdiParent is frmMain mainForm)
                {
                    mainForm.OpenChildForm(new frmManageSupplier());
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmManageSupplier());
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _db?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
