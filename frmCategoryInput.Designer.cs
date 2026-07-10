namespace Pharmacy_Nhom1
{
    partial class frmCategoryInput
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
            lblCategoryCode = new Label();
            txtCategoryCode = new TextBox();
            pnlTitle = new Panel();
            lblFormTitle = new Label();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            chkStatus = new CheckBox();
            pnlButtons = new Panel();
            btClose = new Button();
            btSave = new Button();
            pnlTitle.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategoryCode
            // 
            lblCategoryCode.AutoSize = true;
            lblCategoryCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryCode.ForeColor = Color.Black;
            lblCategoryCode.Location = new Point(26, 86);
            lblCategoryCode.Name = "lblCategoryCode";
            lblCategoryCode.Size = new Size(135, 28);
            lblCategoryCode.TabIndex = 0;
            lblCategoryCode.Text = "Mã danh mục:";
            // 
            // txtCategoryCode
            // 
            txtCategoryCode.Location = new Point(167, 86);
            txtCategoryCode.MaxLength = 20;
            txtCategoryCode.Name = "txtCategoryCode";
            txtCategoryCode.Size = new Size(196, 31);
            txtCategoryCode.TabIndex = 1;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblFormTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(800, 60);
            pnlTitle.TabIndex = 2;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(26, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(322, 32);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "THÔNG TIN NHÓM THUỐC";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(369, 86);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(181, 28);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "Tên nhóm thuốc (*):";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(556, 86);
            txtCategoryName.MaxLength = 100;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(216, 31);
            txtCategoryName.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(26, 138);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 28);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Mô tả tóm tắt:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(170, 138);
            txtDescription.MaxLength = 500;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(605, 159);
            txtDescription.TabIndex = 6;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkStatus.ForeColor = Color.Firebrick;
            chkStatus.Location = new Point(550, 324);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(225, 36);
            chkStatus.TabIndex = 7;
            chkStatus.Text = "Đang kinh doanh";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btClose);
            pnlButtons.Controls.Add(btSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 385);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(800, 65);
            pnlButtons.TabIndex = 8;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.Cursor = Cursors.Hand;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(670, 19);
            btClose.Name = "btClose";
            btClose.Size = new Size(105, 34);
            btClose.TabIndex = 9;
            btClose.Text = "❌ HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.MidnightBlue;
            btSave.Cursor = Cursors.Hand;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.FloralWhite;
            btSave.Location = new Point(543, 19);
            btSave.Name = "btSave";
            btSave.Size = new Size(109, 34);
            btSave.TabIndex = 9;
            btSave.Text = "💾  LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // frmCategoryInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlButtons);
            Controls.Add(chkStatus);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategoryName);
            Controls.Add(pnlTitle);
            Controls.Add(txtCategoryCode);
            Controls.Add(lblCategoryCode);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCategoryInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CẬP NHẬT DANH MỤC THUỐC";
            Load += frmCategoryInput_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryCode;
        private TextBox txtCategoryCode;
        private Panel pnlTitle;
        private Label lblFormTitle;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Label lblDescription;
        private TextBox txtDescription;
        private CheckBox chkStatus;
        private Panel pnlButtons;
        private Button btSave;
        private Button btClose;
    }
}