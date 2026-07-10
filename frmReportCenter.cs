using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy_Nhom1
{
    public partial class frmReportCenter : Form
    {
        private Form activeSubForm = null!;

        public frmReportCenter()
        {
            InitializeComponent();
        }

        private void frmReportCenter_Load(object sender, EventArgs e)
        {
            OpenReportSubForm(new frmReportInventory(), btTabInventory);
        }

        private void OpenReportSubForm(Form subForm, Button clickedButton)
        {
            try
            {
                if (activeSubForm != null)
                {
                    activeSubForm.Close();
                    activeSubForm.Dispose();
                    activeSubForm = null!;
                }

                foreach (Control ctrl in tlpTabs.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(40, 68, 108);
                        btn.ForeColor = Color.FromArgb(200, 215, 235);
                        btn.Font = new Font("Segoe UI Semibold", 10.5f, FontStyle.Bold);
                    }
                }

                clickedButton.BackColor = Color.FromArgb(16, 36, 64);
                clickedButton.ForeColor = Color.White;
                clickedButton.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);

                activeSubForm = subForm;
                subForm.TopLevel = false;
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Fill;

                pnlReportBody.Controls.Clear();
                pnlReportBody.Controls.Add(subForm);
                subForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTabInventory_Click(object sender, EventArgs e)
        {
            OpenReportSubForm(new frmReportInventory(), btTabInventory);
        }

        private void btTabRevenue_Click(object sender, EventArgs e)
        {
            OpenReportSubForm(new frmReportRevenue(), btTabRevenue);
        }

        private void btTabInvoice_Click(object sender, EventArgs e)
        {
            OpenReportSubForm(new frmReportInvoice(), btTabInvoice);
        }
    }
}
