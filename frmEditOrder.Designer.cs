namespace Pharmacy_Nhom1
{
    partial class frmEditOrder
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
            cbStatus = new ComboBox();
            lblStatus = new Label();
            nudDiscount = new NumericUpDown();
            lblDiscount = new Label();
            cbPrescription = new ComboBox();
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
            pnlTitle.Size = new Size(800, 60);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CẬP NHẬT THÔNG TIN HÓA ĐƠN";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.LightBlue;
            pnlMain.Controls.Add(gbInfo);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 380);
            pnlMain.TabIndex = 1;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(cbStatus);
            gbInfo.Controls.Add(lblStatus);
            gbInfo.Controls.Add(nudDiscount);
            gbInfo.Controls.Add(lblDiscount);
            gbInfo.Controls.Add(cbPrescription);
            gbInfo.Controls.Add(lblPrescription);
            gbInfo.Controls.Add(cbUser);
            gbInfo.Controls.Add(lblUser);
            gbInfo.Controls.Add(cbCustomer);
            gbInfo.Controls.Add(lblCustomer);
            gbInfo.Controls.Add(dtpOrderDate);
            gbInfo.Controls.Add(lblOrderDate);
            gbInfo.Controls.Add(txtOrderCode);
            gbInfo.Controls.Add(lblOrderCode);
            gbInfo.Location = new Point(20, 20);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(760, 330);
            gbInfo.TabIndex = 0;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin chung hóa đơn";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "0 - Đã thanh toán", "1 - Hủy" });
            cbStatus.Location = new Point(540, 256);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 36);
            cbStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(420, 260);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(102, 28);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Trạng thái:";
            // 
            // nudDiscount
            // 
            nudDiscount.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDiscount.Location = new Point(180, 256);
            nudDiscount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(200, 34);
            nudDiscount.TabIndex = 11;
            nudDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(20, 260);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(152, 28);
            lblDiscount.TabIndex = 10;
            lblDiscount.Text = "Giảm giá (VNĐ):";
            // 
            // cbPrescription
            // 
            cbPrescription.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrescription.FormattingEnabled = true;
            cbPrescription.Location = new Point(180, 201);
            cbPrescription.Name = "cbPrescription";
            cbPrescription.Size = new Size(560, 36);
            cbPrescription.TabIndex = 9;
            // 
            // lblPrescription
            // 
            lblPrescription.AutoSize = true;
            lblPrescription.Location = new Point(20, 205);
            lblPrescription.Name = "lblPrescription";
            lblPrescription.Size = new Size(154, 28);
            lblPrescription.TabIndex = 8;
            lblPrescription.Text = "Toa thuốc (GPP):";
            // 
            // cbUser
            // 
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(180, 146);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(560, 36);
            cbUser.TabIndex = 7;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(20, 150);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(136, 28);
            lblUser.TabIndex = 6;
            lblUser.Text = "Nhân viên lập:";
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(180, 91);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(560, 36);
            cbCustomer.TabIndex = 5;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(20, 95);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(118, 28);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Khách hàng:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(540, 36);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 34);
            dtpOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(420, 40);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(95, 28);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "Ngày lập:";
            // 
            // txtOrderCode
            // 
            txtOrderCode.BackColor = Color.WhiteSmoke;
            txtOrderCode.BorderStyle = BorderStyle.FixedSingle;
            txtOrderCode.Location = new Point(180, 36);
            txtOrderCode.Name = "txtOrderCode";
            txtOrderCode.ReadOnly = true;
            txtOrderCode.Size = new Size(200, 34);
            txtOrderCode.TabIndex = 1;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Location = new Point(20, 40);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(122, 28);
            lblOrderCode.TabIndex = 0;
            lblOrderCode.Text = "Mã hóa đơn:";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btClose);
            pnlButtons.Controls.Add(btSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 440);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(800, 60);
            pnlButtons.TabIndex = 2;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = Color.Black;
            btClose.Location = new Point(640, 10);
            btClose.Name = "btClose";
            btClose.Size = new Size(140, 40);
            btClose.TabIndex = 1;
            btClose.Text = "❌ ĐÓNG";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.MidnightBlue;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(460, 10);
            btSave.Name = "btSave";
            btSave.Size = new Size(160, 40);
            btSave.TabIndex = 0;
            btSave.Text = "💾 CẬP NHẬT";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // frmEditOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pnlMain);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật hóa đơn";
            Load += frmEditOrder_Load;
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
        private System.Windows.Forms.ComboBox cbPrescription;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
    }
}
