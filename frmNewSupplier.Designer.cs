using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy_Nhom1
{
    partial class frmNewSupplier
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
            pnlTop = new Panel();
            lblFormTitle = new Label();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblTaxCode = new Label();
            txtTaxCode = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            chkStatus = new CheckBox();
            pnlBottom = new Panel();
            btSave = new Button();
            btClose = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            pnlContent = new Panel();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.SteelBlue;
            pnlTop.Controls.Add(lblFormTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1258, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(26, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(382, 38);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "THÊM NHÀ CUNG CẤP MỚI";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 12F);
            lblSupplierName.Location = new Point(26, 27);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(208, 32);
            lblSupplierName.TabIndex = 1;
            lblSupplierName.Text = "Tên nhà cung cấp:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierName.Font = new Font("Segoe UI", 10F);
            txtSupplierName.Location = new Point(303, 31);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(388, 34);
            txtSupplierName.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(715, 27);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(161, 32);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(882, 31);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(349, 34);
            txtPhone.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(26, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(303, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(928, 34);
            txtEmail.TabIndex = 12;
            // 
            // lblTaxCode
            // 
            lblTaxCode.AutoSize = true;
            lblTaxCode.Font = new Font("Segoe UI", 12F);
            lblTaxCode.Location = new Point(26, 234);
            lblTaxCode.Name = "lblTaxCode";
            lblTaxCode.Size = new Size(271, 32);
            lblTaxCode.TabIndex = 5;
            lblTaxCode.Text = "Mã số thuế thương mại:";
            // 
            // txtTaxCode
            // 
            txtTaxCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTaxCode.BorderStyle = BorderStyle.FixedSingle;
            txtTaxCode.Font = new Font("Segoe UI", 10F);
            txtTaxCode.Location = new Point(303, 238);
            txtTaxCode.Name = "txtTaxCode";
            txtTaxCode.Size = new Size(928, 34);
            txtTaxCode.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F);
            lblAddress.Location = new Point(26, 338);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(214, 32);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Địa chỉ văn phòng:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(303, 342);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(928, 65);
            txtAddress.TabIndex = 8;
            // 
            // chkStatus
            // 
            chkStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkStatus.Location = new Point(658, 419);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(535, 36);
            chkStatus.TabIndex = 9;
            chkStatus.Text = "Đang hoạt động hợp tác / Cho phép giao dịch";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.CadetBlue;
            pnlBottom.Controls.Add(btSave);
            pnlBottom.Controls.Add(btClose);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 566);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1258, 50);
            pnlBottom.TabIndex = 10;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSave.BackColor = Color.MidnightBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.FloralWhite;
            btSave.Location = new Point(1001, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(105, 34);
            btSave.TabIndex = 11;
            btSave.Text = "💾  LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
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
            btClose.TabIndex = 12;
            btClose.Text = "❌  HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightBlue;
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(chkStatus);
            pnlContent.Controls.Add(txtAddress);
            pnlContent.Controls.Add(lblAddress);
            pnlContent.Controls.Add(txtTaxCode);
            pnlContent.Controls.Add(lblTaxCode);
            pnlContent.Controls.Add(txtPhone);
            pnlContent.Controls.Add(lblPhone);
            pnlContent.Controls.Add(txtSupplierName);
            pnlContent.Controls.Add(lblSupplierName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 506);
            pnlContent.TabIndex = 13;
            // 
            // frmNewSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            Name = "frmNewSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "THÊM MỚI NHÀ CUNG CẤP";
            WindowState = FormWindowState.Maximized;
            Load += frmNewSupplier_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblFormTitle;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblTaxCode;
        private TextBox txtTaxCode;
        private Label lblAddress;
        private TextBox txtAddress;
        private CheckBox chkStatus;
        private Panel pnlBottom;
        private Button btSave;
        private Button btClose;
        private Label lblEmail;
        private TextBox txtEmail;
        private Panel pnlContent;
    }
}
