using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmUserManagement : Form
    {
        private long selectedUserId = 0;

        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadData();
        }

        private void LoadRoles()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    cboRoles.DataSource = db.Roles.ToList();
                    cboRoles.DisplayMember = "RoleName";
                    cboRoles.ValueMember = "RoleId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var users = db.Users
                        .Include(u => u.Role)
                        .Select(u => new
                        {
                            u.UserId,
                            u.Username,
                            u.FullName,
                            RoleName = u.Role.RoleName,
                            u.RoleId,
                            TrangThai = u.IsActive ? "Hoạt động" : "Khóa"
                        }).ToList();

                    dgvUsersList.DataSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboRoles.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleId = (int)cboRoles.SelectedValue;

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    if (selectedUserId == 0)
                    {
                        // Thêm mới
                        if (string.IsNullOrEmpty(password))
                        {
                            MessageBox.Show("Vui lòng nhập mật khẩu cho tài khoản mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bool exists = db.Users.Any(u => u.Username.ToLower() == username.ToLower());
                        if (exists)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var user = new User
                        {
                            Username = username,
                            PasswordHash = password,
                            FullName = fullName,
                            RoleId = roleId,
                            IsActive = true
                        };
                        db.Users.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Cập nhật
                        var user = db.Users.Find(selectedUserId);
                        if (user != null)
                        {
                            user.Username = username;
                            user.FullName = fullName;
                            user.RoleId = roleId;
                            if (!string.IsNullOrEmpty(password))
                            {
                                user.PasswordHash = password;
                            }
                            db.SaveChanges();
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Utility.CurrentUser != null && Utility.CurrentUser.UserId == selectedUserId)
            {
                MessageBox.Show("Bạn không thể tự xóa tài khoản của chính mình khi đang đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new PharmacyDbContext())
                    {
                        var user = db.Users.Find(selectedUserId);
                        if (user != null)
                        {
                            db.Users.Remove(user);
                            db.SaveChanges();
                            MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    ResetForm();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài khoản (có thể do tài khoản đã có dữ liệu hóa đơn/nhập hàng): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            selectedUserId = 0;
            txtUsername.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtUsername.Enabled = true;
            dgvUsersList.ClearSelection();
        }

        private void dgvUsersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsersList.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt64(row.Cells["UserId"].Value);
                txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtPassword.Clear(); // Không hiển thị mật khẩu

                if (row.Cells["RoleId"].Value != null)
                {
                    cboRoles.SelectedValue = Convert.ToInt32(row.Cells["RoleId"].Value);
                }
            }
        }
    }
}
