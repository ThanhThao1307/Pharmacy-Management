using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy_Nhom1
{
    partial class frmEditCategory
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
            pnlContent = new Panel();
            pnlTitle.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategoryCode
            // 
            lblCategoryCode.AutoSize = true;
            lblCategoryCode.Font = new Font("Segoe UI", 12F);
            lblCategoryCode.ForeColor = Color.Black;
            lblCategoryCode.Location = new Point(26, 29);
            lblCategoryCode.Name = "lblCategoryCode";
            lblCategoryCode.Size = new Size(167, 32);
            lblCategoryCode.TabIndex = 0;
            lblCategoryCode.Text = "Mã danh mục:";
            // 
            // txtCategoryCode
            // 
            txtCategoryCode.BackColor = SystemColors.Window;
            txtCategoryCode.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryCode.Font = new Font("Segoe UI", 10F);
            txtCategoryCode.Location = new Point(199, 32);
            txtCategoryCode.Name = "txtCategoryCode";
            txtCategoryCode.ReadOnly = true;
            txtCategoryCode.Size = new Size(398, 34);
            txtCategoryCode.TabIndex = 1;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblFormTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1258, 60);
            pnlTitle.TabIndex = 2;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(26, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(425, 38);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "CẬP NHẬT DANH MỤC THUỐC";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(623, 29);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(195, 32);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "Tên nhóm thuốc:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(824, 32);
            txtCategoryName.MaxLength = 100;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(407, 34);
            txtCategoryName.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(26, 96);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(167, 32);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Mô tả tóm tắt:";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(199, 99);
            txtDescription.MaxLength = 500;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(1032, 283);
            txtDescription.TabIndex = 6;
            // 
            // chkStatus
            // 
            chkStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkStatus.ForeColor = Color.Firebrick;
            chkStatus.Location = new Point(975, 410);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(256, 42);
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
            pnlButtons.Location = new Point(0, 566);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1258, 50);
            pnlButtons.TabIndex = 8;
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
            btClose.TabIndex = 9;
            btClose.Text = "❌ HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSave.BackColor = Color.MidnightBlue;
            btSave.Cursor = Cursors.Hand;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.FloralWhite;
            btSave.Location = new Point(1000, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(109, 34);
            btSave.TabIndex = 9;
            btSave.Text = "💾  LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightBlue;
            pnlContent.Controls.Add(chkStatus);
            pnlContent.Controls.Add(txtDescription);
            pnlContent.Controls.Add(lblDescription);
            pnlContent.Controls.Add(txtCategoryName);
            pnlContent.Controls.Add(lblCategoryName);
            pnlContent.Controls.Add(txtCategoryCode);
            pnlContent.Controls.Add(lblCategoryCode);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 506);
            pnlContent.TabIndex = 10;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "frmEditCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CẬP NHẬT DANH MỤC THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += frmEditCategory_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
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
        private Panel pnlContent;
    }
}
