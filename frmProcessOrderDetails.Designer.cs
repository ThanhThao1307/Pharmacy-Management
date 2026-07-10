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
            cbOrders = new ComboBox();
            lblOrderCode = new Label();
            txtOrderCode = new TextBox();
            lblOrderDate = new Label();
            txtOrderDate = new TextBox();
            lblCustomer = new Label();
            cbCustomer = new ComboBox();
            lblEmployee = new Label();
            txtEmployeeName = new TextBox();
            lblPrescription = new Label();
            txtPrescription = new TextBox();
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
            pnlTop.Size = new Size(1000, 60);
            pnlTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(501, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "XỬ LÝ ĐƠN HÀNG VÀ CHI TIẾT (ĐA XỬ LÝ)";
            // 
            // gbOrder
            // 
            gbOrder.BackColor = Color.LightBlue;
            gbOrder.Controls.Add(lblSelectOrder);
            gbOrder.Controls.Add(lblTotal);
            gbOrder.Controls.Add(txtTotalAmount);
            gbOrder.Controls.Add(cbOrders);
            gbOrder.Controls.Add(lblOrderCode);
            gbOrder.Controls.Add(txtOrderCode);
            gbOrder.Controls.Add(lblOrderDate);
            gbOrder.Controls.Add(txtOrderDate);
            gbOrder.Controls.Add(lblCustomer);
            gbOrder.Controls.Add(cbCustomer);
            gbOrder.Controls.Add(lblEmployee);
            gbOrder.Controls.Add(txtEmployeeName);
            gbOrder.Controls.Add(lblPrescription);
            gbOrder.Controls.Add(txtPrescription);
            gbOrder.Controls.Add(btViewPrescription);
            gbOrder.Dock = DockStyle.Top;
            gbOrder.Location = new Point(0, 60);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(1000, 197);
            gbOrder.TabIndex = 2;
            gbOrder.TabStop = false;
            gbOrder.Text = "Thông tin Đơn Hàng (Đã chốt cố định)";
            // 
            // lblSelectOrder
            // 
            lblSelectOrder.AutoSize = true;
            lblSelectOrder.Location = new Point(10, 36);
            lblSelectOrder.Name = "lblSelectOrder";
            lblSelectOrder.Size = new Size(155, 28);
            lblSelectOrder.TabIndex = 0;
            lblSelectOrder.Text = "Chọn HĐ có sẵn:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkRed;
            lblTotal.Location = new Point(10, 159);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(108, 28);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Tổng tiền:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTotalAmount.ForeColor = Color.DarkRed;
            txtTotalAmount.Location = new Point(171, 157);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(200, 34);
            txtTotalAmount.TabIndex = 16;
            txtTotalAmount.Text = "0";
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // cbOrders
            // 
            cbOrders.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrders.Location = new Point(171, 33);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(180, 36);
            cbOrders.TabIndex = 1;
            cbOrders.SelectionChangeCommitted += cbOrders_SelectionChangeCommitted;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Location = new Point(357, 36);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(77, 28);
            lblOrderCode.TabIndex = 3;
            lblOrderCode.Text = "Mã HĐ:";
            // 
            // txtOrderCode
            // 
            txtOrderCode.BorderStyle = BorderStyle.FixedSingle;
            txtOrderCode.Location = new Point(467, 32);
            txtOrderCode.Name = "txtOrderCode";
            txtOrderCode.ReadOnly = true;
            txtOrderCode.Size = new Size(183, 34);
            txtOrderCode.TabIndex = 4;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(656, 34);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(95, 28);
            lblOrderDate.TabIndex = 5;
            lblOrderDate.Text = "Ngày lập:";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BorderStyle = BorderStyle.FixedSingle;
            txtOrderDate.Location = new Point(757, 34);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(213, 34);
            txtOrderDate.TabIndex = 6;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(10, 78);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(121, 28);
            lblCustomer.TabIndex = 7;
            lblCustomer.Text = "Khách Hàng:";
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.Enabled = false;
            cbCustomer.Location = new Point(171, 75);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(180, 36);
            cbCustomer.TabIndex = 8;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(357, 78);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(104, 28);
            lblEmployee.TabIndex = 9;
            lblEmployee.Text = "Người lập:";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            txtEmployeeName.Location = new Point(467, 75);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(183, 34);
            txtEmployeeName.TabIndex = 10;
            // 
            // lblPrescription
            // 
            lblPrescription.AutoSize = true;
            lblPrescription.Location = new Point(10, 120);
            lblPrescription.Name = "lblPrescription";
            lblPrescription.Size = new Size(155, 28);
            lblPrescription.TabIndex = 11;
            lblPrescription.Text = "Hồ sơ Toa (GPP):";
            // 
            // txtPrescription
            // 
            txtPrescription.BorderStyle = BorderStyle.FixedSingle;
            txtPrescription.Location = new Point(171, 117);
            txtPrescription.Name = "txtPrescription";
            txtPrescription.ReadOnly = true;
            txtPrescription.Size = new Size(580, 34);
            txtPrescription.TabIndex = 12;
            // 
            // btViewPrescription
            // 
            btViewPrescription.BackColor = Color.DarkSlateBlue;
            btViewPrescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btViewPrescription.ForeColor = Color.White;
            btViewPrescription.Location = new Point(765, 116);
            btViewPrescription.Name = "btViewPrescription";
            btViewPrescription.Size = new Size(205, 37);
            btViewPrescription.TabIndex = 17;
            btViewPrescription.Text = "Toa thuốc (GPP)";
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
            dgvOrderDetails.Location = new Point(0, 257);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowHeadersWidth = 62;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(1000, 323);
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
            colProductName.DataPropertyName = "Name";
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
            gbDetail.Location = new Point(0, 580);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(1000, 120);
            gbDetail.TabIndex = 1;
            gbDetail.TabStop = false;
            gbDetail.Text = "Nhập / Sửa chi tiết đơn hàng";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(10, 33);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(103, 28);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Sản phẩm:";
            // 
            // cbProducts
            // 
            cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducts.Location = new Point(119, 30);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(200, 36);
            cbProducts.TabIndex = 1;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(325, 33);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(96, 28);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng:";
            // 
            // mQuantity
            // 
            mQuantity.BorderStyle = BorderStyle.FixedSingle;
            mQuantity.Location = new Point(427, 31);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(112, 34);
            mQuantity.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(545, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(85, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Đơn giá:";
            // 
            // mPrice
            // 
            mPrice.BorderStyle = BorderStyle.FixedSingle;
            mPrice.Location = new Point(636, 31);
            mPrice.Name = "mPrice";
            mPrice.ReadOnly = true;
            mPrice.Size = new Size(120, 34);
            mPrice.TabIndex = 5;
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.BackColor = Color.Tomato;
            btAddOrderDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddOrderDetail.ForeColor = Color.FloralWhite;
            btAddOrderDetail.Location = new Point(690, 70);
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
            btSaveOrderDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSaveOrderDetail.ForeColor = Color.FloralWhite;
            btSaveOrderDetail.Location = new Point(854, 70);
            btSaveOrderDetail.Name = "btSaveOrderDetail";
            btSaveOrderDetail.Size = new Size(131, 39);
            btSaveOrderDetail.TabIndex = 7;
            btSaveOrderDetail.Text = "CẬP NHẬT";
            btSaveOrderDetail.UseVisualStyleBackColor = false;
            btSaveOrderDetail.Click += btSaveOrderDetail_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.ForeColor = Color.Black;
            btClose.Location = new Point(865, 28);
            btClose.Name = "btClose";
            btClose.Size = new Size(120, 39);
            btClose.TabIndex = 9;
            btClose.Text = "❌ ĐÓNG";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // lblProductImageTitle
            // 
            lblProductImageTitle.AutoSize = true;
            lblProductImageTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProductImageTitle.ForeColor = Color.Navy;
            lblProductImageTitle.Location = new Point(10, 76);
            lblProductImageTitle.Name = "lblProductImageTitle";
            lblProductImageTitle.Size = new Size(149, 25);
            lblProductImageTitle.TabIndex = 10;
            lblProductImageTitle.Text = "Hình ảnh thuốc:";
            // 
            // picProductImage
            // 
            picProductImage.BackColor = Color.White;
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(165, 72);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(269, 48);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 11;
            picProductImage.TabStop = false;
            // 
            // frmProcessOrderDetails
            // 
            ClientSize = new Size(1000, 700);
            Controls.Add(dgvOrderDetails);
            Controls.Add(gbDetail);
            Controls.Add(gbOrder);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProcessOrderDetails";
            Text = "Xử lý chi tiết đơn hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmProcessOrderDetails_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
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
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.TextBox txtPrescription;
        private System.Windows.Forms.Button btViewPrescription;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalAmount;
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
