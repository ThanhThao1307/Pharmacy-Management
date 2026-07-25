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
                
                if (!Utility.IsAdmin)
                {
                    tsmUserManagement.Visible = false;
                }
            }
            else
            {
                lblWelcomeStatus.Text = "Chào mừng: Chưa đăng nhập";
            }
            if (lblTitleBar != null)
            {
                lblTitleBar.Text = "TRANG CHỦ HỆ THỐNG";
            }
        }

        private void btCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageCategory());
        }

        private void btImports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageImport());
        }

        private void btSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageSupplier());
        }

        private void btProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageProduct());
        }

        private void btInvoices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageOrder());
        }

        private void btPrescriptions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManagePrescription());
        }

        private void btCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageCustomer());
        }

        private void btUserManagement_Click(object sender, EventArgs e)
        {
            if (!Utility.IsAdmin)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenChildForm(new frmUserManagement());
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utility.Logout();
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        public void OpenChildForm(Form childForm)
        {
            // Ẩn panel trung gian
            if (pnlContent != null)
            {
                pnlContent.Visible = false;
            }

            // Đóng các form con đang mở
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == childForm.GetType())
                {
                    frm.Activate();
                    return;
                }
                frm.Close();
            }

            // Hiển thị form con MDI
            childForm.MdiParent = this;
            childForm.Show();

            if (lblTitleBar != null)
            {
                lblTitleBar.Text = childForm.Text.ToUpper();
            }
            this.Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC - " + childForm.Text.ToUpper();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportCenter());
        }

        private void btAI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAIRecommendation());
        }


    }
}