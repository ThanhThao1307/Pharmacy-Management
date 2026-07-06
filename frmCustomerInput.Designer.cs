namespace Pharmacy_Nhom1
{
    partial class frmCustomerInput
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
            pnlTitle = new Panel();
            lblFormTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            chkStatus = new CheckBox();
            pnlButtons = new Panel();
            btClose = new Button();
            btSave = new Button();
            pnlTitle.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblFormTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(580, 60);
            pnlTitle.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.SteelBlue;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(24, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(319, 32);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(30, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Họ và tên:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(170, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(370, 31);
            txtName.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(30, 140);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(91, 28);
            lblGender.TabIndex = 3;
            lblGender.Text = "Giới tính:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(170, 137);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(370, 33);
            cboGender.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthDate.Location = new Point(30, 190);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(103, 28);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(170, 187);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(370, 31);
            dtpBirthDate.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(30, 240);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(132, 28);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(170, 237);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(370, 31);
            txtPhone.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(30, 290);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(75, 28);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(170, 287);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(370, 31);
            txtAddress.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(30, 340);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(170, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 31);
            txtEmail.TabIndex = 12;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkStatus.Location = new Point(30, 390);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(163, 32);
            chkStatus.TabIndex = 13;
            chkStatus.Text = "Đang hoạt động";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btClose);
            pnlButtons.Controls.Add(btSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 440);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(580, 50);
            pnlButtons.TabIndex = 14;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.Cursor = Cursors.Hand;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(440, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 15;
            btClose.Text = "❌ HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.MidnightBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.FloralWhite;
            btSave.Location = new Point(310, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 34);
            btSave.TabIndex = 0;
            btSave.Text = "💾 LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // frmCustomerInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(580, 490);
            Controls.Add(pnlButtons);
            Controls.Add(chkStatus);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomerInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG";
            Load += frmCustomerInput_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblFormTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblGender;
        private ComboBox cboGender;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblEmail;
        private TextBox txtEmail;
        private CheckBox chkStatus;
        private Panel pnlButtons;
        private Button btSave;
        private Button btClose;
    }
}
