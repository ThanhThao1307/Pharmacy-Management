namespace Pharmacy_Nhom1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMain = new MenuStrip();
            tsmSystem = new ToolStripMenuItem();
            tsmLogout = new ToolStripMenuItem();
            tsmExit = new ToolStripMenuItem();
            tsmCatalog = new ToolStripMenuItem();
            tsmCategory = new ToolStripMenuItem();
            tsmUserManagement = new ToolStripMenuItem();
            tsmProduct = new ToolStripMenuItem();
            tsmCustomer = new ToolStripMenuItem();
            tsmSupplier = new ToolStripMenuItem();
            tsmBusiness = new ToolStripMenuItem();
            tsmOrder = new ToolStripMenuItem();
            tsmImport = new ToolStripMenuItem();
            tsmPrescription = new ToolStripMenuItem();
            tsmReport = new ToolStripMenuItem();
            tsmReportInventory = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmAI = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            lblWelcomeStatus = new ToolStripStatusLabel();
            statusLblSystem = new ToolStripStatusLabel();
            pnlContent = new Panel();
            pnlTitleBar = new Panel();
            lblTitleBar = new Label();
            msMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.BackColor = Color.FromArgb(24, 82, 56);
            msMain.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msMain.ForeColor = Color.White;
            msMain.ImageScalingSize = new Size(24, 24);
            msMain.Items.AddRange(new ToolStripItem[] { tsmSystem, tsmCatalog, tsmBusiness, tsmReport });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Padding = new Padding(8, 6, 8, 6);
            msMain.Size = new Size(1258, 46);
            msMain.TabIndex = 0;
            msMain.Text = "msMain";
            // 
            // tsmSystem
            // 
            tsmSystem.DropDownItems.AddRange(new ToolStripItem[] { tsmLogout, tsmExit });
            tsmSystem.ForeColor = Color.White;
            tsmSystem.Name = "tsmSystem";
            tsmSystem.Size = new Size(122, 34);
            tsmSystem.Text = "Hệ thống";
            // 
            // tsmLogout
            // 
            tsmLogout.Name = "tsmLogout";
            tsmLogout.Size = new Size(309, 38);
            tsmLogout.Text = "Đăng xuất";
            tsmLogout.Click += btLogout_Click;
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new Size(309, 38);
            tsmExit.Text = "Thoát chương trình";
            tsmExit.Click += btExit_Click;
            // 
            // tsmCatalog
            // 
            tsmCatalog.DropDownItems.AddRange(new ToolStripItem[] { tsmCategory, tsmProduct, tsmCustomer, tsmSupplier, tsmUserManagement });
            tsmCatalog.ForeColor = Color.White;
            tsmCatalog.Name = "tsmCatalog";
            tsmCatalog.Size = new Size(129, 34);
            tsmCatalog.Text = "Danh mục";
            // 
            // tsmCategory
            // 
            tsmCategory.Name = "tsmCategory";
            tsmCategory.Size = new Size(380, 38);
            tsmCategory.Text = "Quản lý danh mục thuốc";
            tsmCategory.Click += btCategories_Click;
            // 
            // tsmProduct
            // 
            tsmProduct.Name = "tsmProduct";
            tsmProduct.Size = new Size(380, 38);
            tsmProduct.Text = "Quản lý thuốc && sản phẩm";
            tsmProduct.Click += btProducts_Click;
            // 
            // tsmCustomer
            // 
            tsmCustomer.Name = "tsmCustomer";
            tsmCustomer.Size = new Size(380, 38);
            tsmCustomer.Text = "Quản lý khách hàng";
            tsmCustomer.Click += btCustomers_Click;
            // 
            // tsmSupplier
            // 
            tsmSupplier.Name = "tsmSupplier";
            tsmSupplier.Size = new Size(380, 38);
            tsmSupplier.Text = "Quản lý nhà cung cấp";
            tsmSupplier.Click += btSuppliers_Click;
            // 
            // tsmUserManagement
            // 
            tsmUserManagement.Name = "tsmUserManagement";
            tsmUserManagement.Size = new Size(380, 38);
            tsmUserManagement.Text = "Quản lý tài khoản dược sĩ";
            tsmUserManagement.Click += btUserManagement_Click;
            // 
            // tsmBusiness
            // 
            tsmBusiness.DropDownItems.AddRange(new ToolStripItem[] { tsmOrder, tsmImport, tsmPrescription });
            tsmBusiness.ForeColor = Color.White;
            tsmBusiness.Name = "tsmBusiness";
            tsmBusiness.Size = new Size(132, 34);
            tsmBusiness.Text = "Nghiệp vụ";
            // 
            // tsmOrder
            // 
            tsmOrder.Name = "tsmOrder";
            tsmOrder.Size = new Size(423, 38);
            tsmOrder.Text = "Quản lý bán hàng && đơn hàng";
            tsmOrder.Click += btInvoices_Click;
            // 
            // tsmImport
            // 
            tsmImport.Name = "tsmImport";
            tsmImport.Size = new Size(423, 38);
            tsmImport.Text = "Quản lý kho thuốc && nhập kho";
            tsmImport.Click += btImports_Click;
            // 
            // tsmPrescription
            // 
            tsmPrescription.Name = "tsmPrescription";
            tsmPrescription.Size = new Size(423, 38);
            tsmPrescription.Text = "Quản lý toa thuốc GPP";
            tsmPrescription.Click += btPrescriptions_Click;
            // 
            // tsmReport
            // 
            tsmReport.DropDownItems.AddRange(new ToolStripItem[] { tsmReportInventory, toolStripSeparator2, tsmAI });
            tsmReport.ForeColor = Color.White;
            tsmReport.Name = "tsmReport";
            tsmReport.Size = new Size(140, 34);
            tsmReport.Text = "Báo cáo & AI";
            // 
            // tsmReportInventory
            // 
            tsmReportInventory.Name = "tsmReportInventory";
            tsmReportInventory.Size = new Size(277, 38);
            tsmReportInventory.Text = "Trung tâm báo cáo";
            tsmReportInventory.Click += btBaoCao_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(274, 6);
            // 
            // tsmAI
            // 
            tsmAI.Name = "tsmAI";
            tsmAI.Size = new Size(277, 38);
            tsmAI.Text = "Trợ lý tư vấn AI";
            tsmAI.Click += btAI_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = Color.CadetBlue;
            statusStripMain.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStripMain.ForeColor = Color.White;
            statusStripMain.ImageScalingSize = new Size(24, 24);
            statusStripMain.Items.AddRange(new ToolStripItem[] { lblWelcomeStatus, statusLblSystem });
            statusStripMain.Location = new Point(0, 709);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1258, 35);
            statusStripMain.TabIndex = 4;
            statusStripMain.Text = "statusStripMain";
            // 
            // lblWelcomeStatus
            // 
            lblWelcomeStatus.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcomeStatus.ForeColor = Color.White;
            lblWelcomeStatus.Name = "lblWelcomeStatus";
            lblWelcomeStatus.Size = new Size(274, 28);
            lblWelcomeStatus.Text = "Đang tải thông tin nhân viên...";
            // 
            // statusLblSystem
            // 
            statusLblSystem.Name = "statusLblSystem";
            statusLblSystem.Size = new Size(969, 28);
            statusLblSystem.Spring = true;
            statusLblSystem.Text = "Hệ thống hoạt động bình thường";
            statusLblSystem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.AliceBlue;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 96);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 613);
            pnlContent.TabIndex = 3;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.MidnightBlue;
            pnlTitleBar.Controls.Add(lblTitleBar);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 46);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1258, 50);
            pnlTitleBar.TabIndex = 2;
            // 
            // lblTitleBar
            // 
            lblTitleBar.AutoSize = true;
            lblTitleBar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleBar.ForeColor = Color.White;
            lblTitleBar.Location = new Point(15, 6);
            lblTitleBar.Name = "lblTitleBar";
            lblTitleBar.Size = new Size(464, 38);
            lblTitleBar.TabIndex = 0;
            lblTitleBar.Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1258, 744);
            Controls.Add(pnlContent);
            Controls.Add(pnlTitleBar);
            Controls.Add(msMain);
            Controls.Add(statusStripMain);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            MinimumSize = new Size(1024, 720);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmCatalog;
        private System.Windows.Forms.ToolStripMenuItem tsmCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmSupplier;
        private System.Windows.Forms.ToolStripMenuItem tsmUserManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmBusiness;
        private System.Windows.Forms.ToolStripMenuItem tsmOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmImport;
        private System.Windows.Forms.ToolStripMenuItem tsmPrescription;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
        private System.Windows.Forms.ToolStripMenuItem tsmReportInventory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmAI;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblWelcomeStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusLblSystem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitleBar;
    }
}
