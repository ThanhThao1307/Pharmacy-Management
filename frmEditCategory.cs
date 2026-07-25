using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmEditCategory : Form
    {
        private readonly PharmacyDbContext _db = new PharmacyDbContext();
        private Category? _category;
        private int _categoryId;

        public frmEditCategory()
        {
            InitializeComponent();
        }

        public frmEditCategory(int categoryId) : this()
        {
            _categoryId = categoryId;
            _category = _db.Categories.Find(categoryId);
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật danh mục nhóm thuốc";
            lblFormTitle.Text = "CẬP NHẬT DANH MỤC THUỐC";

            if (_category != null)
            {
                txtCategoryCode.Text = _category.CategoryCode;
                txtCategoryName.Text = _category.CategoryName;
                txtDescription.Text = _category.Description;
                chkStatus.Checked = _category.Status;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu danh mục này trên hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string code = txtCategoryCode.Text?.Trim() ?? "";
            string name = txtCategoryName.Text?.Trim() ?? "";
            string description = txtDescription.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Mã danh mục không được để trống!", "Yêu cầu nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên nhóm thuốc không được để trống!", "Yêu cầu nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            if (_category == null)
            {
                MessageBox.Show("Đối tượng dữ liệu không hợp lệ hoặc đã bị xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!string.Equals(_category.CategoryCode, code, StringComparison.OrdinalIgnoreCase))
                {
                    bool exists = _db.Categories.Any(c => c.CategoryCode.ToLower() == code.ToLower() && c.CategoryId != _categoryId);
                    if (exists)
                    {
                        MessageBox.Show("Mã danh mục này đã tồn tại trong hệ thống! Vui lòng chọn mã khác.", "Trùng lặp dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCategoryCode.Focus();
                        return;
                    }
                }

                _category.CategoryCode = code;
                _category.CategoryName = name;
                _category.Description = string.IsNullOrEmpty(description) ? null : description;
                _category.Status = chkStatus.Checked;

                _db.SaveChanges();

                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.MdiParent is frmMain mainForm)
                {
                    mainForm.OpenChildForm(new frmManageCategory());
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống khi lưu: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmManageCategory());
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
