namespace Pharmacy_Nhom1
{
    partial class frmProductInput
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
            dgvUnits = new DataGridView();
            ProductUnitId = new DataGridViewTextBoxColumn();
            UnitName = new DataGridViewTextBoxColumn();
            ConversionRate = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            lblNormalPrice = new Label();
            txtNormalPrice = new TextBox();
            lblDescription = new Label();
            rtxtDescription = new RichTextBox();
            lblImageFile = new Label();
            txtImageFile = new TextBox();
            btBrowseImage = new Button();
            picPreview = new PictureBox();
            lblUnitsTitle = new Label();
            pnlTitle.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblFormTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1135, 60);
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
            lblFormTitle.Size = new Size(373, 32);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "THÔNG TIN SẢN PHẨM THUỐC";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductCode.Location = new Point(15, 80);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(99, 28);
            lblProductCode.TabIndex = 1;
            lblProductCode.Text = "Mã thuốc:";
            // 
            // txtProductCode
            // 
            txtProductCode.BorderStyle = BorderStyle.FixedSingle;
            txtProductCode.Location = new Point(150, 77);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(190, 31);
            txtProductCode.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(15, 130);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 28);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Tên thuốc:";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(150, 127);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(190, 31);
            txtProductName.TabIndex = 4;
            // 
            // cboCategories
            // 
            cboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(150, 177);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(190, 33);
            cboCategories.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(15, 180);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(104, 28);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Danh mục:";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.CheckAlign = ContentAlignment.MiddleRight;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkStatus.Location = new Point(15, 415);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(188, 32);
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
            pnlButtons.Location = new Point(0, 475);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1135, 50);
            pnlButtons.TabIndex = 17;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.Cursor = Cursors.Hand;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(1005, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 18;
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
            btSave.Location = new Point(875, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 34);
            btSave.TabIndex = 0;
            btSave.Text = "💾 LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.Location = new Point(15, 230);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(111, 28);
            lblUnit.TabIndex = 18;
            lblUnit.Text = "Đơn vị gốc:";
            // 
            // txtUnit
            // 
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.Location = new Point(150, 227);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(190, 31);
            txtUnit.TabIndex = 19;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(15, 330);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(83, 28);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Giá bán:";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(150, 327);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(190, 31);
            txtPrice.TabIndex = 21;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // chkPrescription
            // 
            chkPrescription.AutoSize = true;
            chkPrescription.CheckAlign = ContentAlignment.MiddleRight;
            chkPrescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPrescription.Location = new Point(15, 375);
            chkPrescription.Name = "chkPrescription";
            chkPrescription.Size = new Size(191, 32);
            chkPrescription.TabIndex = 22;
            chkPrescription.Text = "Thuốc cần kê đơn";
            chkPrescription.UseVisualStyleBackColor = true;
            // 
            // dgvUnits
            // 
            dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnits.BackgroundColor = Color.Ivory;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnits.Columns.AddRange(new DataGridViewColumn[] { ProductUnitId, UnitName, ConversionRate, Price });
            dgvUnits.Location = new Point(750, 110);
            dgvUnits.Name = "dgvUnits";
            dgvUnits.RowHeadersVisible = false;
            dgvUnits.RowHeadersWidth = 62;
            dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnits.Size = new Size(367, 340);
            dgvUnits.TabIndex = 23;
            // 
            // ProductUnitId
            // 
            ProductUnitId.DataPropertyName = "ProductUnitId";
            ProductUnitId.HeaderText = "Mã Đơn Vị";
            ProductUnitId.MinimumWidth = 8;
            ProductUnitId.Name = "ProductUnitId";
            ProductUnitId.Visible = false;
            // 
            // UnitName
            // 
            UnitName.DataPropertyName = "UnitName";
            UnitName.HeaderText = "Tên Đơn Vị Quy Đổi";
            UnitName.MinimumWidth = 8;
            UnitName.Name = "UnitName";
            // 
            // ConversionRate
            // 
            ConversionRate.DataPropertyName = "ConversionRate";
            ConversionRate.HeaderText = "Tỷ Lệ Quy Đổi";
            ConversionRate.MinimumWidth = 8;
            ConversionRate.Name = "ConversionRate";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Giá Bán";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            // 
            // lblNormalPrice
            // 
            lblNormalPrice.AutoSize = true;
            lblNormalPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNormalPrice.Location = new Point(15, 280);
            lblNormalPrice.Name = "lblNormalPrice";
            lblNormalPrice.Size = new Size(125, 28);
            lblNormalPrice.TabIndex = 24;
            lblNormalPrice.Text = "Giá niêm yết:";
            // 
            // txtNormalPrice
            // 
            txtNormalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtNormalPrice.Location = new Point(150, 277);
            txtNormalPrice.Name = "txtNormalPrice";
            txtNormalPrice.Size = new Size(190, 31);
            txtNormalPrice.TabIndex = 25;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(370, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(123, 28);
            lblDescription.TabIndex = 26;
            lblDescription.Text = "Mô tả thuốc:";
            // 
            // rtxtDescription
            // 
            rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxtDescription.Location = new Point(370, 110);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(350, 110);
            rtxtDescription.TabIndex = 27;
            rtxtDescription.Text = "";
            // 
            // lblImageFile
            // 
            lblImageFile.AutoSize = true;
            lblImageFile.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImageFile.Location = new Point(370, 235);
            lblImageFile.Name = "lblImageFile";
            lblImageFile.Size = new Size(149, 28);
            lblImageFile.TabIndex = 28;
            lblImageFile.Text = "Hình ảnh thuốc:";
            // 
            // txtImageFile
            // 
            txtImageFile.BorderStyle = BorderStyle.FixedSingle;
            txtImageFile.Location = new Point(370, 265);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.ReadOnly = true;
            txtImageFile.Size = new Size(270, 31);
            txtImageFile.TabIndex = 29;
            // 
            // btBrowseImage
            // 
            btBrowseImage.BackColor = Color.SteelBlue;
            btBrowseImage.FlatAppearance.BorderSize = 0;
            btBrowseImage.FlatStyle = FlatStyle.Flat;
            btBrowseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowseImage.ForeColor = Color.White;
            btBrowseImage.Location = new Point(650, 264);
            btBrowseImage.Name = "btBrowseImage";
            btBrowseImage.Size = new Size(83, 32);
            btBrowseImage.TabIndex = 30;
            btBrowseImage.Text = "Chọn...";
            btBrowseImage.UseVisualStyleBackColor = false;
            btBrowseImage.Click += btBrowseImage_Click;
            // 
            // picPreview
            // 
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(370, 310);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(363, 140);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 31;
            picPreview.TabStop = false;
            // 
            // lblUnitsTitle
            // 
            lblUnitsTitle.AutoSize = true;
            lblUnitsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnitsTitle.Location = new Point(750, 80);
            lblUnitsTitle.Name = "lblUnitsTitle";
            lblUnitsTitle.Size = new Size(357, 28);
            lblUnitsTitle.TabIndex = 32;
            lblUnitsTitle.Text = "Đơn vị quy đổi phụ (Hệ số quy đổi > 1):";
            // 
            // frmProductInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1135, 525);
            Controls.Add(lblUnitsTitle);
            Controls.Add(picPreview);
            Controls.Add(btBrowseImage);
            Controls.Add(txtImageFile);
            Controls.Add(lblImageFile);
            Controls.Add(rtxtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtNormalPrice);
            Controls.Add(lblNormalPrice);
            Controls.Add(chkStatus);
            Controls.Add(dgvUnits);
            Controls.Add(chkPrescription);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtUnit);
            Controls.Add(lblUnit);
            Controls.Add(pnlButtons);
            Controls.Add(lblCategory);
            Controls.Add(cboCategories);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(txtProductCode);
            Controls.Add(lblProductCode);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProductInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CẬP NHẬT THÔNG TIN THUỐC";
            Load += frmProductInput_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dgvUnits;
        private DataGridViewTextBoxColumn ProductUnitId;
        private DataGridViewTextBoxColumn UnitName;
        private DataGridViewTextBoxColumn ConversionRate;
        private DataGridViewTextBoxColumn Price;
        private Label lblNormalPrice;
        private TextBox txtNormalPrice;

        private Label lblDescription;
        private RichTextBox rtxtDescription;
        private Label lblImageFile;
        private TextBox txtImageFile;
        private Button btBrowseImage;
        private PictureBox picPreview;
        private Label lblUnitsTitle;
    }
}