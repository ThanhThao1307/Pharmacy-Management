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
            pnlHeader.Size = new Size(1100, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFromDate.ForeColor = Color.FloralWhite;
            lblFromDate.Location = new Point(20, 14);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(90, 28);
            lblFromDate.TabIndex = 1;
            lblFromDate.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(116, 9);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(140, 34);
            dtpFromDate.TabIndex = 2;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToDate.ForeColor = Color.FloralWhite;
            lblToDate.Location = new Point(274, 14);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(104, 28);
            lblToDate.TabIndex = 3;
            lblToDate.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(384, 9);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(140, 34);
            dtpToDate.TabIndex = 4;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FloralWhite;
            lblCategory.Location = new Point(543, 14);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(144, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "📂 Danh mục:";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(693, 11);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(207, 36);
            cbCategories.TabIndex = 6;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // btXemBaoCao
            // 
            btXemBaoCao.BackColor = Color.MidnightBlue;
            btXemBaoCao.FlatAppearance.BorderSize = 0;
            btXemBaoCao.FlatStyle = FlatStyle.Flat;
            btXemBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXemBaoCao.ForeColor = Color.White;
            btXemBaoCao.Location = new Point(915, 10);
            btXemBaoCao.Name = "btXemBaoCao";
            btXemBaoCao.Size = new Size(173, 36);
            btXemBaoCao.TabIndex = 7;
            btXemBaoCao.Text = "🔍 Lọc Dữ Liệu";
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
            pnlContent.Size = new Size(1100, 646);
            pnlContent.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1100, 646);
            reportViewer1.TabIndex = 0;
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmReportRevenue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
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
