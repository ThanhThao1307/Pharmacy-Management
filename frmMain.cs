using System;
using System.Windows.Forms;

namespace Pharmacy_Nhom1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Utility.CurrentUser != null)
            {
                lblWelcomeStatus.Text = $"Chào mừng: {Utility.CurrentUser.FullName} | Quyền: {Utility.CurrentUser.Role?.RoleName}";
                if (tsmEmployee != null) tsmEmployee.Visible = Utility.IsAdmin;
            }
            else
            {
                lblWelcomeStatus.Text = "Chào mừng: Chưa đăng nhập";
                if (tsmEmployee != null) tsmEmployee.Visible = false;
            }
            if (lblTitleBar != null)
            {
                lblTitleBar.Text = "TRANG CHỦ HỆ THỐNG";
            }
        }

        private void btCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategory());
        }

        private void btImports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmImport());
        }

        private void btSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSupplier());
        }

        private void btEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUserManagement());
        }

        private void btProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProduct());
        }

        private void btInvoices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProcessOrderDetails());
        }

        private void btCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomer());
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utility.Logout();
                this.Hide();
                Application.Exit();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void OpenChildForm(Form childForm)
        {
            if (pnlContent == null) return;

            pnlContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.Show();

            if (lblTitleBar != null)
            {
                lblTitleBar.Text = childForm.Text.ToUpper();
            }
            this.Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC - " + childForm.Text.ToUpper();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportInventory());
        }

        private void btAI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAIRecommendation());
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}