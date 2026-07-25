using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmNewCategory : Form
    {
        private readonly PharmacyDbContext _db = new PharmacyDbContext();

        public frmNewCategory()
        {
            InitializeComponent();
        }

        private void frmNewCategory_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm mới danh mục nhóm thuốc";
            chkStatus.Checked = true;
            txtCategoryCode.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string code = txtCategoryCode.Text?.Trim() ?? "";
            string name = txtCategoryName.Text?.Trim() ?? "";
            string description = txtDescription.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Mã danh mục thuốc không được để trống!", "Yêu cầu nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên nhóm thuốc không được để trống!", "Yêu cầu nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            try
            {
                bool isDuplicate = _db.Categories.Any(c => c.CategoryCode.ToLower() == code.ToLower());
                if (isDuplicate)
                {
                    MessageBox.Show($"Mã danh mục [{code}] đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryCode.Focus();
                    return;
                }

                var category = new Category
                {
                    CategoryCode = code,
                    CategoryName = name,
                    Description = string.IsNullOrEmpty(description) ? null : description,
                    Status = chkStatus.Checked
                };

                _db.Categories.Add(category);
                _db.SaveChanges();

                MessageBox.Show("Thêm mới danh mục thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
