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
            msMain = new System.Windows.Forms.MenuStrip();
            tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            tsmEmployee = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            tsmCatalog = new System.Windows.Forms.ToolStripMenuItem();
            tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            tsmProduct = new System.Windows.Forms.ToolStripMenuItem();
            tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            tsmSupplier = new System.Windows.Forms.ToolStripMenuItem();
            tsmBusiness = new System.Windows.Forms.ToolStripMenuItem();
            tsmOrder = new System.Windows.Forms.ToolStripMenuItem();
            tsmImport = new System.Windows.Forms.ToolStripMenuItem();
            tsmReport = new System.Windows.Forms.ToolStripMenuItem();
            tsmReportInventory = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsmAI = new System.Windows.Forms.ToolStripMenuItem();
            tsmLogoutTop = new System.Windows.Forms.ToolStripMenuItem();
            tsmExitTop = new System.Windows.Forms.ToolStripMenuItem();
            statusStripMain = new System.Windows.Forms.StatusStrip();
            lblWelcomeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            statusLblSystem = new System.Windows.Forms.ToolStripStatusLabel();
            pnlContent = new System.Windows.Forms.Panel();
            pnlTitleBar = new System.Windows.Forms.Panel();
            lblTitleBar = new System.Windows.Forms.Label();
            msMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.BackColor = System.Drawing.Color.FromArgb(24, 82, 56);
            msMain.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            msMain.ForeColor = System.Drawing.Color.White;
            msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmSystem, tsmCatalog, tsmBusiness, tsmReport, tsmLogoutTop, tsmExitTop });
            msMain.Location = new System.Drawing.Point(0, 0);
            msMain.Name = "msMain";
            msMain.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            msMain.Size = new System.Drawing.Size(1258, 42);
            msMain.TabIndex = 0;
            msMain.Text = "msMain";
            // 
            // tsmSystem
            // 
            tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmEmployee, toolStripSeparator1, tsmLogout, tsmExit });
            tsmSystem.ForeColor = System.Drawing.Color.White;
            tsmSystem.Name = "tsmSystem";
            tsmSystem.Size = new System.Drawing.Size(106, 30);
            tsmSystem.Text = "Hệ thống";
            // 
            // tsmEmployee
            // 
            tsmEmployee.Name = "tsmEmployee";
            tsmEmployee.Size = new System.Drawing.Size(260, 34);
            tsmEmployee.Text = "Quản lý nhân viên";
            tsmEmployee.Click += btEmployees_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // tsmLogout
            // 
            tsmLogout.Name = "tsmLogout";
            tsmLogout.Size = new System.Drawing.Size(260, 34);
            tsmLogout.Text = "Đăng xuất";
            tsmLogout.Click += btLogout_Click;
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new System.Drawing.Size(260, 34);
            tsmExit.Text = "Thoát chương trình";
            tsmExit.Click += btExit_Click;
            // 
            // tsmCatalog
            // 
            tsmCatalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmCategory, tsmProduct, tsmCustomer, tsmSupplier });
            tsmCatalog.ForeColor = System.Drawing.Color.White;
            tsmCatalog.Name = "tsmCatalog";
            tsmCatalog.Size = new System.Drawing.Size(113, 30);
            tsmCatalog.Text = "Danh mục";
            // 
            // tsmCategory
            // 
            tsmCategory.Name = "tsmCategory";
            tsmCategory.Size = new System.Drawing.Size(320, 34);
            tsmCategory.Text = "Quản lý danh mục thuốc";
            tsmCategory.Click += btCategories_Click;
            // 
            // tsmProduct
            // 
            tsmProduct.Name = "tsmProduct";
            tsmProduct.Size = new System.Drawing.Size(320, 34);
            tsmProduct.Text = "Quản lý thuốc & sản phẩm";
            tsmProduct.Click += btProducts_Click;
            // 
            // tsmCustomer
            // 
            tsmCustomer.Name = "tsmCustomer";
            tsmCustomer.Size = new System.Drawing.Size(320, 34);
            tsmCustomer.Text = "Quản lý khách hàng";
            tsmCustomer.Click += btCustomers_Click;
            // 
            // tsmSupplier
            // 
            tsmSupplier.Name = "tsmSupplier";
            tsmSupplier.Size = new System.Drawing.Size(320, 34);
            tsmSupplier.Text = "Quản lý nhà cung cấp";
            tsmSupplier.Click += btSuppliers_Click;
            // 
            // tsmBusiness
            // 
            tsmBusiness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmOrder, tsmImport });
            tsmBusiness.ForeColor = System.Drawing.Color.White;
            tsmBusiness.Name = "tsmBusiness";
            tsmBusiness.Size = new System.Drawing.Size(116, 30);
            tsmBusiness.Text = "Nghiệp vụ";
            // 
            // tsmOrder
            // 
            tsmOrder.Name = "tsmOrder";
            tsmOrder.Size = new System.Drawing.Size(350, 34);
            tsmOrder.Text = "Quản lý bán hàng & đơn hàng";
            tsmOrder.Click += btInvoices_Click;
            // 
            // tsmImport
            // 
            tsmImport.Name = "tsmImport";
            tsmImport.Size = new System.Drawing.Size(350, 34);
            tsmImport.Text = "Quản lý kho thuốc & nhập kho";
            tsmImport.Click += btImports_Click;
            // 
            // tsmReport
            // 
            tsmReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmReportInventory, toolStripSeparator2, tsmAI });
            tsmReport.ForeColor = System.Drawing.Color.White;
            tsmReport.Name = "tsmReport";
            tsmReport.Size = new System.Drawing.Size(140, 30);
            tsmReport.Text = "Báo cáo & AI";
            // 
            // tsmReportInventory
            // 
            tsmReportInventory.Name = "tsmReportInventory";
            tsmReportInventory.Size = new System.Drawing.Size(250, 34);
            tsmReportInventory.Text = "Báo cáo tồn kho";
            tsmReportInventory.Click += btBaoCao_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmAI
            // 
            tsmAI.Name = "tsmAI";
            tsmAI.Size = new System.Drawing.Size(250, 34);
            tsmAI.Text = "Trợ lý tư vấn AI";
            tsmAI.Click += btAI_Click;
            // 
            // tsmLogoutTop
            // 
            tsmLogoutTop.ForeColor = System.Drawing.Color.LightYellow;
            tsmLogoutTop.Name = "tsmLogoutTop";
            tsmLogoutTop.Size = new System.Drawing.Size(117, 30);
            tsmLogoutTop.Text = "Đăng xuất";
            tsmLogoutTop.Click += btLogout_Click;
            // 
            // tsmExitTop
            // 
            tsmExitTop.ForeColor = System.Drawing.Color.LightPink;
            tsmExitTop.Name = "tsmExitTop";
            tsmExitTop.Size = new System.Drawing.Size(80, 30);
            tsmExitTop.Text = "Thoát";
            tsmExitTop.Click += btExit_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = System.Drawing.Color.CadetBlue;
            statusStripMain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            statusStripMain.ForeColor = System.Drawing.Color.White;
            statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblWelcomeStatus, statusLblSystem });
            statusStripMain.Location = new System.Drawing.Point(0, 709);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new System.Drawing.Size(1258, 35);
            statusStripMain.TabIndex = 4;
            statusStripMain.Text = "statusStripMain";
            // 
            // lblWelcomeStatus
            // 
            lblWelcomeStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblWelcomeStatus.ForeColor = System.Drawing.Color.White;
            lblWelcomeStatus.Name = "lblWelcomeStatus";
            lblWelcomeStatus.Size = new System.Drawing.Size(274, 28);
            lblWelcomeStatus.Text = "Đang tải thông tin nhân viên...";
            // 
            // statusLblSystem
            // 
            statusLblSystem.Name = "statusLblSystem";
            statusLblSystem.Size = new System.Drawing.Size(969, 28);
            statusLblSystem.Spring = true;
            statusLblSystem.Text = "Hệ thống hoạt động bình thường";
            statusLblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
            pnlTitleBar.Controls.Add(lblTitleBar);
            pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitleBar.Location = new System.Drawing.Point(0, 42);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new System.Drawing.Size(1258, 50);
            pnlTitleBar.TabIndex = 2;
            // 
            // lblTitleBar
            // 
            lblTitleBar.AutoSize = true;
            lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitleBar.ForeColor = System.Drawing.Color.White;
            lblTitleBar.Location = new System.Drawing.Point(15, 6);
            lblTitleBar.Name = "lblTitleBar";
            lblTitleBar.Size = new System.Drawing.Size(464, 38);
            lblTitleBar.TabIndex = 0;
            lblTitleBar.Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.AliceBlue;
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 92);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1258, 617);
            pnlContent.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1258, 744);
            Controls.Add(pnlContent);
            Controls.Add(pnlTitleBar);
            Controls.Add(msMain);
            Controls.Add(statusStripMain);
            Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            MinimumSize = new System.Drawing.Size(1024, 720);
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem tsmEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmCatalog;
        private System.Windows.Forms.ToolStripMenuItem tsmCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmSupplier;
        private System.Windows.Forms.ToolStripMenuItem tsmBusiness;
        private System.Windows.Forms.ToolStripMenuItem tsmOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmImport;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
        private System.Windows.Forms.ToolStripMenuItem tsmReportInventory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmAI;
        private System.Windows.Forms.ToolStripMenuItem tsmLogoutTop;
        private System.Windows.Forms.ToolStripMenuItem tsmExitTop;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblWelcomeStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusLblSystem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitleBar;
    }
}
