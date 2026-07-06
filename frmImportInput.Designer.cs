namespace Pharmacy_Nhom1
{
    partial class frmImportInput
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlTitle = new Panel();
            lblFormTitle = new Label();
            lblImportCode = new Label();
            txtImportCode = new TextBox();
            lblSupplier = new Label();
            cboSupplier = new ComboBox();
            lblCreatedBy = new Label();
            txtCreatedBy = new TextBox();
            lblImportDate = new Label();
            dtpImportDate = new DateTimePicker();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblProduct = new Label();
            cboProduct = new ComboBox();
            lblBatchNumber = new Label();
            txtBatchNumber = new TextBox();
            lblExpiryDate = new Label();
            dtpExpiryDate = new DateTimePicker();
            btAddDetail = new Button();
            lblQty = new Label();
            nudOriginalQuantity = new NumericUpDown();
            lblPrice = new Label();
            nudImportPrice = new NumericUpDown();
            pnlButtons = new Panel();
            btClose = new Button();
            btSave = new Button();
            dgvImportDetails = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            BatchNumber = new DataGridViewTextBoxColumn();
            ExpiryDate = new DataGridViewTextBoxColumn();
            ConversionRate = new DataGridViewTextBoxColumn();
            OriginalQuantity = new DataGridViewTextBoxColumn();
            ImportPrice = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            lblTotal = new Label();
            txtTotalAmount = new TextBox();
            picProductImage = new PictureBox();
            lblProductImage = new Label();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudOriginalQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudImportPrice).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblFormTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1191, 67);
            pnlTitle.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(30, 17);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(418, 32);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "THÔNG TIN CHỨNG TỪ NHẬP KHO";
            // 
            // lblImportCode
            // 
            lblImportCode.AutoSize = true;
            lblImportCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImportCode.Location = new Point(30, 96);
            lblImportCode.Name = "lblImportCode";
            lblImportCode.Size = new Size(172, 28);
            lblImportCode.TabIndex = 1;
            lblImportCode.Text = "Mã phiếu nhập (*):";
            // 
            // txtImportCode
            // 
            txtImportCode.BorderStyle = BorderStyle.FixedSingle;
            txtImportCode.Location = new Point(206, 94);
            txtImportCode.Name = "txtImportCode";
            txtImportCode.Size = new Size(300, 34);
            txtImportCode.TabIndex = 2;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 10F);
            lblSupplier.Location = new Point(520, 96);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(161, 28);
            lblSupplier.TabIndex = 3;
            lblSupplier.Text = "Nhà cung cấp (*):";
            // 
            // cboSupplier
            // 
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(687, 93);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(490, 36);
            cboSupplier.TabIndex = 4;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 10F);
            lblCreatedBy.Location = new Point(30, 145);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(129, 28);
            lblCreatedBy.TabIndex = 5;
            lblCreatedBy.Text = "Người lập (*):";
            // 
            // txtCreatedBy
            // 
            txtCreatedBy.BorderStyle = BorderStyle.FixedSingle;
            txtCreatedBy.Location = new Point(206, 143);
            txtCreatedBy.Name = "txtCreatedBy";
            txtCreatedBy.Size = new Size(300, 34);
            txtCreatedBy.TabIndex = 6;
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("Segoe UI", 10F);
            lblImportDate.Location = new Point(520, 145);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(150, 28);
            lblImportDate.TabIndex = 7;
            lblImportDate.Text = "Ngày nhập kho:";
            // 
            // dtpImportDate
            // 
            dtpImportDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpImportDate.Format = DateTimePickerFormat.Custom;
            dtpImportDate.Location = new Point(687, 143);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(220, 34);
            dtpImportDate.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(929, 144);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(102, 28);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(1037, 141);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(140, 36);
            cboStatus.TabIndex = 10;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(30, 195);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(142, 28);
            lblProduct.TabIndex = 11;
            lblProduct.Text = "Chọn thuốc (*):";
            // 
            // cboProduct
            // 
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(206, 192);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(220, 36);
            cboProduct.TabIndex = 12;
            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            // 
            // lblBatchNumber
            // 
            lblBatchNumber.AutoSize = true;
            lblBatchNumber.Location = new Point(520, 195);
            lblBatchNumber.Name = "lblBatchNumber";
            lblBatchNumber.Size = new Size(86, 28);
            lblBatchNumber.TabIndex = 13;
            lblBatchNumber.Text = "Số lô (*):";
            // 
            // txtBatchNumber
            // 
            txtBatchNumber.BorderStyle = BorderStyle.FixedSingle;
            txtBatchNumber.Location = new Point(687, 193);
            txtBatchNumber.Name = "txtBatchNumber";
            txtBatchNumber.Size = new Size(150, 34);
            txtBatchNumber.TabIndex = 14;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Location = new Point(884, 195);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(127, 28);
            lblExpiryDate.TabIndex = 15;
            lblExpiryDate.Text = "Hạn dùng (*):";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.CustomFormat = "dd/MM/yyyy";
            dtpExpiryDate.Format = DateTimePickerFormat.Custom;
            dtpExpiryDate.Location = new Point(1017, 194);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(160, 34);
            dtpExpiryDate.TabIndex = 16;
            // 
            // btAddDetail
            // 
            btAddDetail.BackColor = Color.PaleVioletRed;
            btAddDetail.FlatAppearance.BorderSize = 0;
            btAddDetail.FlatStyle = FlatStyle.Flat;
            btAddDetail.ForeColor = Color.AliceBlue;
            btAddDetail.Location = new Point(1065, 259);
            btAddDetail.Name = "btAddDetail";
            btAddDetail.Size = new Size(112, 34);
            btAddDetail.TabIndex = 17;
            btAddDetail.Text = "Thêm lô";
            btAddDetail.UseVisualStyleBackColor = false;
            btAddDetail.Click += btAddDetail_Click;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(30, 245);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(145, 28);
            lblQty.TabIndex = 18;
            lblQty.Text = "Số lượng nhập:";
            // 
            // nudOriginalQuantity
            // 
            nudOriginalQuantity.BorderStyle = BorderStyle.FixedSingle;
            nudOriginalQuantity.Location = new Point(206, 243);
            nudOriginalQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudOriginalQuantity.Name = "nudOriginalQuantity";
            nudOriginalQuantity.Size = new Size(200, 34);
            nudOriginalQuantity.TabIndex = 19;
            nudOriginalQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(30, 300);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(220, 28);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Giá nhập (Hộp/Vỉ/Chai):";
            // 
            // nudImportPrice
            // 
            nudImportPrice.BorderStyle = BorderStyle.FixedSingle;
            nudImportPrice.Location = new Point(256, 298);
            nudImportPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudImportPrice.Name = "nudImportPrice";
            nudImportPrice.Size = new Size(180, 34);
            nudImportPrice.TabIndex = 21;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btClose);
            pnlButtons.Controls.Add(btSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 659);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1191, 50);
            pnlButtons.TabIndex = 22;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Location = new Point(1048, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 1;
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
            btSave.Location = new Point(920, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(112, 34);
            btSave.TabIndex = 0;
            btSave.Text = "💾 LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // dgvImportDetails
            // 
            dgvImportDetails.AllowUserToAddRows = false;
            dgvImportDetails.AllowUserToDeleteRows = false;
            dgvImportDetails.AllowUserToOrderColumns = true;
            dgvImportDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImportDetails.BackgroundColor = Color.LightBlue;
            dgvImportDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportDetails.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, BatchNumber, ExpiryDate, ConversionRate, OriginalQuantity, ImportPrice, Amount, Status, Delete });
            dgvImportDetails.Location = new Point(30, 352);
            dgvImportDetails.Name = "dgvImportDetails";
            dgvImportDetails.ReadOnly = true;
            dgvImportDetails.RowHeadersVisible = false;
            dgvImportDetails.RowHeadersWidth = 62;
            dgvImportDetails.Size = new Size(1130, 225);
            dgvImportDetails.TabIndex = 23;
            dgvImportDetails.CellContentClick += dgvImportDetails_CellContentClick;
            dgvImportDetails.CellValueChanged += dgvImportDetails_CellValueChanged;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "Mã Số";
            ProductId.MinimumWidth = 8;
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Tên Thuốc / Sản Phẩm";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // BatchNumber
            // 
            BatchNumber.DataPropertyName = "BatchNumber";
            BatchNumber.HeaderText = "Số Lô";
            BatchNumber.MinimumWidth = 8;
            BatchNumber.Name = "BatchNumber";
            BatchNumber.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            ExpiryDate.DataPropertyName = "ExpiryDate";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            ExpiryDate.DefaultCellStyle = dataGridViewCellStyle4;
            ExpiryDate.HeaderText = "Hạn Sử Dụng";
            ExpiryDate.MinimumWidth = 8;
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.ReadOnly = true;
            // 
            // ConversionRate
            // 
            ConversionRate.DataPropertyName = "SelectedConversionRate";
            ConversionRate.HeaderText = "Tỷ Lệ Quy Đổi";
            ConversionRate.MinimumWidth = 8;
            ConversionRate.Name = "ConversionRate";
            ConversionRate.ReadOnly = true;
            // 
            // OriginalQuantity
            // 
            OriginalQuantity.DataPropertyName = "InputQuantity";
            OriginalQuantity.HeaderText = "Số Lượng";
            OriginalQuantity.MinimumWidth = 8;
            OriginalQuantity.Name = "OriginalQuantity";
            OriginalQuantity.ReadOnly = true;
            // 
            // ImportPrice
            // 
            ImportPrice.DataPropertyName = "InputPrice";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            ImportPrice.DefaultCellStyle = dataGridViewCellStyle5;
            ImportPrice.HeaderText = "Giá Nhập";
            ImportPrice.MinimumWidth = 8;
            ImportPrice.Name = "ImportPrice";
            ImportPrice.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            Amount.DefaultCellStyle = dataGridViewCellStyle6;
            Amount.HeaderText = "Thành Tiền";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng Thái Lô";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(735, 606);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(269, 28);
            lblTotal.TabIndex = 24;
            lblTotal.Text = "TỔNG TIỀN HÓA ĐƠN (VNĐ):";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(1010, 603);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(150, 34);
            txtTotalAmount.TabIndex = 25;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // picProductImage
            // 
            picProductImage.BackColor = Color.White;
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(687, 243);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(324, 102);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 31;
            picProductImage.TabStop = false;
            // 
            // lblProductImage
            // 
            lblProductImage.AutoSize = true;
            lblProductImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductImage.ForeColor = Color.Navy;
            lblProductImage.Location = new Point(520, 248);
            lblProductImage.Name = "lblProductImage";
            lblProductImage.Size = new Size(149, 25);
            lblProductImage.TabIndex = 30;
            lblProductImage.Text = "Hình ảnh thuốc:";
            // 
            // frmImportInput
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1191, 709);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblTotal);
            Controls.Add(picProductImage);
            Controls.Add(lblProductImage);
            Controls.Add(dgvImportDetails);
            Controls.Add(pnlButtons);
            Controls.Add(nudImportPrice);
            Controls.Add(lblPrice);
            Controls.Add(nudOriginalQuantity);
            Controls.Add(lblQty);
            Controls.Add(btAddDetail);
            Controls.Add(dtpExpiryDate);
            Controls.Add(lblExpiryDate);
            Controls.Add(txtBatchNumber);
            Controls.Add(lblBatchNumber);
            Controls.Add(cboProduct);
            Controls.Add(lblProduct);
            Controls.Add(cboStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpImportDate);
            Controls.Add(lblImportDate);
            Controls.Add(txtCreatedBy);
            Controls.Add(lblCreatedBy);
            Controls.Add(cboSupplier);
            Controls.Add(lblSupplier);
            Controls.Add(txtImportCode);
            Controls.Add(lblImportCode);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmImportInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "-";
            Load += frmImportInput_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudOriginalQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudImportPrice).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImportDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblFormTitle;
        private Label lblImportCode;
        private TextBox txtImportCode;
        private Label lblSupplier;
        private ComboBox cboSupplier;
        private Label lblCreatedBy;
        private TextBox txtCreatedBy;
        private Label lblImportDate;
        private DateTimePicker dtpImportDate;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label lblProduct;
        private ComboBox cboProduct;
        private Label lblBatchNumber;
        private TextBox txtBatchNumber;
        private Label lblExpiryDate;
        private DateTimePicker dtpExpiryDate;
        private Button btAddDetail;
        private Label lblQty;
        private NumericUpDown nudOriginalQuantity;
        private Label lblPrice;
        private NumericUpDown nudImportPrice;
        private Panel pnlButtons;
        private DataGridView dgvImportDetails;
        private Label lblTotal;
        private TextBox txtTotalAmount;
        private Button btSave;
        private Button btClose;
        private DataGridViewTextBoxColumn ProductId;
        private new DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn BatchNumber;
        private DataGridViewTextBoxColumn ExpiryDate;
        private DataGridViewTextBoxColumn ConversionRate;
        private DataGridViewTextBoxColumn OriginalQuantity;
        private DataGridViewTextBoxColumn ImportPrice;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Delete;
        private PictureBox picProductImage;
        private Label lblProductImage;
    }
}