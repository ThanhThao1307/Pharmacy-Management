namespace Pharmacy_Nhom1
{
    partial class frmNewImport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlTitleSub = new Panel();
            lblFormTitleSub = new Label();
            pnlContent = new Panel();
            lblImportCode = new Label();
            txtImportCode = new TextBox();
            lblSupplier = new Label();
            cboSupplier = new ComboBox();
            lblImportDate = new Label();
            dtpImportDate = new DateTimePicker();
            lblCreatedBy = new Label();
            txtCreatedBy = new TextBox();
            lblProduct = new Label();
            cboProduct = new ComboBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblSection1 = new Label();
            dgvProductUnits = new DataGridView();
            colUnitName = new DataGridViewTextBoxColumn();
            colConversionRate = new DataGridViewTextBoxColumn();
            colImportPrice = new DataGridViewTextBoxColumn();
            lblProductImage = new Label();
            picProductImage = new PictureBox();
            lblSection2 = new Label();
            lblWholesaleUnit = new Label();
            cboWholesaleUnit = new ComboBox();
            lblWholesalePrice = new Label();
            nudWholesalePrice = new NumericUpDown();
            lblWholesaleQty = new Label();
            nudWholesaleQty = new NumericUpDown();
            lblBatchNumber = new Label();
            txtBatchNumber = new TextBox();
            lblExpiryDate = new Label();
            dtpExpiryDate = new DateTimePicker();
            btAddDetail = new Button();
            dgvImportDetails = new DataGridView();
            colProductName = new DataGridViewTextBoxColumn();
            colBatchNumber = new DataGridViewTextBoxColumn();
            colExpiryDate = new DataGridViewTextBoxColumn();
            colOriginalQuantity = new DataGridViewTextBoxColumn();
            colImportUnitPrice = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colLotStatus = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            colConversionRatio = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            pnlButtons = new Panel();
            lblTotal = new Label();
            txtTotalAmount = new TextBox();
            btSave = new Button();
            btClose = new Button();
            pnlTitleSub.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWholesalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWholesaleQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvImportDetails).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitleSub
            // 
            pnlTitleSub.BackColor = Color.SteelBlue;
            pnlTitleSub.Controls.Add(lblFormTitleSub);
            pnlTitleSub.Dock = DockStyle.Top;
            pnlTitleSub.Location = new Point(0, 0);
            pnlTitleSub.Name = "pnlTitleSub";
            pnlTitleSub.Size = new Size(1258, 60);
            pnlTitleSub.TabIndex = 2;
            // 
            // lblFormTitleSub
            // 
            lblFormTitleSub.AutoSize = true;
            lblFormTitleSub.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitleSub.ForeColor = Color.White;
            lblFormTitleSub.Location = new Point(15, 9);
            lblFormTitleSub.Name = "lblFormTitleSub";
            lblFormTitleSub.Size = new Size(484, 38);
            lblFormTitleSub.TabIndex = 0;
            lblFormTitleSub.Text = "THÔNG TIN CHỨNG TỪ NHẬP KHO";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightBlue;
            pnlContent.Controls.Add(lblImportCode);
            pnlContent.Controls.Add(txtImportCode);
            pnlContent.Controls.Add(lblSupplier);
            pnlContent.Controls.Add(cboSupplier);
            pnlContent.Controls.Add(lblImportDate);
            pnlContent.Controls.Add(dtpImportDate);
            pnlContent.Controls.Add(lblCreatedBy);
            pnlContent.Controls.Add(txtCreatedBy);
            pnlContent.Controls.Add(lblProduct);
            pnlContent.Controls.Add(cboProduct);
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Controls.Add(cboStatus);
            pnlContent.Controls.Add(lblSection1);
            pnlContent.Controls.Add(dgvProductUnits);
            pnlContent.Controls.Add(lblProductImage);
            pnlContent.Controls.Add(picProductImage);
            pnlContent.Controls.Add(lblSection2);
            pnlContent.Controls.Add(lblWholesaleUnit);
            pnlContent.Controls.Add(cboWholesaleUnit);
            pnlContent.Controls.Add(lblWholesalePrice);
            pnlContent.Controls.Add(nudWholesalePrice);
            pnlContent.Controls.Add(lblWholesaleQty);
            pnlContent.Controls.Add(nudWholesaleQty);
            pnlContent.Controls.Add(lblBatchNumber);
            pnlContent.Controls.Add(txtBatchNumber);
            pnlContent.Controls.Add(lblExpiryDate);
            pnlContent.Controls.Add(dtpExpiryDate);
            pnlContent.Controls.Add(btAddDetail);
            pnlContent.Controls.Add(dgvImportDetails);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Font = new Font("Segoe UI", 12F);
            pnlContent.Location = new Point(0, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 506);
            pnlContent.TabIndex = 0;
            // 
            // lblImportCode
            // 
            lblImportCode.AutoSize = true;
            lblImportCode.Font = new Font("Segoe UI", 12F);
            lblImportCode.Location = new Point(15, 12);
            lblImportCode.Name = "lblImportCode";
            lblImportCode.Size = new Size(182, 32);
            lblImportCode.TabIndex = 0;
            lblImportCode.Text = "Mã phiếu nhập:";
            // 
            // txtImportCode
            // 
            txtImportCode.BorderStyle = BorderStyle.FixedSingle;
            txtImportCode.Font = new Font("Segoe UI", 10F);
            txtImportCode.Location = new Point(203, 13);
            txtImportCode.Name = "txtImportCode";
            txtImportCode.ReadOnly = true;
            txtImportCode.Size = new Size(180, 34);
            txtImportCode.TabIndex = 1;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 12F);
            lblSupplier.Location = new Point(404, 12);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(167, 32);
            lblSupplier.TabIndex = 2;
            lblSupplier.Text = "Nhà cung cấp:";
            // 
            // cboSupplier
            // 
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.Font = new Font("Segoe UI", 10F);
            cboSupplier.Location = new Point(577, 12);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboSupplier.Size = new Size(250, 36);
            cboSupplier.TabIndex = 3;
            // 
            // lblImportDate
            // 
            lblImportDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("Segoe UI", 12F);
            lblImportDate.Location = new Point(840, 12);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(183, 32);
            lblImportDate.TabIndex = 4;
            lblImportDate.Text = "Ngày nhập kho:";
            // 
            // dtpImportDate
            // 
            dtpImportDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpImportDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpImportDate.Font = new Font("Segoe UI", 10F);
            dtpImportDate.Format = DateTimePickerFormat.Custom;
            dtpImportDate.Location = new Point(1029, 10);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(216, 34);
            dtpImportDate.TabIndex = 5;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 12F);
            lblCreatedBy.Location = new Point(15, 58);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(124, 32);
            lblCreatedBy.TabIndex = 6;
            lblCreatedBy.Text = "Người lập:";
            // 
            // txtCreatedBy
            // 
            txtCreatedBy.BorderStyle = BorderStyle.FixedSingle;
            txtCreatedBy.Font = new Font("Segoe UI", 10F);
            txtCreatedBy.Location = new Point(203, 59);
            txtCreatedBy.Name = "txtCreatedBy";
            txtCreatedBy.ReadOnly = true;
            txtCreatedBy.Size = new Size(180, 34);
            txtCreatedBy.TabIndex = 7;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 12F);
            lblProduct.Location = new Point(404, 58);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(144, 32);
            lblProduct.TabIndex = 8;
            lblProduct.Text = "Chọn thuốc:";
            // 
            // cboProduct
            // 
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.Font = new Font("Segoe UI", 10F);
            cboProduct.Location = new Point(577, 58);
            cboProduct.Name = "cboProduct";
            cboProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboProduct.Size = new Size(250, 36);
            cboProduct.TabIndex = 9;
            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(840, 58);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(125, 32);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 10F);
            cboStatus.Location = new Point(1029, 58);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(216, 36);
            cboStatus.TabIndex = 11;
            // 
            // lblSection1
            // 
            lblSection1.AutoSize = true;
            lblSection1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSection1.ForeColor = Color.Navy;
            lblSection1.Location = new Point(20, 106);
            lblSection1.Name = "lblSection1";
            lblSection1.Size = new Size(741, 28);
            lblSection1.TabIndex = 12;
            lblSection1.Text = "1. Bảng Đơn Vị Quy Đổi Giá Nhập Của Thuốc (Có thể thêm/sửa ĐV sỉ tại đây)";
            // 
            // dgvProductUnits
            // 
            dgvProductUnits.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductUnits.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvProductUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductUnits.Columns.AddRange(new DataGridViewColumn[] { colUnitName, colConversionRate, colImportPrice });
            dgvProductUnits.Font = new Font("Segoe UI", 10F);
            dgvProductUnits.Location = new Point(20, 137);
            dgvProductUnits.Name = "dgvProductUnits";
            dgvProductUnits.RowHeadersWidth = 30;
            dgvProductUnits.Size = new Size(927, 135);
            dgvProductUnits.TabIndex = 13;
            dgvProductUnits.CellValueChanged += dgvProductUnits_CellValueChanged;
            dgvProductUnits.CurrentCellDirtyStateChanged += dgvProductUnits_CurrentCellDirtyStateChanged;
            // 
            // colUnitName
            // 
            colUnitName.DataPropertyName = "UnitName";
            colUnitName.FillWeight = 80F;
            colUnitName.HeaderText = "Tên Đơn Vị (Vỉ, Hộp, Thùng...)";
            colUnitName.MinimumWidth = 8;
            colUnitName.Name = "colUnitName";
            // 
            // colConversionRate
            // 
            colConversionRate.DataPropertyName = "DisplayRatio";
            colConversionRate.FillWeight = 150F;
            colConversionRate.HeaderText = "SL quy đổi từ 1 ĐV Sỉ (Ví dụ: 1 Hộp = 100 Viên)";
            colConversionRate.MinimumWidth = 8;
            colConversionRate.Name = "colConversionRate";
            // 
            // colImportPrice
            // 
            colImportPrice.DataPropertyName = "ImportPrice";
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.Format = "N0";
            colImportPrice.DefaultCellStyle = dataGridViewCellStyle2;
            colImportPrice.FillWeight = 80F;
            colImportPrice.HeaderText = "Giá Nhập (VNĐ)";
            colImportPrice.MinimumWidth = 8;
            colImportPrice.Name = "colImportPrice";
            colImportPrice.ReadOnly = true;
            // 
            // lblProductImage
            // 
            lblProductImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProductImage.AutoSize = true;
            lblProductImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductImage.ForeColor = Color.Navy;
            lblProductImage.Location = new Point(981, 106);
            lblProductImage.Name = "lblProductImage";
            lblProductImage.Size = new Size(163, 28);
            lblProductImage.TabIndex = 14;
            lblProductImage.Text = "Hình ảnh thuốc:";
            // 
            // picProductImage
            // 
            picProductImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picProductImage.BackColor = Color.White;
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(981, 137);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(257, 135);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 15;
            picProductImage.TabStop = false;
            // 
            // lblSection2
            // 
            lblSection2.AutoSize = true;
            lblSection2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSection2.ForeColor = Color.DarkSlateGray;
            lblSection2.Location = new Point(20, 284);
            lblSection2.Name = "lblSection2";
            lblSection2.Size = new Size(374, 28);
            lblSection2.TabIndex = 16;
            lblSection2.Text = "2. Thông Tin Lô Nhập Thêm Vào Phiếu";
            // 
            // lblWholesaleUnit
            // 
            lblWholesaleUnit.AutoSize = true;
            lblWholesaleUnit.Font = new Font("Segoe UI", 12F);
            lblWholesaleUnit.Location = new Point(15, 315);
            lblWholesaleUnit.Name = "lblWholesaleUnit";
            lblWholesaleUnit.Size = new Size(112, 32);
            lblWholesaleUnit.TabIndex = 17;
            lblWholesaleUnit.Text = "ĐV nhập:";
            // 
            // cboWholesaleUnit
            // 
            cboWholesaleUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWholesaleUnit.Font = new Font("Segoe UI", 10F);
            cboWholesaleUnit.Location = new Point(133, 315);
            cboWholesaleUnit.Name = "cboWholesaleUnit";
            cboWholesaleUnit.Size = new Size(110, 36);
            cboWholesaleUnit.TabIndex = 18;
            cboWholesaleUnit.SelectedIndexChanged += cboWholesaleUnit_SelectedIndexChanged;
            // 
            // lblWholesalePrice
            // 
            lblWholesalePrice.AutoSize = true;
            lblWholesalePrice.Font = new Font("Segoe UI", 12F);
            lblWholesalePrice.Location = new Point(310, 366);
            lblWholesalePrice.Name = "lblWholesalePrice";
            lblWholesalePrice.Size = new Size(114, 32);
            lblWholesalePrice.TabIndex = 21;
            lblWholesalePrice.Text = "Giá nhập:";
            // 
            // nudWholesalePrice
            // 
            nudWholesalePrice.BorderStyle = BorderStyle.FixedSingle;
            nudWholesalePrice.Font = new Font("Segoe UI", 10F);
            nudWholesalePrice.Location = new Point(430, 367);
            nudWholesalePrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudWholesalePrice.Name = "nudWholesalePrice";
            nudWholesalePrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudWholesalePrice.Size = new Size(209, 34);
            nudWholesalePrice.TabIndex = 22;
            nudWholesalePrice.ValueChanged += nudWholesalePrice_ValueChanged;
            // 
            // lblWholesaleQty
            // 
            lblWholesaleQty.AutoSize = true;
            lblWholesaleQty.Font = new Font("Segoe UI", 12F);
            lblWholesaleQty.Location = new Point(15, 366);
            lblWholesaleQty.Name = "lblWholesaleQty";
            lblWholesaleQty.Size = new Size(104, 32);
            lblWholesaleQty.TabIndex = 23;
            lblWholesaleQty.Text = "SL nhập:";
            // 
            // nudWholesaleQty
            // 
            nudWholesaleQty.BorderStyle = BorderStyle.FixedSingle;
            nudWholesaleQty.Font = new Font("Segoe UI", 10F);
            nudWholesaleQty.Location = new Point(133, 367);
            nudWholesaleQty.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudWholesaleQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWholesaleQty.Name = "nudWholesaleQty";
            nudWholesaleQty.Size = new Size(110, 34);
            nudWholesaleQty.TabIndex = 24;
            nudWholesaleQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblBatchNumber
            // 
            lblBatchNumber.AutoSize = true;
            lblBatchNumber.Font = new Font("Segoe UI", 12F);
            lblBatchNumber.Location = new Point(310, 315);
            lblBatchNumber.Name = "lblBatchNumber";
            lblBatchNumber.Size = new Size(73, 32);
            lblBatchNumber.TabIndex = 25;
            lblBatchNumber.Text = "Số lô:";
            // 
            // txtBatchNumber
            // 
            txtBatchNumber.BorderStyle = BorderStyle.FixedSingle;
            txtBatchNumber.Font = new Font("Segoe UI", 10F);
            txtBatchNumber.Location = new Point(430, 316);
            txtBatchNumber.Name = "txtBatchNumber";
            txtBatchNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBatchNumber.Size = new Size(209, 34);
            txtBatchNumber.TabIndex = 26;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Font = new Font("Segoe UI", 12F);
            lblExpiryDate.Location = new Point(670, 315);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExpiryDate.Size = new Size(125, 32);
            lblExpiryDate.TabIndex = 27;
            lblExpiryDate.Text = "Hạn dùng:";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.CustomFormat = "dd/MM/yyyy";
            dtpExpiryDate.Font = new Font("Segoe UI", 10F);
            dtpExpiryDate.Format = DateTimePickerFormat.Custom;
            dtpExpiryDate.Location = new Point(801, 313);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpExpiryDate.Size = new Size(176, 34);
            dtpExpiryDate.TabIndex = 28;
            // 
            // btAddDetail
            // 
            btAddDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btAddDetail.BackColor = Color.Salmon;
            btAddDetail.FlatAppearance.BorderSize = 0;
            btAddDetail.FlatStyle = FlatStyle.Flat;
            btAddDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddDetail.ForeColor = Color.White;
            btAddDetail.Location = new Point(1110, 313);
            btAddDetail.Name = "btAddDetail";
            btAddDetail.Size = new Size(135, 39);
            btAddDetail.TabIndex = 29;
            btAddDetail.Text = "➕ Thêm Lô";
            btAddDetail.UseVisualStyleBackColor = false;
            btAddDetail.Click += btAddDetail_Click;
            // 
            // dgvImportDetails
            // 
            dgvImportDetails.AllowUserToAddRows = false;
            dgvImportDetails.AllowUserToDeleteRows = false;
            dgvImportDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvImportDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImportDetails.BackgroundColor = Color.LightBlue;
            dgvImportDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvImportDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportDetails.Columns.AddRange(new DataGridViewColumn[] { colProductName, colBatchNumber, colExpiryDate, colOriginalQuantity, colImportUnitPrice, colTotalAmount, colLotStatus, colDelete });
            dgvImportDetails.Location = new Point(20, 416);
            dgvImportDetails.Name = "dgvImportDetails";
            dgvImportDetails.ReadOnly = true;
            dgvImportDetails.RowHeadersVisible = false;
            dgvImportDetails.RowHeadersWidth = 62;
            dgvImportDetails.Size = new Size(1218, 160);
            dgvImportDetails.TabIndex = 30;
            dgvImportDetails.CellContentClick += dgvImportDetails_CellContentClick;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "DisplayProductName";
            colProductName.HeaderText = "Tên Thuốc / Sản Phẩm";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colBatchNumber
            // 
            colBatchNumber.DataPropertyName = "BatchNumber";
            colBatchNumber.HeaderText = "Số Lô";
            colBatchNumber.MinimumWidth = 8;
            colBatchNumber.Name = "colBatchNumber";
            colBatchNumber.ReadOnly = true;
            // 
            // colExpiryDate
            // 
            colExpiryDate.DataPropertyName = "ExpiryDate";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            colExpiryDate.DefaultCellStyle = dataGridViewCellStyle3;
            colExpiryDate.HeaderText = "Hạn Sử Dụng";
            colExpiryDate.MinimumWidth = 8;
            colExpiryDate.Name = "colExpiryDate";
            colExpiryDate.ReadOnly = true;
            // 
            // colOriginalQuantity
            // 
            colOriginalQuantity.DataPropertyName = "InputQuantity";
            colOriginalQuantity.HeaderText = "Số Lượng";
            colOriginalQuantity.MinimumWidth = 8;
            colOriginalQuantity.Name = "colOriginalQuantity";
            colOriginalQuantity.ReadOnly = true;
            // 
            // colImportUnitPrice
            // 
            colImportUnitPrice.DataPropertyName = "InputPrice";
            dataGridViewCellStyle4.Format = "N0";
            colImportUnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            colImportUnitPrice.HeaderText = "Giá Nhập";
            colImportUnitPrice.MinimumWidth = 8;
            colImportUnitPrice.Name = "colImportUnitPrice";
            colImportUnitPrice.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle5.Format = "N0";
            colTotalAmount.DefaultCellStyle = dataGridViewCellStyle5;
            colTotalAmount.HeaderText = "Thành Tiền";
            colTotalAmount.MinimumWidth = 8;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colLotStatus
            // 
            colLotStatus.DataPropertyName = "LotStatusDisplay";
            colLotStatus.HeaderText = "Trạng Thái Lô";
            colLotStatus.MinimumWidth = 8;
            colLotStatus.Name = "colLotStatus";
            colLotStatus.ReadOnly = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Xóa";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Xóa";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // colConversionRatio
            // 
            colConversionRatio.MinimumWidth = 8;
            colConversionRatio.Name = "colConversionRatio";
            colConversionRatio.Width = 150;
            // 
            // colProductId
            // 
            colProductId.MinimumWidth = 8;
            colProductId.Name = "colProductId";
            colProductId.Width = 150;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(lblTotal);
            pnlButtons.Controls.Add(txtTotalAmount);
            pnlButtons.Controls.Add(btSave);
            pnlButtons.Controls.Add(btClose);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 566);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1258, 50);
            pnlButtons.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(15, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(140, 28);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Tổng số tiền: ";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTotalAmount.Location = new Point(161, 10);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(160, 34);
            txtTotalAmount.TabIndex = 1;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSave.BackColor = Color.MidnightBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(1006, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(100, 34);
            btSave.TabIndex = 2;
            btSave.Text = "💾 LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.BackColor = Color.LightGray;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btClose.ForeColor = Color.Black;
            btClose.Location = new Point(1126, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(105, 34);
            btClose.TabIndex = 3;
            btClose.Text = "✖ HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // frmNewImport
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTitleSub);
            Font = new Font("Segoe UI", 10F);
            Name = "frmNewImport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lập phiếu nhập kho dược mới";
            WindowState = FormWindowState.Maximized;
            Load += frmNewImport_Load;
            pnlTitleSub.ResumeLayout(false);
            pnlTitleSub.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWholesalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWholesaleQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvImportDetails).EndInit();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTitleSub;
        private Label lblFormTitleSub;
        private Panel pnlContent;
        private Panel pnlButtons;

        private Label lblImportCode;
        private TextBox txtImportCode;
        private Label lblSupplier;
        private ComboBox cboSupplier;
        private Label lblImportDate;
        private DateTimePicker dtpImportDate;
        private Label lblCreatedBy;
        private TextBox txtCreatedBy;
        private Label lblProduct;
        private ComboBox cboProduct;
        private Label lblStatus;
        private ComboBox cboStatus;

        private Label lblSection1;
        private DataGridView dgvProductUnits;
        private DataGridViewTextBoxColumn colUnitName;
        private DataGridViewTextBoxColumn colConversionRate;
        private DataGridViewTextBoxColumn colImportPrice;
        private Label lblProductImage;
        private PictureBox picProductImage;

        private Label lblSection2;
        private Label lblWholesaleUnit;
        private ComboBox cboWholesaleUnit;
        private Label lblWholesalePrice;
        private NumericUpDown nudWholesalePrice;
        private Label lblWholesaleQty;
        private NumericUpDown nudWholesaleQty;
        private Label lblBatchNumber;
        private TextBox txtBatchNumber;
        private Label lblExpiryDate;
        private DateTimePicker dtpExpiryDate;
        private Button btAddDetail;

        private DataGridView dgvImportDetails;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colBatchNumber;
        private DataGridViewTextBoxColumn colExpiryDate;
        private DataGridViewTextBoxColumn colConversionRatio;
        private DataGridViewTextBoxColumn colOriginalQuantity;
        private DataGridViewTextBoxColumn colImportUnitPrice;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colLotStatus;
        private DataGridViewButtonColumn colDelete;

        private Label lblTotal;
        private TextBox txtTotalAmount;
        private Button btSave;
        private Button btClose;
    }
}