namespace Pharmacy_Nhom1
{
    partial class frmSupplierInput
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
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.SteelBlue;
            pnlTop.Controls.Add(lblFormTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(22, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(338, 32);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierName.Location = new Point(22, 88);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(191, 28);
            lblSupplierName.TabIndex = 1;
            lblSupplierName.Text = "Tên nhà cung cấp (*):";
            // 
            // txtSupplierName
            // 
            txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierName.Location = new Point(219, 89);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(190, 31);
            txtSupplierName.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(415, 88);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(157, 28);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại (*):";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(578, 89);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(198, 31);
            txtPhone.TabIndex = 4;
            // 
            // lblTaxCode
            // 
            lblTaxCode.AutoSize = true;
            lblTaxCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaxCode.Location = new Point(22, 199);
            lblTaxCode.Name = "lblTaxCode";
            lblTaxCode.Size = new Size(245, 28);
            lblTaxCode.TabIndex = 5;
            lblTaxCode.Text = "Mã số thuế thương mại (*):";
            // 
            // txtTaxCode
            // 
            txtTaxCode.BorderStyle = BorderStyle.FixedSingle;
            txtTaxCode.Location = new Point(273, 200);
            txtTaxCode.Name = "txtTaxCode";
            txtTaxCode.Size = new Size(503, 31);
            txtTaxCode.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(22, 254);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(174, 28);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Địa chỉ văn phòng:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(219, 255);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(557, 31);
            txtAddress.TabIndex = 8;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkStatus.Location = new Point(241, 328);
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
            pnlBottom.Location = new Point(0, 400);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(800, 50);
            pnlBottom.TabIndex = 10;
            // 
            // btSave
            // 
            btSave.BackColor = Color.MidnightBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.FloralWhite;
            btSave.Location = new Point(533, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 34);
            btSave.TabIndex = 11;
            btSave.Text = "💾  LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.Cursor = Cursors.Hand;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(664, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 12;
            btClose.Text = "❌  HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(22, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(219, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(557, 31);
            txtEmail.TabIndex = 12;
            // 
            // frmSupplierInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(pnlBottom);
            Controls.Add(chkStatus);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtTaxCode);
            Controls.Add(lblTaxCode);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtSupplierName);
            Controls.Add(lblSupplierName);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmSupplierInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CẬP NHẬT THÔNG TIN NHÀ PHÂN PHỐI";
            Load += frmSupplierInput_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
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
    }
}