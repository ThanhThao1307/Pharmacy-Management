using System;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmEditSupplier : Form
    {
        private readonly PharmacyDbContext _db = new PharmacyDbContext();
        private readonly Supplier? _supplier;
        private long _supplierId;

        public frmEditSupplier()
        {
            InitializeComponent();
        }

        public frmEditSupplier(long supplierId) : this()
        {
            _supplierId = supplierId;
            _supplier = _db.Suppliers.Find(supplierId);
        }

        private void frmEditSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật nhà cung cấp";
            if (_supplier != null)
            {
                txtSupplierName.Text = _supplier.SupplierName;
                txtPhone.Text = _supplier.Phone;
                txtTaxCode.Text = _supplier.TaxCode;
                txtEmail.Text = _supplier.Email;
                txtAddress.Text = _supplier.Address;
                chkStatus.Checked = _supplier.Status;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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

            if (_supplier == null) return;

            try
            {
                _supplier.SupplierName = name;
                _supplier.Phone = phone;
                _supplier.TaxCode = taxCode;
                _supplier.Email = string.IsNullOrEmpty(email) ? null : email;
                _supplier.Address = string.IsNullOrEmpty(address) ? null : address;
                _supplier.Status = chkStatus.Checked;

                _db.SaveChanges();
                MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
