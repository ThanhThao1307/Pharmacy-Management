using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy_Nhom1
{
    partial class frmNewCustomer
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
            pnlContent = new Panel();
            pnlTitle.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblFormTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1258, 60);
            pnlTitle.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.SteelBlue;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(26, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(405, 38);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "ĐĂNG KÝ KHÁCH HÀNG MỚI";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(26, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(123, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Họ và tên:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(158, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(541, 34);
            txtName.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(745, 27);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(110, 32);
            lblGender.TabIndex = 3;
            lblGender.Text = "Giới tính:";
            // 
            // cboGender
            // 
            cboGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 10F);
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(912, 30);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(319, 36);
            cboGender.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 12F);
            lblBirthDate.Location = new Point(26, 168);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(126, 32);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Font = new Font("Segoe UI", 10F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(158, 169);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(541, 34);
            dtpBirthDate.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F);
            lblPhone.Location = new Point(745, 168);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(161, 32);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(912, 172);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(319, 34);
            txtPhone.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F);
            lblAddress.Location = new Point(26, 298);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(92, 32);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(158, 302);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(1073, 95);
            txtAddress.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(26, 419);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(158, 423);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(541, 34);
            txtEmail.TabIndex = 12;
            // 
            // chkStatus
            // 
            chkStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Font = new Font("Segoe UI", 12F);
            chkStatus.Location = new Point(1016, 418);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(215, 36);
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
            pnlButtons.Location = new Point(0, 566);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1258, 50);
            pnlButtons.TabIndex = 14;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.BackColor = Color.Silver;
            btClose.Cursor = Cursors.Hand;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(1126, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(105, 34);
            btClose.TabIndex = 15;
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
            btSave.Location = new Point(1002, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(105, 34);
            btSave.TabIndex = 0;
            btSave.Text = "💾 LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightBlue;
            pnlContent.Controls.Add(chkStatus);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(txtAddress);
            pnlContent.Controls.Add(lblAddress);
            pnlContent.Controls.Add(txtPhone);
            pnlContent.Controls.Add(lblPhone);
            pnlContent.Controls.Add(dtpBirthDate);
            pnlContent.Controls.Add(lblBirthDate);
            pnlContent.Controls.Add(cboGender);
            pnlContent.Controls.Add(lblGender);
            pnlContent.Controls.Add(txtName);
            pnlContent.Controls.Add(lblName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 506);
            pnlContent.TabIndex = 16;
            // 
            // frmNewCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "frmNewCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ĐĂNG KÝ KHÁCH HÀNG MỚI";
            WindowState = FormWindowState.Maximized;
            Load += frmNewCustomer_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
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
        private Panel pnlContent;
    }
}
