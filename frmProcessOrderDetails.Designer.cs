namespace Pharmacy_Nhom1
{
    partial class frmProcessOrderDetails
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTop = new Panel();
            lblTitle = new Label();
            gbOrder = new GroupBox();
            lblSelectOrder = new Label();
            lblTotal = new Label();
            txtTotalAmount = new TextBox();
            lblDiscount = new Label();
            nudDiscount = new NumericUpDown();
            lblNetAmount = new Label();
            txtNetAmount = new TextBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            cbOrders = new ComboBox();
            lblOrderCode = new Label();
            txtOrderCode = new TextBox();
            txtPrescription = new TextBox();
            lblPrescription = new Label();
            lblOrderDate = new Label();
            cbCustomer = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            lblCustomer = new Label();
            lblEmployee = new Label();
            txtEmployeeName = new TextBox();
            btViewPrescription = new Button();
            dgvOrderDetails = new DataGridView();
            colOrderDetailId = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            gbDetail = new GroupBox();
            lblProduct = new Label();
            cbProducts = new ComboBox();
            lblUnit = new Label();
            cbUnits = new ComboBox();
            lblQuantity = new Label();
            mQuantity = new MaskedTextBox();
            lblPrice = new Label();
            mPrice = new MaskedTextBox();
            btAddOrderDetail = new Button();
            btSaveOrderDetail = new Button();
            btClose = new Button();
            lblProductImageTitle = new Label();
            picProductImage = new PictureBox();
            toolTip1 = new ToolTip(components);
            pnlTop.SuspendLayout();
            gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.SteelBlue;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1258, 60);
            pnlTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(424, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "XỬ LÝ ĐƠN HÀNG VÀ CHI TIẾT";
            // 
            // gbOrder
            // 
            gbOrder.BackColor = Color.LightBlue;
            gbOrder.Controls.Add(lblSelectOrder);
            gbOrder.Controls.Add(lblTotal);
            gbOrder.Controls.Add(txtTotalAmount);
            gbOrder.Controls.Add(lblDiscount);
            gbOrder.Controls.Add(nudDiscount);
            gbOrder.Controls.Add(lblNetAmount);
            gbOrder.Controls.Add(txtNetAmount);
            gbOrder.Controls.Add(lblStatus);
            gbOrder.Controls.Add(cbStatus);
            gbOrder.Controls.Add(cbOrders);
            gbOrder.Controls.Add(lblOrderCode);
            gbOrder.Controls.Add(txtOrderCode);
            gbOrder.Controls.Add(txtPrescription);
            gbOrder.Controls.Add(lblPrescription);
            gbOrder.Controls.Add(lblOrderDate);
            gbOrder.Controls.Add(cbCustomer);
            gbOrder.Controls.Add(dtpOrderDate);
            gbOrder.Controls.Add(lblCustomer);
            gbOrder.Controls.Add(lblEmployee);
            gbOrder.Controls.Add(txtEmployeeName);
            gbOrder.Controls.Add(btViewPrescription);
            gbOrder.Dock = DockStyle.Top;
            gbOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbOrder.Location = new Point(0, 60);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(1258, 256);
            gbOrder.TabIndex = 2;
            gbOrder.TabStop = false;
            gbOrder.Text = "Thông tin Đơn Hàng (Đã chốt cố định)";
            // 
            // lblSelectOrder
            // 
            lblSelectOrder.AutoSize = true;
            lblSelectOrder.Location = new Point(26, 46);
            lblSelectOrder.Name = "lblSelectOrder";
            lblSelectOrder.Size = new Size(192, 32);
            lblSelectOrder.TabIndex = 0;
            lblSelectOrder.Text = "Chọn HĐ có sẵn:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.DarkRed;
            lblTotal.Location = new Point(827, 156);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(131, 32);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Tổng tiền:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = SystemColors.Window;
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI", 10F);
            txtTotalAmount.ForeColor = Color.DarkRed;
            txtTotalAmount.Location = new Point(975, 157);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(256, 34);
            txtTotalAmount.TabIndex = 16;
            txtTotalAmount.Text = "0";
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(827, 103);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(113, 32);
            lblDiscount.TabIndex = 18;
            lblDiscount.Text = "Giảm giá:";
            // 
            // nudDiscount
            // 
            nudDiscount.Font = new Font("Segoe UI", 10F);
            nudDiscount.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDiscount.Location = new Point(975, 104);
            nudDiscount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(256, 34);
            nudDiscount.TabIndex = 19;
            nudDiscount.TextAlign = HorizontalAlignment.Right;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // lblNetAmount
            // 
            lblNetAmount.AutoSize = true;
            lblNetAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetAmount.ForeColor = Color.DarkRed;
            lblNetAmount.Location = new Point(827, 208);
            lblNetAmount.Name = "lblNetAmount";
            lblNetAmount.Size = new Size(142, 32);
            lblNetAmount.TabIndex = 20;
            lblNetAmount.Text = "Thành tiền:";
            // 
            // txtNetAmount
            // 
            txtNetAmount.BackColor = SystemColors.Window;
            txtNetAmount.BorderStyle = BorderStyle.FixedSingle;
            txtNetAmount.Font = new Font("Segoe UI", 10F);
            txtNetAmount.ForeColor = Color.DarkRed;
            txtNetAmount.Location = new Point(975, 209);
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.ReadOnly = true;
            txtNetAmount.Size = new Size(256, 34);
            txtNetAmount.TabIndex = 21;
            txtNetAmount.Text = "0";
            txtNetAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(26, 208);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(125, 32);
            lblStatus.TabIndex = 22;
            lblStatus.Text = "Trạng thái:";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 10F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "0 - Đã thanh toán", "1 - Hủy" });
            cbStatus.Location = new Point(224, 208);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(267, 36);
            cbStatus.TabIndex = 23;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // cbOrders
            // 
            cbOrders.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrders.Font = new Font("Segoe UI", 10F);
            cbOrders.Location = new Point(224, 46);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(267, 36);
            cbOrders.TabIndex = 1;
            cbOrders.SelectionChangeCommitted += cbOrders_SelectionChangeCommitted;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Location = new Point(497, 46);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(94, 32);
            lblOrderCode.TabIndex = 3;
            lblOrderCode.Text = "Mã HĐ:";
            // 
            // txtOrderCode
            // 
            txtOrderCode.BackColor = SystemColors.Window;
            txtOrderCode.BorderStyle = BorderStyle.FixedSingle;
            txtOrderCode.Font = new Font("Segoe UI", 10F);
            txtOrderCode.Location = new Point(627, 47);
            txtOrderCode.Name = "txtOrderCode";
            txtOrderCode.ReadOnly = true;
            txtOrderCode.Size = new Size(183, 34);
            txtOrderCode.TabIndex = 4;
            // 
            // txtPrescription
            // 
            txtPrescription.BackColor = SystemColors.Window;
            txtPrescription.BorderStyle = BorderStyle.FixedSingle;
            txtPrescription.Font = new Font("Segoe UI", 10F);
            txtPrescription.Location = new Point(224, 157);
            txtPrescription.Name = "txtPrescription";
            txtPrescription.ReadOnly = true;
            txtPrescription.Size = new Size(395, 34);
            txtPrescription.TabIndex = 12;
            // 
            // lblPrescription
            // 
            lblPrescription.AutoSize = true;
            lblPrescription.Location = new Point(26, 156);
            lblPrescription.Name = "lblPrescription";
            lblPrescription.Size = new Size(188, 32);
            lblPrescription.TabIndex = 11;
            lblPrescription.Text = "Hồ sơ Toa (GPP):";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(827, 46);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(114, 32);
            lblOrderDate.TabIndex = 5;
            lblOrderDate.Text = "Ngày lập:";
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.Enabled = false;
            cbCustomer.Font = new Font("Segoe UI", 10F);
            cbCustomer.Location = new Point(224, 103);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(267, 36);
            cbCustomer.TabIndex = 8;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpOrderDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(975, 44);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(256, 34);
            dtpOrderDate.TabIndex = 6;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(26, 103);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(148, 32);
            lblCustomer.TabIndex = 7;
            lblCustomer.Text = "Khách Hàng:";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(497, 103);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(124, 32);
            lblEmployee.TabIndex = 9;
            lblEmployee.Text = "Người lập:";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = SystemColors.Window;
            txtEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            txtEmployeeName.Font = new Font("Segoe UI", 10F);
            txtEmployeeName.Location = new Point(627, 104);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(183, 34);
            txtEmployeeName.TabIndex = 10;
            // 
            // btViewPrescription
            // 
            btViewPrescription.BackColor = Color.MidnightBlue;
            btViewPrescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btViewPrescription.ForeColor = Color.FloralWhite;
            btViewPrescription.Location = new Point(642, 151);
            btViewPrescription.Name = "btViewPrescription";
            btViewPrescription.Size = new Size(168, 42);
            btViewPrescription.TabIndex = 17;
            btViewPrescription.Text = "TOA THUỐC";
            btViewPrescription.UseVisualStyleBackColor = false;
            btViewPrescription.Click += btViewPrescription_Click;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.BackgroundColor = Color.LightBlue;
            dgvOrderDetails.ColumnHeadersHeight = 34;
            dgvOrderDetails.Columns.AddRange(new DataGridViewColumn[] { colOrderDetailId, colProductId, colProductName, colQuantity, colPrice, colAmount, colDelete });
            dgvOrderDetails.Dock = DockStyle.Fill;
            dgvOrderDetails.Location = new Point(0, 316);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowHeadersWidth = 62;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(1258, 180);
            dgvOrderDetails.TabIndex = 0;
            dgvOrderDetails.CellClick += dgvOrderDetails_CellClick;
            dgvOrderDetails.CellContentClick += dgvOrderDetails_CellContentClick;
            // 
            // colOrderDetailId
            // 
            colOrderDetailId.DataPropertyName = "OrderDetailID";
            colOrderDetailId.MinimumWidth = 8;
            colOrderDetailId.Name = "colOrderDetailId";
            colOrderDetailId.Visible = false;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductID";
            colProductId.MinimumWidth = 8;
            colProductId.Name = "colProductId";
            colProductId.Visible = false;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "DisplayName";
            colProductName.HeaderText = "Tên Sản Phẩm";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Số Lượng";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Đơn Giá";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.DataPropertyName = "Amount";
            colAmount.HeaderText = "Thành Tiền";
            colAmount.MinimumWidth = 8;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Xóa";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Text = "Xóa";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(lblProduct);
            gbDetail.Controls.Add(cbProducts);
            gbDetail.Controls.Add(lblUnit);
            gbDetail.Controls.Add(cbUnits);
            gbDetail.Controls.Add(lblQuantity);
            gbDetail.Controls.Add(mQuantity);
            gbDetail.Controls.Add(lblPrice);
            gbDetail.Controls.Add(mPrice);
            gbDetail.Controls.Add(btAddOrderDetail);
            gbDetail.Controls.Add(btSaveOrderDetail);
            gbDetail.Controls.Add(btClose);
            gbDetail.Controls.Add(lblProductImageTitle);
            gbDetail.Controls.Add(picProductImage);
            gbDetail.Dock = DockStyle.Bottom;
            gbDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDetail.Location = new Point(0, 496);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(1258, 120);
            gbDetail.TabIndex = 1;
            gbDetail.TabStop = false;
            gbDetail.Text = "Nhập / Sửa chi tiết đơn hàng";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(16, 38);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(126, 32);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Sản phẩm:";
            // 
            // cbProducts
            // 
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.Font = new Font("Segoe UI", 10F);
            cbProducts.Location = new Point(140, 41);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(210, 36);
            cbProducts.TabIndex = 1;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(365, 38);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(86, 32);
            lblUnit.TabIndex = 12;
            lblUnit.Text = "Đơn vị:";
            // 
            // cbUnits
            // 
            cbUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnits.Font = new Font("Segoe UI", 10F);
            cbUnits.Location = new Point(455, 41);
            cbUnits.Name = "cbUnits";
            cbUnits.Size = new Size(185, 36);
            cbUnits.TabIndex = 13;
            cbUnits.SelectedIndexChanged += cbUnits_SelectedIndexChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(16, 79);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(115, 32);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng:";
            // 
            // mQuantity
            // 
            mQuantity.BorderStyle = BorderStyle.FixedSingle;
            mQuantity.Font = new Font("Segoe UI", 10F);
            mQuantity.Location = new Point(140, 83);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(210, 34);
            mQuantity.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(365, 79);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(115, 32);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Đơn giá:";
            // 
            // mPrice
            // 
            mPrice.BackColor = SystemColors.Window;
            mPrice.BorderStyle = BorderStyle.FixedSingle;
            mPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mPrice.Location = new Point(485, 83);
            mPrice.Name = "mPrice";
            mPrice.ReadOnly = true;
            mPrice.Size = new Size(155, 34);
            mPrice.TabIndex = 5;
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.BackColor = Color.Tomato;
            btAddOrderDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddOrderDetail.ForeColor = Color.FloralWhite;
            btAddOrderDetail.Location = new Point(1073, 69);
            btAddOrderDetail.Name = "btAddOrderDetail";
            btAddOrderDetail.Size = new Size(158, 39);
            btAddOrderDetail.TabIndex = 6;
            btAddOrderDetail.Text = "➕ THÊM MỚI";
            btAddOrderDetail.UseVisualStyleBackColor = false;
            btAddOrderDetail.Click += btAddOrderDetail_Click;
            // 
            // btSaveOrderDetail
            // 
            btSaveOrderDetail.BackColor = Color.MidnightBlue;
            btSaveOrderDetail.FlatAppearance.BorderSize = 0;
            btSaveOrderDetail.FlatStyle = FlatStyle.Flat;
            btSaveOrderDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSaveOrderDetail.ForeColor = Color.FloralWhite;
            btSaveOrderDetail.Location = new Point(1004, 10);
            btSaveOrderDetail.Name = "btSaveOrderDetail";
            btSaveOrderDetail.Size = new Size(105, 34);
            btSaveOrderDetail.TabIndex = 7;
            btSaveOrderDetail.Text = "💾 LƯU";
            btSaveOrderDetail.UseVisualStyleBackColor = false;
            btSaveOrderDetail.Click += btSaveOrderDetail_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = SystemColors.ControlText;
            btClose.Location = new Point(1126, 10);
            btClose.Name = "btClose";
            btClose.Size = new Size(105, 34);
            btClose.TabIndex = 9;
            btClose.Text = "❌ HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // lblProductImageTitle
            // 
            lblProductImageTitle.AutoSize = true;
            lblProductImageTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductImageTitle.ForeColor = Color.Navy;
            lblProductImageTitle.Location = new Point(660, 3);
            lblProductImageTitle.Name = "lblProductImageTitle";
            lblProductImageTitle.Size = new Size(196, 32);
            lblProductImageTitle.TabIndex = 10;
            lblProductImageTitle.Text = "Hình ảnh thuốc:";
            // 
            // picProductImage
            // 
            picProductImage.BackColor = Color.White;
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(660, 38);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(326, 76);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 11;
            picProductImage.TabStop = false;
            // 
            // frmProcessOrderDetails
            // 
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(dgvOrderDetails);
            Controls.Add(gbDetail);
            Controls.Add(gbOrder);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "frmProcessOrderDetails";
            Text = "Xử lý chi tiết đơn hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmProcessOrderDetails_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label lblSelectOrder;
        private System.Windows.Forms.ComboBox cbOrders;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.TextBox txtPrescription;
        private System.Windows.Forms.Button btViewPrescription;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cbUnits;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.MaskedTextBox mQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MaskedTextBox mPrice;
        private System.Windows.Forms.Button btAddOrderDetail;
        private System.Windows.Forms.Button btSaveOrderDetail;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label lblProductImageTitle;
    }
}
