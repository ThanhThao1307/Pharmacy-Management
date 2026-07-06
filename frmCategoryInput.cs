using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmCategoryInput : Form
    {
        private readonly PharmacyDbContext _db = new PharmacyDbContext();
        private readonly Category? _category;
        private readonly bool _isEditMode = false;

        public frmCategoryInput()
        {
            InitializeComponent();
            _category = new Category();
            _isEditMode = false;
        }

        public frmCategoryInput(int categoryId)
        {
            InitializeComponent();
            _category = _db.Categories.Find(categoryId);
            _isEditMode = true;
        }

        private void frmCategoryInput_Load(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                this.Text = "Cập nhật danh mục nhóm thuốc";
                lblFormTitle.Text = "CẬP NHẬT DANH MỤC THUỐC";

                if (_category != null)
                {
                    txtCategoryCode.Text = _category.CategoryCode;
                    txtCategoryCode.Enabled = false;
                    txtCategoryCode.BackColor = Color.FromArgb(240, 240, 240);

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
            else
            {
                this.Text = "Thêm mới danh mục nhóm thuốc";
                lblFormTitle.Text = "THÊM DANH MỤC THUỐC MỚI";
                chkStatus.Checked = true;
                txtCategoryCode.Focus();
            }
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

            if (_category == null)
            {
                MessageBox.Show("Đối tượng dữ liệu không hợp lệ hoặc đã bị xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _category.CategoryName = name;
                _category.Description = string.IsNullOrEmpty(description) ? null : description;
                _category.Status = chkStatus.Checked;

                if (!_isEditMode)
                {
                    _category.CategoryCode = code;

                    bool isDuplicate = _db.Categories.Any(c => c.CategoryCode.ToLower() == code.ToLower());
                    if (isDuplicate)
                    {
                        MessageBox.Show($"Mã danh mục [{code}] đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategoryCode.Focus();
                        return;
                    }

                    _db.Categories.Add(_category);
                }

                _db.SaveChanges(); 

                MessageBox.Show(_isEditMode ? "Cập nhật dữ liệu thành công!" : "Thêm mới danh mục thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống khi lưu: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
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