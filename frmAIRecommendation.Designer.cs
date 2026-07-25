namespace Pharmacy_Nhom1
{
    partial class frmAIRecommendation
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            gbDuDoan = new GroupBox();
            txtResult = new TextBox();
            btPredict = new Button();
            cbProducts = new ComboBox();
            lblProd = new Label();
            pnlHeader.SuspendLayout();
            gbDuDoan.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1258, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(821, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "HỆ THỐNG AI DỰ ĐOÁN NHU CẦU && SUY ĐOÁN MÙA BỆNH";
            // 
            // gbDuDoan
            // 
            gbDuDoan.Controls.Add(txtResult);
            gbDuDoan.Controls.Add(btPredict);
            gbDuDoan.Controls.Add(cbProducts);
            gbDuDoan.Controls.Add(lblProd);
            gbDuDoan.Dock = DockStyle.Fill;
            gbDuDoan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDuDoan.Location = new Point(0, 60);
            gbDuDoan.Name = "gbDuDoan";
            gbDuDoan.Size = new Size(1258, 556);
            gbDuDoan.TabIndex = 2;
            gbDuDoan.TabStop = false;
            gbDuDoan.Text = "Phân tích dự đoán nhu cầu tiêu thụ, Suy đoán mùa bệnh && Kế hoạch chuẩn bị kho (GPP)";
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.BackColor = Color.White;
            txtResult.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.DarkSlateGray;
            txtResult.Location = new Point(24, 160);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(1207, 369);
            txtResult.TabIndex = 6;
            txtResult.Text = "Nhấn nút [Phân tích & Dự đoán Nhu cầu tiêu thụ / Mùa bệnh] để hệ thống phân tích dữ liệu bán ra, dự đoán số lượng cần chuẩn bị kho và suy đoán mùa bệnh...";
            // 
            // btPredict
            // 
            btPredict.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btPredict.BackColor = Color.DarkSlateGray;
            btPredict.Cursor = Cursors.Hand;
            btPredict.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPredict.ForeColor = Color.White;
            btPredict.Location = new Point(24, 95);
            btPredict.Name = "btPredict";
            btPredict.Size = new Size(1207, 48);
            btPredict.TabIndex = 4;
            btPredict.Text = "Phân tích && Dự đoán Nhu cầu tiêu thụ / Mùa bệnh";
            btPredict.UseVisualStyleBackColor = false;
            btPredict.Click += btPredict_Click;
            // 
            // cbProducts
            // 
            cbProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(323, 43);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(908, 36);
            cbProducts.TabIndex = 3;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProd.Location = new Point(24, 43);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(293, 32);
            lblProd.TabIndex = 2;
            lblProd.Text = "Sản phẩm thuốc lựa chọn:";
            // 
            // frmAIRecommendation
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(gbDuDoan);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "frmAIRecommendation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG AI DỰ ĐOÁN NHU CẦU & ĐỀ XUẤT THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += frmAIRecommendation_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            gbDuDoan.ResumeLayout(false);
            gbDuDoan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox gbDuDoan;
        private Label lblProd;
        private Button btPredict;
        private ComboBox cbProducts;
        private TextBox txtResult;
    }
}