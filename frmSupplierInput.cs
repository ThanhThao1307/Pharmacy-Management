using System;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmSupplierInput : Form
    {
        private readonly PharmacyDbContext _db = new PharmacyDbContext();
        private readonly Supplier? _supplier;
        private readonly bool _isEditMode = false;

        // Constructor cho chức năng THÊM MỚI
        public frmSupplierInput()
        {
            InitializeComponent();
            _supplier = new Supplier();
            _isEditMode = false;
        }

        // Constructor cho chức năng CẬP NHẬT (SỬA)
        public frmSupplierInput(long supplierId)
        {
            InitializeComponent();
            _supplier = _db.Suppliers.Find(supplierId);
            _isEditMode = true;
        }

        private void frmSupplierInput_Load(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                this.Text = "Cập nhật nhà cung cấp";
                if (_supplier != null)
                {
                    // Đổ dữ liệu từ Database lên giao diện (KHÔNG CÓ SUPPLIERCODE)
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
            else
            {
                this.Text = "Thêm mới nhà cung cấp";
                chkStatus.Checked = true; // Mặc định kích hoạt hoạt động khi thêm mới
                txtSupplierName.Focus();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text?.Trim() ?? "";
            string phone = txtPhone.Text?.Trim() ?? "";
            string taxCode = txtTaxCode.Text?.Trim() ?? "";
            string email = txtEmail.Text?.Trim() ?? "";
            string address = txtAddress.Text?.Trim() ?? "";

            // Ràng buộc nghiệp vụ theo DataAnnotations của Database
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
                // Gán dữ liệu vào đối tượng Model
                _supplier.SupplierName = name;
                _supplier.Phone = phone;
                _supplier.TaxCode = taxCode;

                // Các trường cho phép nhận thuộc tính NULL trong Database
                _supplier.Email = string.IsNullOrEmpty(email) ? null : email;
                _supplier.Address = string.IsNullOrEmpty(address) ? null : address;
                _supplier.Status = chkStatus.Checked;

                if (!_isEditMode)
                {
                    _db.Suppliers.Add(_supplier);
                }

                _db.SaveChanges();
                MessageBox.Show("Lưu thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _db?.Dispose();
            base.OnFormClosed(e);
        }
    }
}