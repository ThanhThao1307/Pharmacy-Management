namespace Pharmacy_Nhom1
{
    partial class frmReportRevenue
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
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
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
            pnlHeader.Controls.Add(lblFromDate);
            pnlHeader.Controls.Add(dtpFromDate);
            pnlHeader.Controls.Add(lblToDate);
            pnlHeader.Controls.Add(dtpToDate);
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
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFromDate.ForeColor = Color.White;
            lblFromDate.Location = new Point(29, 11);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(105, 32);
            lblFromDate.TabIndex = 1;
            lblFromDate.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(140, 9);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(140, 34);
            dtpFromDate.TabIndex = 2;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToDate.ForeColor = Color.White;
            lblToDate.Location = new Point(295, 11);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(122, 32);
            lblToDate.TabIndex = 3;
            lblToDate.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(423, 9);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(140, 34);
            dtpToDate.TabIndex = 4;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(578, 11);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(129, 32);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Danh mục:";
            // 
            // cbCategories
            // 
            cbCategories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(713, 11);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(365, 36);
            cbCategories.TabIndex = 6;
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
            btXemBaoCao.Location = new Point(1096, 10);
            btXemBaoCao.Name = "btXemBaoCao";
            btXemBaoCao.Size = new Size(150, 36);
            btXemBaoCao.TabIndex = 7;
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
            // frmReportRevenue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "frmReportRevenue";
            Text = "BÁO CÁO DOANH THU & PHÂN TÍCH ĐỒ THỊ";
            WindowState = FormWindowState.Maximized;
            Load += frmReportRevenue_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btXemBaoCao;
        private System.Windows.Forms.Panel pnlContent;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
