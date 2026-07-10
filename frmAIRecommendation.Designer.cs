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
            gbHuanLuyen = new GroupBox();
            txtEvaluate = new TextBox();
            btTrain = new Button();
            gbDuDoan = new GroupBox();
            lblResult = new Label();
            btPredict = new Button();
            cbProducts = new ComboBox();
            lblProd = new Label();
            cbCustomers = new ComboBox();
            lblCust = new Label();
            pnlHeader.SuspendLayout();
            gbHuanLuyen.SuspendLayout();
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
            pnlHeader.Size = new Size(1431, 67);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(559, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "HỆ THỐNG AI GỢI Ý THUỐC CHO KHÁCH HÀNG";
            // 
            // gbHuanLuyen
            // 
            gbHuanLuyen.Controls.Add(txtEvaluate);
            gbHuanLuyen.Controls.Add(btTrain);
            gbHuanLuyen.Dock = DockStyle.Left;
            gbHuanLuyen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbHuanLuyen.Location = new Point(0, 67);
            gbHuanLuyen.Name = "gbHuanLuyen";
            gbHuanLuyen.Size = new Size(470, 707);
            gbHuanLuyen.TabIndex = 1;
            gbHuanLuyen.TabStop = false;
            gbHuanLuyen.Text = "1. Huấn luyện Mô hình AI từ CSDL";
            // 
            // txtEvaluate
            // 
            txtEvaluate.Location = new Point(24, 129);
            txtEvaluate.Multiline = true;
            txtEvaluate.Name = "txtEvaluate";
            txtEvaluate.ReadOnly = true;
            txtEvaluate.ScrollBars = ScrollBars.Vertical;
            txtEvaluate.Size = new Size(420, 566);
            txtEvaluate.TabIndex = 1;
            // 
            // btTrain
            // 
            btTrain.BackColor = Color.Teal;
            btTrain.Cursor = Cursors.Hand;
            btTrain.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTrain.ForeColor = Color.MistyRose;
            btTrain.Location = new Point(24, 53);
            btTrain.Name = "btTrain";
            btTrain.Size = new Size(420, 55);
            btTrain.TabIndex = 0;
            btTrain.Text = "🚀 Huấn luyện & Xây dựng Mô hình";
            btTrain.UseVisualStyleBackColor = false;
            btTrain.Click += btTrain_Click;
            // 
            // gbDuDoan
            // 
            gbDuDoan.Controls.Add(lblResult);
            gbDuDoan.Controls.Add(btPredict);
            gbDuDoan.Controls.Add(cbProducts);
            gbDuDoan.Controls.Add(lblProd);
            gbDuDoan.Controls.Add(cbCustomers);
            gbDuDoan.Controls.Add(lblCust);
            gbDuDoan.Dock = DockStyle.Fill;
            gbDuDoan.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDuDoan.Location = new Point(470, 67);
            gbDuDoan.Name = "gbDuDoan";
            gbDuDoan.Size = new Size(961, 707);
            gbDuDoan.TabIndex = 2;
            gbDuDoan.TabStop = false;
            gbDuDoan.Text = "2. Phân tích xu hướng & Tư vấn mua thuốc";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Crimson;
            lblResult.Location = new Point(20, 218);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(880, 396);
            lblResult.TabIndex = 5;
            lblResult.Text = " 💡 Kết quả dự đoán và lời khuyên tư vấn của AI sẽ hiển thị tại đây...";
            // 
            // btPredict
            // 
            btPredict.BackColor = Color.DarkSlateGray;
            btPredict.Cursor = Cursors.Hand;
            btPredict.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPredict.ForeColor = Color.White;
            btPredict.Location = new Point(20, 152);
            btPredict.Name = "btPredict";
            btPredict.Size = new Size(880, 50);
            btPredict.TabIndex = 4;
            btPredict.Text = "🔍 Phân tích & Dự đoán xu hướng mua";
            btPredict.UseVisualStyleBackColor = false;
            btPredict.Click += btPredict_Click;
            // 
            // cbProducts
            // 
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(321, 96);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(579, 38);
            cbProducts.TabIndex = 3;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProd.Location = new Point(20, 100);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(295, 28);
            lblProd.TabIndex = 2;
            lblProd.Text = "Chọn sản phẩm Thuốc phân tích:";
            // 
            // cbCustomers
            // 
            cbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(321, 43);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(579, 38);
            cbCustomers.TabIndex = 1;
            // 
            // lblCust
            // 
            lblCust.AutoSize = true;
            lblCust.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCust.Location = new Point(20, 43);
            lblCust.Name = "lblCust";
            lblCust.Size = new Size(264, 28);
            lblCust.TabIndex = 0;
            lblCust.Text = "Chọn Khách hàng cần tư vấn:";
            // 
            // frmAIRecommendation
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1431, 774);
            Controls.Add(gbDuDoan);
            Controls.Add(gbHuanLuyen);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmAIRecommendation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG AI GỢI Ý & ĐỀ XUẤT THUỐC";
            Load += frmAIRecommendation_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            gbHuanLuyen.ResumeLayout(false);
            gbHuanLuyen.PerformLayout();
            gbDuDoan.ResumeLayout(false);
            gbDuDoan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox gbHuanLuyen;
        private Button btTrain;
        private GroupBox gbDuDoan;
        private Label lblProd;
        private ComboBox cbCustomers;
        private Label lblCust;
        private Button btPredict;
        private ComboBox cbProducts;
        private Label lblResult;
        private TextBox txtEvaluate;
    }
}