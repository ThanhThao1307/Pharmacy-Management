namespace Pharmacy_Nhom1
{
    partial class frmReportCenter
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTopTabs = new Panel();
            tlpTabs = new TableLayoutPanel();
            btTabInventory = new Button();
            btTabRevenue = new Button();
            btTabInvoice = new Button();
            pnlReportBody = new Panel();
            pnlTopTabs.SuspendLayout();
            tlpTabs.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopTabs
            // 
            pnlTopTabs.BackColor = Color.FromArgb(28, 48, 78);
            pnlTopTabs.Controls.Add(tlpTabs);
            pnlTopTabs.Dock = DockStyle.Top;
            pnlTopTabs.Location = new Point(0, 0);
            pnlTopTabs.Name = "pnlTopTabs";
            pnlTopTabs.Size = new Size(1258, 48);
            pnlTopTabs.TabIndex = 0;
            // 
            // tlpTabs
            // 
            tlpTabs.ColumnCount = 3;
            tlpTabs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpTabs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpTabs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpTabs.Controls.Add(btTabInventory, 0, 0);
            tlpTabs.Controls.Add(btTabRevenue, 1, 0);
            tlpTabs.Controls.Add(btTabInvoice, 2, 0);
            tlpTabs.Dock = DockStyle.Fill;
            tlpTabs.Location = new Point(0, 0);
            tlpTabs.Margin = new Padding(0);
            tlpTabs.Name = "tlpTabs";
            tlpTabs.RowCount = 1;
            tlpTabs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabs.Size = new Size(1258, 48);
            tlpTabs.TabIndex = 0;
            // 
            // btTabInventory
            // 
            btTabInventory.BackColor = Color.SteelBlue;
            btTabInventory.Dock = DockStyle.Fill;
            btTabInventory.FlatAppearance.BorderSize = 0;
            btTabInventory.FlatStyle = FlatStyle.Flat;
            btTabInventory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTabInventory.ForeColor = Color.White;
            btTabInventory.Location = new Point(0, 0);
            btTabInventory.Margin = new Padding(0);
            btTabInventory.Name = "btTabInventory";
            btTabInventory.Size = new Size(419, 48);
            btTabInventory.TabIndex = 0;
            btTabInventory.Text = "📦 BÁO CÁO TỒN KHO && GIÁ TRỊ";
            btTabInventory.UseVisualStyleBackColor = false;
            btTabInventory.Click += btTabInventory_Click;
            // 
            // btTabRevenue
            // 
            btTabRevenue.BackColor = Color.SteelBlue;
            btTabRevenue.Dock = DockStyle.Fill;
            btTabRevenue.FlatAppearance.BorderSize = 0;
            btTabRevenue.FlatStyle = FlatStyle.Flat;
            btTabRevenue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTabRevenue.ForeColor = Color.White;
            btTabRevenue.Location = new Point(419, 0);
            btTabRevenue.Margin = new Padding(0);
            btTabRevenue.Name = "btTabRevenue";
            btTabRevenue.Size = new Size(419, 48);
            btTabRevenue.TabIndex = 1;
            btTabRevenue.Text = "📈 BÁO CÁO DOANH THU & ĐỒ THỊ";
            btTabRevenue.UseVisualStyleBackColor = false;
            btTabRevenue.Click += btTabRevenue_Click;
            // 
            // btTabInvoice
            // 
            btTabInvoice.BackColor = Color.SteelBlue;
            btTabInvoice.Dock = DockStyle.Fill;
            btTabInvoice.FlatAppearance.BorderSize = 0;
            btTabInvoice.FlatStyle = FlatStyle.Flat;
            btTabInvoice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTabInvoice.ForeColor = Color.White;
            btTabInvoice.Location = new Point(838, 0);
            btTabInvoice.Margin = new Padding(0);
            btTabInvoice.Name = "btTabInvoice";
            btTabInvoice.Size = new Size(420, 48);
            btTabInvoice.TabIndex = 2;
            btTabInvoice.Text = "\U0001f9fe PHIẾU HÓA ĐƠN BÁN HÀNG";
            btTabInvoice.UseVisualStyleBackColor = false;
            btTabInvoice.Click += btTabInvoice_Click;
            // 
            // pnlReportBody
            // 
            pnlReportBody.BackColor = Color.White;
            pnlReportBody.Dock = DockStyle.Fill;
            pnlReportBody.Location = new Point(0, 48);
            pnlReportBody.Name = "pnlReportBody";
            pnlReportBody.Size = new Size(1258, 568);
            pnlReportBody.TabIndex = 1;
            // 
            // frmReportCenter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlReportBody);
            Controls.Add(pnlTopTabs);
            Name = "frmReportCenter";
            Text = "QUẢN LÝ BÁO CÁO & THỐNG KÊ NHÀ THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += frmReportCenter_Load;
            pnlTopTabs.ResumeLayout(false);
            tlpTabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTabs;
        private System.Windows.Forms.TableLayoutPanel tlpTabs;
        private System.Windows.Forms.Button btTabInventory;
        private System.Windows.Forms.Button btTabRevenue;
        private System.Windows.Forms.Button btTabInvoice;
        private System.Windows.Forms.Panel pnlReportBody;
    }
}
