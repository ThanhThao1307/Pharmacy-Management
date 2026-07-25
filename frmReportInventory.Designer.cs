namespace Pharmacy_Nhom1
{
    partial class frmReportInventory
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
            pnlHeader = new Panel();
            lblCategory = new Label();
            cbCategories = new ComboBox();
            btXemBaoCao = new Button();
            pnlContent = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblCategory);
            pnlHeader.Controls.Add(cbCategories);
            pnlHeader.Controls.Add(btXemBaoCao);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlHeader.ForeColor = Color.FromArgb(24, 43, 73);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1258, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.SteelBlue;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(29, 11);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(225, 32);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Lọc theo danh mục:";
            // 
            // cbCategories
            // 
            cbCategories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(260, 11);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(775, 36);
            cbCategories.TabIndex = 2;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // btXemBaoCao
            // 
            btXemBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btXemBaoCao.BackColor = Color.Navy;
            btXemBaoCao.FlatAppearance.BorderSize = 0;
            btXemBaoCao.FlatStyle = FlatStyle.Flat;
            btXemBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXemBaoCao.ForeColor = Color.FloralWhite;
            btXemBaoCao.Location = new Point(1058, 10);
            btXemBaoCao.Name = "btXemBaoCao";
            btXemBaoCao.Size = new Size(154, 36);
            btXemBaoCao.TabIndex = 3;
            btXemBaoCao.Text = "🔍 Tìm kiếm";
            btXemBaoCao.UseVisualStyleBackColor = false;
            btXemBaoCao.Click += btXemBaoCao_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(reportViewer1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 54);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 562);
            pnlContent.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1258, 562);
            reportViewer1.TabIndex = 0;
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmReportInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "frmReportInventory";
            Text = "BÁO CÁO TỒN KHO";
            WindowState = FormWindowState.Maximized;
            Load += frmReportInventory_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btXemBaoCao;
        private System.Windows.Forms.Panel pnlContent;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}