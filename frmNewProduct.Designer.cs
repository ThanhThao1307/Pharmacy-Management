using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy_Nhom1
{
    partial class frmNewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewProduct));
            pnlTitle = new Panel();
            lblFormTitle = new Label();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            cboCategories = new ComboBox();
            lblCategory = new Label();
            chkStatus = new CheckBox();
            pnlButtons = new Panel();
            btClose = new Button();
            btSave = new Button();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            chkPrescription = new CheckBox();
            lblNormalPrice = new Label();
            txtNormalPrice = new TextBox();
            lblDescription = new Label();
            rtxtDescription = new RichTextBox();
            lblImageFile = new Label();
            txtImageFile = new TextBox();
            btBrowseImage = new Button();
            picPreview = new PictureBox();
            lblUnitsTitle = new Label();
            pnlContent = new Panel();
            pnlTitle.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
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
            lblFormTitle.Size = new Size(424, 38);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "THÊM SẢN PHẨM THUỐC MỚI";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Segoe UI", 12F);
            lblProductCode.Location = new Point(26, 20);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(121, 32);
            lblProductCode.TabIndex = 1;
            lblProductCode.Text = "Mã thuốc:";
            // 
            // txtProductCode
            // 
            txtProductCode.BorderStyle = BorderStyle.FixedSingle;
            txtProductCode.Font = new Font("Segoe UI", 10F);
            txtProductCode.Location = new Point(161, 24);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(254, 34);
            txtProductCode.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 12F);
            lblProductName.Location = new Point(433, 20);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(125, 32);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Tên thuốc:";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 10F);
            txtProductName.Location = new Point(606, 21);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(314, 34);
            txtProductName.TabIndex = 4;
            // 
            // cboCategories
            // 
            cboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategories.Font = new Font("Segoe UI", 10F);
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(161, 86);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(254, 36);
            cboCategories.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(26, 83);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(129, 32);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Danh mục:";
            // 
            // chkStatus
            // 
            chkStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Font = new Font("Segoe UI", 12F);
            chkStatus.Location = new Point(26, 464);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(225, 36);
            chkStatus.TabIndex = 16;
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
            pnlButtons.TabIndex = 17;
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
            btClose.TabIndex = 18;
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
            // lblUnit
            // 
            lblUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 12F);
            lblUnit.Location = new Point(938, 20);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(138, 32);
            lblUnit.TabIndex = 18;
            lblUnit.Text = "Đơn vị tính:";
            // 
            // txtUnit
            // 
            txtUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.Font = new Font("Segoe UI", 10F);
            txtUnit.Location = new Point(1079, 21);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(152, 34);
            txtUnit.TabIndex = 19;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(938, 83);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 32);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Giá bán:";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(1079, 87);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(152, 34);
            txtPrice.TabIndex = 21;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // chkPrescription
            // 
            chkPrescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkPrescription.AutoSize = true;
            chkPrescription.CheckAlign = ContentAlignment.MiddleRight;
            chkPrescription.Font = new Font("Segoe UI", 12F);
            chkPrescription.Location = new Point(408, 464);
            chkPrescription.Name = "chkPrescription";
            chkPrescription.Size = new Size(231, 36);
            chkPrescription.TabIndex = 22;
            chkPrescription.Text = "Thuốc cần kê đơn";
            chkPrescription.UseVisualStyleBackColor = true;
            // 
            // lblNormalPrice
            // 
            lblNormalPrice.AutoSize = true;
            lblNormalPrice.Font = new Font("Segoe UI", 12F);
            lblNormalPrice.Location = new Point(433, 83);
            lblNormalPrice.Name = "lblNormalPrice";
            lblNormalPrice.Size = new Size(167, 32);
            lblNormalPrice.TabIndex = 24;
            lblNormalPrice.Text = "Giá thị trường:";
            // 
            // txtNormalPrice
            // 
            txtNormalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNormalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtNormalPrice.Font = new Font("Segoe UI", 10F);
            txtNormalPrice.Location = new Point(606, 84);
            txtNormalPrice.Name = "txtNormalPrice";
            txtNormalPrice.Size = new Size(314, 34);
            txtNormalPrice.TabIndex = 25;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(26, 147);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(150, 32);
            lblDescription.TabIndex = 26;
            lblDescription.Text = "Mô tả thuốc:";
            // 
            // rtxtDescription
            // 
            rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtDescription.Location = new Point(217, 151);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtxtDescription.Size = new Size(535, 54);
            rtxtDescription.TabIndex = 27;
            rtxtDescription.Text = "";
            // 
            // lblImageFile
            // 
            lblImageFile.AutoSize = true;
            lblImageFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImageFile.Location = new Point(26, 227);
            lblImageFile.Name = "lblImageFile";
            lblImageFile.Size = new Size(185, 32);
            lblImageFile.TabIndex = 28;
            lblImageFile.Text = "Hình ảnh thuốc:";
            // 
            // txtImageFile
            // 
            txtImageFile.BackColor = SystemColors.Window;
            txtImageFile.BorderStyle = BorderStyle.FixedSingle;
            txtImageFile.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImageFile.Location = new Point(217, 231);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.ReadOnly = true;
            txtImageFile.Size = new Size(422, 34);
            txtImageFile.TabIndex = 29;
            // 
            // btBrowseImage
            // 
            btBrowseImage.BackColor = Color.SteelBlue;
            btBrowseImage.FlatAppearance.BorderSize = 0;
            btBrowseImage.FlatStyle = FlatStyle.Flat;
            btBrowseImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowseImage.ForeColor = Color.White;
            btBrowseImage.Location = new Point(666, 226);
            btBrowseImage.Name = "btBrowseImage";
            btBrowseImage.Size = new Size(86, 36);
            btBrowseImage.TabIndex = 30;
            btBrowseImage.Text = "Chọn...";
            btBrowseImage.UseVisualStyleBackColor = false;
            btBrowseImage.Click += btBrowseImage_Click;
            // 
            // picPreview
            // 
            picPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(26, 278);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(613, 180);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 31;
            picPreview.TabStop = false;
            // 
            // lblUnitsTitle
            // 
            lblUnitsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUnitsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUnitsTitle.ForeColor = Color.DimGray;
            lblUnitsTitle.Location = new Point(792, 147);
            lblUnitsTitle.Name = "lblUnitsTitle";
            lblUnitsTitle.Size = new Size(439, 350);
            lblUnitsTitle.TabIndex = 32;
            lblUnitsTitle.Text = resources.GetString("lblUnitsTitle.Text");
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightBlue;
            pnlContent.Controls.Add(lblUnitsTitle);
            pnlContent.Controls.Add(picPreview);
            pnlContent.Controls.Add(btBrowseImage);
            pnlContent.Controls.Add(txtImageFile);
            pnlContent.Controls.Add(lblImageFile);
            pnlContent.Controls.Add(rtxtDescription);
            pnlContent.Controls.Add(lblDescription);
            pnlContent.Controls.Add(txtNormalPrice);
            pnlContent.Controls.Add(lblNormalPrice);
            pnlContent.Controls.Add(chkStatus);
            pnlContent.Controls.Add(chkPrescription);
            pnlContent.Controls.Add(txtPrice);
            pnlContent.Controls.Add(lblPrice);
            pnlContent.Controls.Add(txtUnit);
            pnlContent.Controls.Add(lblUnit);
            pnlContent.Controls.Add(lblCategory);
            pnlContent.Controls.Add(cboCategories);
            pnlContent.Controls.Add(txtProductName);
            pnlContent.Controls.Add(lblProductName);
            pnlContent.Controls.Add(txtProductCode);
            pnlContent.Controls.Add(lblProductCode);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 506);
            pnlContent.TabIndex = 33;
            // 
            // frmNewProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTitle);
            Name = "frmNewProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "THÊM MỚI THÔNG TIN THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += frmNewProduct_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lblFormTitle;
        private Label lblProductCode;
        private TextBox txtProductCode;
        private Label lblProductName;
        private TextBox txtProductName;
        private ComboBox cboCategories;
        private Label lblCategory;
        private CheckBox chkStatus;
        private Panel pnlButtons;
        private Button btSave;
        private Button btClose;
        private Label lblUnit;
        private TextBox txtUnit;
        private Label lblPrice;
        private TextBox txtPrice;
        private CheckBox chkPrescription;
        private Label lblNormalPrice;
        private TextBox txtNormalPrice;

        private Label lblDescription;
        private RichTextBox rtxtDescription;
        private Label lblImageFile;
        private TextBox txtImageFile;
        private Button btBrowseImage;
        private PictureBox picPreview;
        private Label lblUnitsTitle;
        private Panel pnlContent;
    }
}
