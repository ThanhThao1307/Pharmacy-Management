namespace Pharmacy_Nhom1
{
    partial class frmReportInvoice
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
            lblOrder = new Label();
            cbOrders = new ComboBox();
            btXemIn = new Button();
            pnlContent = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblOrder);
            pnlHeader.Controls.Add(cbOrders);
            pnlHeader.Controls.Add(btXemIn);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlHeader.ForeColor = Color.FromArgb(24, 43, 73);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1258, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrder.ForeColor = Color.White;
            lblOrder.Location = new Point(29, 11);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(309, 32);
            lblOrder.TabIndex = 1;
            lblOrder.Text = "Chọn Hóa Đơn In / Tra Cứu:";
            // 
            // cbOrders
            // 
            cbOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbOrders.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrders.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOrders.FormattingEnabled = true;
            cbOrders.Location = new Point(344, 11);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(691, 36);
            cbOrders.TabIndex = 2;
            cbOrders.SelectedIndexChanged += cbOrders_SelectedIndexChanged;
            // 
            // btXemIn
            // 
            btXemIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btXemIn.BackColor = Color.Navy;
            btXemIn.FlatAppearance.BorderSize = 0;
            btXemIn.FlatStyle = FlatStyle.Flat;
            btXemIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXemIn.ForeColor = Color.FloralWhite;
            btXemIn.Location = new Point(1056, 10);
            btXemIn.Name = "btXemIn";
            btXemIn.Size = new Size(159, 36);
            btXemIn.TabIndex = 3;
            btXemIn.Text = "🔍 Tìm kiếm";
            btXemIn.UseVisualStyleBackColor = false;
            btXemIn.Click += btXemIn_Click;
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
            // frmReportInvoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "frmReportInvoice";
            Text = "PHIẾU HÓA ĐƠN BÁN HÀNG - IN ẤN";
            WindowState = FormWindowState.Maximized;
            Load += frmReportInvoice_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox cbOrders;
        private System.Windows.Forms.Button btXemIn;
        private System.Windows.Forms.Panel pnlContent;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
