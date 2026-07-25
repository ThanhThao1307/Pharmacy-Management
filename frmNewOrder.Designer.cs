namespace Pharmacy_Nhom1
{
    partial class frmNewOrder
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
            pnlTitle = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            gbInfo = new GroupBox();
            txtNetAmount = new TextBox();
            lblNetAmount = new Label();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            cbStatus = new ComboBox();
            lblStatus = new Label();
            nudDiscount = new NumericUpDown();
            lblDiscount = new Label();
            btPrescriptionDetail = new Button();
            txtPrescriptionInfo = new TextBox();
            lblPrescription = new Label();
            cbUser = new ComboBox();
            lblUser = new Label();
            cbCustomer = new ComboBox();
            lblCustomer = new Label();
            dtpOrderDate = new DateTimePicker();
            lblOrderDate = new Label();
            txtOrderCode = new TextBox();
            lblOrderCode = new Label();
            pnlButtons = new Panel();
            btClose = new Button();
            btSave = new Button();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1258, 60);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LẬP HÓA ĐƠN BÁN HÀNG MỚI";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.LightBlue;
            pnlMain.Controls.Add(gbInfo);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1258, 506);
            pnlMain.TabIndex = 1;
            // 
            // gbInfo
            // 
            gbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbInfo.Controls.Add(txtNetAmount);
            gbInfo.Controls.Add(lblNetAmount);
            gbInfo.Controls.Add(txtTotalAmount);
            gbInfo.Controls.Add(lblTotalAmount);
            gbInfo.Controls.Add(cbStatus);
            gbInfo.Controls.Add(lblStatus);
            gbInfo.Controls.Add(nudDiscount);
            gbInfo.Controls.Add(lblDiscount);
            gbInfo.Controls.Add(btPrescriptionDetail);
            gbInfo.Controls.Add(txtPrescriptionInfo);
            gbInfo.Controls.Add(lblPrescription);
            gbInfo.Controls.Add(cbUser);
            gbInfo.Controls.Add(lblUser);
            gbInfo.Controls.Add(cbCustomer);
            gbInfo.Controls.Add(lblCustomer);
            gbInfo.Controls.Add(dtpOrderDate);
            gbInfo.Controls.Add(lblOrderDate);
            gbInfo.Controls.Add(txtOrderCode);
            gbInfo.Controls.Add(lblOrderCode);
            gbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbInfo.Location = new Point(20, 20);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(1226, 465);
            gbInfo.TabIndex = 0;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin chung hóa đơn";
            // 
            // txtNetAmount
            // 
            txtNetAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNetAmount.BackColor = SystemColors.Window;
            txtNetAmount.BorderStyle = BorderStyle.FixedSingle;
            txtNetAmount.Font = new Font("Segoe UI", 10F);
            txtNetAmount.ForeColor = Color.DarkRed;
            txtNetAmount.Location = new Point(199, 284);
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.ReadOnly = true;
            txtNetAmount.Size = new Size(431, 34);
            txtNetAmount.TabIndex = 18;
            txtNetAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNetAmount
            // 
            lblNetAmount.AutoSize = true;
            lblNetAmount.Location = new Point(6, 289);
            lblNetAmount.Name = "lblNetAmount";
            lblNetAmount.Size = new Size(175, 32);
            lblNetAmount.TabIndex = 17;
            lblNetAmount.Text = "Thành tiền HĐ:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalAmount.BackColor = SystemColors.Window;
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI", 10F);
            txtTotalAmount.Location = new Point(199, 210);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(431, 34);
            txtTotalAmount.TabIndex = 16;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(6, 212);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(168, 32);
            lblTotalAmount.TabIndex = 15;
            lblTotalAmount.Text = "Tổng tiền gốc:";
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbStatus.BackColor = SystemColors.Window;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 10F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "0 - Đã thanh toán", "1 - Hủy" });
            cbStatus.Location = new Point(842, 286);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(369, 36);
            cbStatus.TabIndex = 14;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(649, 289);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(125, 32);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Trạng thái:";
            // 
            // nudDiscount
            // 
            nudDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudDiscount.BackColor = SystemColors.Window;
            nudDiscount.Font = new Font("Segoe UI", 10F);
            nudDiscount.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDiscount.Location = new Point(842, 210);
            nudDiscount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(369, 34);
            nudDiscount.TabIndex = 12;
            nudDiscount.TextAlign = HorizontalAlignment.Right;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(649, 212);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(184, 32);
            lblDiscount.TabIndex = 11;
            lblDiscount.Text = "Giảm giá (VNĐ):";
            // 
            // btPrescriptionDetail
            // 
            btPrescriptionDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btPrescriptionDetail.BackColor = Color.Tomato;
            btPrescriptionDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPrescriptionDetail.ForeColor = Color.FloralWhite;
            btPrescriptionDetail.Location = new Point(649, 359);
            btPrescriptionDetail.Name = "btPrescriptionDetail";
            btPrescriptionDetail.Size = new Size(168, 39);
            btPrescriptionDetail.TabIndex = 8;
            btPrescriptionDetail.Text = "➕ THÊM TOA";
            btPrescriptionDetail.UseVisualStyleBackColor = false;
            btPrescriptionDetail.Click += btPrescriptionDetail_Click;
            // 
            // txtPrescriptionInfo
            // 
            txtPrescriptionInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrescriptionInfo.BackColor = SystemColors.Window;
            txtPrescriptionInfo.BorderStyle = BorderStyle.FixedSingle;
            txtPrescriptionInfo.Font = new Font("Segoe UI", 10F);
            txtPrescriptionInfo.Location = new Point(199, 359);
            txtPrescriptionInfo.Name = "txtPrescriptionInfo";
            txtPrescriptionInfo.ReadOnly = true;
            txtPrescriptionInfo.Size = new Size(431, 34);
            txtPrescriptionInfo.TabIndex = 7;
            // 
            // lblPrescription
            // 
            lblPrescription.AutoSize = true;
            lblPrescription.Location = new Point(6, 361);
            lblPrescription.Name = "lblPrescription";
            lblPrescription.Size = new Size(187, 32);
            lblPrescription.TabIndex = 6;
            lblPrescription.Text = "Toa thuốc (GPP):";
            // 
            // cbUser
            // 
            cbUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbUser.BackColor = SystemColors.Window;
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.Font = new Font("Segoe UI", 10F);
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(842, 131);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(369, 36);
            cbUser.TabIndex = 10;
            cbUser.Enabled = false;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(649, 134);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(168, 32);
            lblUser.TabIndex = 9;
            lblUser.Text = "Nhân viên lập:";
            // 
            // cbCustomer
            // 
            cbCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCustomer.BackColor = SystemColors.Window;
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.Font = new Font("Segoe UI", 10F);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(199, 131);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(431, 36);
            cbCustomer.TabIndex = 5;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(6, 134);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(145, 32);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Khách hàng:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpOrderDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpOrderDate.Font = new Font("Segoe UI", 10F);
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(842, 49);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(369, 34);
            dtpOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            lblOrderDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(649, 54);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(114, 32);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "Ngày lập:";
            // 
            // txtOrderCode
            // 
            txtOrderCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderCode.BackColor = SystemColors.Window;
            txtOrderCode.BorderStyle = BorderStyle.FixedSingle;
            txtOrderCode.Font = new Font("Segoe UI", 10F);
            txtOrderCode.Location = new Point(199, 50);
            txtOrderCode.Name = "txtOrderCode";
            txtOrderCode.Size = new Size(431, 34);
            txtOrderCode.TabIndex = 1;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Location = new Point(6, 54);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(149, 32);
            lblOrderCode.TabIndex = 0;
            lblOrderCode.Text = "Mã hóa đơn:";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btClose);
            pnlButtons.Controls.Add(btSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 566);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1258, 50);
            pnlButtons.TabIndex = 2;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.BackColor = Color.Silver;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = SystemColors.ControlText;
            btClose.Location = new Point(1126, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(105, 34);
            btClose.TabIndex = 1;
            btClose.Text = "❌ HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSave.BackColor = Color.MidnightBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.FloralWhite;
            btSave.Location = new Point(1005, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(105, 34);
            btSave.TabIndex = 0;
            btSave.Text = "💾 LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // frmNewOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlMain);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "frmNewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập hóa đơn mới";
            WindowState = FormWindowState.Maximized;
            Load += frmNewOrder_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.TextBox txtPrescriptionInfo;
        private System.Windows.Forms.Button btPrescriptionDetail;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
    }
}
