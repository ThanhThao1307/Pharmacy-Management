using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            CenterLeftPanelContent();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            CenterLeftPanelContent();
        }

        private void CenterLeftPanelContent()
        {
            if (pnlLeft == null || lblLogo == null || lblName == null || lblTagline == null) return;

            int centerX = pnlLeft.Width / 2;
            int startY = pnlLeft.Height / 2 - 80;

            lblLogo.Left = centerX - lblLogo.Width / 2;
            lblLogo.Top = startY;

            lblName.Left = centerX - lblName.Width / 2;
            lblName.Top = startY + 90;

            lblTagline.Left = centerX - lblTagline.Width / 2;
            lblTagline.Top = startY + 138;
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            ResetSubTitle();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                ShowError("Vui lòng nhập tên đăng nhập!");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                ShowError("Vui lòng nhập mật khẩu!");
                txtPassword.Focus();
                return;
            }

            btLogin.Enabled = false;
            btLogin.Text = "Đang kiểm tra...";

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var user = await db.Users
                                       .Include(u => u.Role)
                                       .FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());

                    if (user == null || user.PasswordHash != password)
                    {
                        ShowError("Tên đăng nhập hoặc mật khẩu không chính xác!");
                        txtPassword.Clear();
                        txtPassword.Focus();
                        return;
                    }

                    if (!user.IsActive)
                    {
                        ShowError("Tài khoản này hiện đang bị khóa!");
                        return;
                    }

                    Utility.CurrentUser = user;

                    MessageBox.Show($"Chào mừng {Utility.CurrentUser.FullName} ({Utility.CurrentUser.Role?.RoleName}) quay trở lại làm việc!",
                                    "Đăng nhập thành công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    this.Hide();

                    using (frmMain mainForm = new frmMain())
                    {
                        mainForm.ShowDialog();
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi kết nối cơ sở dữ liệu hệ thống!");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                btLogin.Enabled = true;
                btLogin.Text = "ĐĂNG NHẬP";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
            txtPassword.Refresh();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btLogin_Click(sender, e);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) => ResetSubTitle();
        private void txtPassword_TextChanged(object sender, EventArgs e) => ResetSubTitle();

        private void ShowError(string msg)
        {
            lblSub.Text = "⚠ " + msg;
        }

        private void ResetSubTitle()
        {
            lblSub.Text = "Vui lòng nhập thông tin tài khoản";
        }
    }
}