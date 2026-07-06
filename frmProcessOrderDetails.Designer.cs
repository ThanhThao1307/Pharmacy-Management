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
            pnlTop = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            gbOrder = new System.Windows.Forms.GroupBox();
            lblSelectOrder = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            txtTotalAmount = new System.Windows.Forms.TextBox();
            cbOrders = new System.Windows.Forms.ComboBox();
            lblOrderCode = new System.Windows.Forms.Label();
            txtOrderCode = new System.Windows.Forms.TextBox();
            lblOrderDate = new System.Windows.Forms.Label();
            txtOrderDate = new System.Windows.Forms.TextBox();
            lblCustomer = new System.Windows.Forms.Label();
            cbCustomer = new System.Windows.Forms.ComboBox();
            lblEmployee = new System.Windows.Forms.Label();
            txtEmployeeName = new System.Windows.Forms.TextBox();
            lblPrescription = new System.Windows.Forms.Label();
            txtPrescription = new System.Windows.Forms.TextBox();
            btViewPrescription = new System.Windows.Forms.Button();
            dgvOrderDetails = new System.Windows.Forms.DataGridView();
            colOrderDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            gbDetail = new System.Windows.Forms.GroupBox();
            lblProduct = new System.Windows.Forms.Label();
            cbProducts = new System.Windows.Forms.ComboBox();
            lblQuantity = new System.Windows.Forms.Label();
            mQuantity = new System.Windows.Forms.MaskedTextBox();
            lblPrice = new System.Windows.Forms.Label();
            mPrice = new System.Windows.Forms.MaskedTextBox();
            btAddOrderDetail = new System.Windows.Forms.Button();
            btSaveOrderDetail = new System.Windows.Forms.Button();
            btClose = new System.Windows.Forms.Button();
            lblProductImageTitle = new System.Windows.Forms.Label();
            picProductImage = new System.Windows.Forms.PictureBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            pnlTop.SuspendLayout();
            gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(1000, 60);
            pnlTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(501, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "XỬ LÝ ĐƠN HÀNG VÀ CHI TIẾT (ĐA XỬ LÝ)";
            // 
            // gbOrder
            // 
            gbOrder.BackColor = System.Drawing.Color.LightBlue;
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
            gbOrder.Dock = System.Windows.Forms.DockStyle.Top;
            gbOrder.Location = new System.Drawing.Point(0, 60);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new System.Drawing.Size(1000, 197);
            gbOrder.TabIndex = 2;
            gbOrder.TabStop = false;
            gbOrder.Text = "Thông tin Đơn Hàng (Đã chốt cố định)";
            // 
            // lblSelectOrder
            // 
            lblSelectOrder.AutoSize = true;
            lblSelectOrder.Location = new System.Drawing.Point(10, 36);
            lblSelectOrder.Name = "lblSelectOrder";
            lblSelectOrder.Size = new System.Drawing.Size(155, 28);
            lblSelectOrder.TabIndex = 0;
            lblSelectOrder.Text = "Chọn HĐ có sẵn:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTotal.ForeColor = System.Drawing.Color.DarkRed;
            lblTotal.Location = new System.Drawing.Point(10, 159);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(108, 28);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Tổng tiền:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            txtTotalAmount.ForeColor = System.Drawing.Color.DarkRed;
            txtTotalAmount.Location = new System.Drawing.Point(171, 157);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new System.Drawing.Size(200, 34);
            txtTotalAmount.TabIndex = 16;
            txtTotalAmount.Text = "0";
            txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOrders
            // 
            cbOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbOrders.Location = new System.Drawing.Point(171, 33);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new System.Drawing.Size(180, 36);
            cbOrders.TabIndex = 1;
            cbOrders.SelectionChangeCommitted += cbOrders_SelectionChangeCommitted;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Location = new System.Drawing.Point(357, 36);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new System.Drawing.Size(77, 28);
            lblOrderCode.TabIndex = 3;
            lblOrderCode.Text = "Mã HĐ:";
            // 
            // txtOrderCode
            // 
            txtOrderCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtOrderCode.Location = new System.Drawing.Point(467, 32);
            txtOrderCode.Name = "txtOrderCode";
            txtOrderCode.ReadOnly = true;
            txtOrderCode.Size = new System.Drawing.Size(183, 34);
            txtOrderCode.TabIndex = 4;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new System.Drawing.Point(656, 34);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new System.Drawing.Size(95, 28);
            lblOrderDate.TabIndex = 5;
            lblOrderDate.Text = "Ngày lập:";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtOrderDate.Location = new System.Drawing.Point(757, 34);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new System.Drawing.Size(213, 34);
            txtOrderDate.TabIndex = 6;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new System.Drawing.Point(10, 78);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(121, 28);
            lblCustomer.TabIndex = 7;
            lblCustomer.Text = "Khách Hàng:";
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCustomer.Enabled = false;
            cbCustomer.Location = new System.Drawing.Point(171, 75);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new System.Drawing.Size(180, 36);
            cbCustomer.TabIndex = 8;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new System.Drawing.Point(357, 78);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new System.Drawing.Size(104, 28);
            lblEmployee.TabIndex = 9;
            lblEmployee.Text = "Người lập:";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmployeeName.Location = new System.Drawing.Point(467, 75);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new System.Drawing.Size(183, 34);
            txtEmployeeName.TabIndex = 10;
            // 
            // lblPrescription
            // 
            lblPrescription.AutoSize = true;
            lblPrescription.Location = new System.Drawing.Point(10, 120);
            lblPrescription.Name = "lblPrescription";
            lblPrescription.Size = new System.Drawing.Size(155, 28);
            lblPrescription.TabIndex = 11;
            lblPrescription.Text = "Hồ sơ Toa (GPP):";
            // 
            // txtPrescription
            // 
            txtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPrescription.Location = new System.Drawing.Point(171, 117);
            txtPrescription.Name = "txtPrescription";
            txtPrescription.ReadOnly = true;
            txtPrescription.Size = new System.Drawing.Size(580, 34);
            txtPrescription.TabIndex = 12;
            // 
            // btViewPrescription
            // 
            btViewPrescription.BackColor = System.Drawing.Color.DarkSlateBlue;
            btViewPrescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btViewPrescription.ForeColor = System.Drawing.Color.White;
            btViewPrescription.Location = new System.Drawing.Point(765, 116);
            btViewPrescription.Name = "btViewPrescription";
            btViewPrescription.Size = new System.Drawing.Size(205, 37);
            btViewPrescription.TabIndex = 17;
            btViewPrescription.Text = "Toa thuốc (GPP)";
            btViewPrescription.UseVisualStyleBackColor = false;
            btViewPrescription.Click += btViewPrescription_Click;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.BackgroundColor = System.Drawing.Color.LightBlue;
            dgvOrderDetails.ColumnHeadersHeight = 34;
            dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colOrderDetailId, colProductId, colProductName, colQuantity, colPrice, colAmount, colDelete });
            dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrderDetails.Location = new System.Drawing.Point(0, 257);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowHeadersWidth = 62;
            dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new System.Drawing.Size(1000, 323);
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
            gbDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbDetail.Location = new System.Drawing.Point(0, 580);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new System.Drawing.Size(1000, 120);
            gbDetail.TabIndex = 1;
            gbDetail.TabStop = false;
            gbDetail.Text = "Nhập / Sửa chi tiết đơn hàng";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new System.Drawing.Point(10, 33);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new System.Drawing.Size(103, 28);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Sản phẩm:";
            // 
            // cbProducts
            // 
            cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbProducts.Location = new System.Drawing.Point(119, 30);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new System.Drawing.Size(200, 36);
            cbProducts.TabIndex = 1;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(325, 33);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(96, 28);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng:";
            // 
            // mQuantity
            // 
            mQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mQuantity.Location = new System.Drawing.Point(427, 31);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new System.Drawing.Size(112, 34);
            mQuantity.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(545, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(85, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Đơn giá:";
            // 
            // mPrice
            // 
            mPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mPrice.Location = new System.Drawing.Point(636, 31);
            mPrice.Name = "mPrice";
            mPrice.ReadOnly = true;
            mPrice.Size = new System.Drawing.Size(120, 34);
            mPrice.TabIndex = 5;
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.BackColor = System.Drawing.Color.Tomato;
            btAddOrderDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btAddOrderDetail.ForeColor = System.Drawing.Color.FloralWhite;
            btAddOrderDetail.Location = new System.Drawing.Point(770, 70);
            btAddOrderDetail.Name = "btAddOrderDetail";
            btAddOrderDetail.Size = new System.Drawing.Size(95, 39);
            btAddOrderDetail.TabIndex = 6;
            btAddOrderDetail.Text = "Thêm";
            btAddOrderDetail.UseVisualStyleBackColor = false;
            btAddOrderDetail.Click += btAddOrderDetail_Click;
            // 
            // btSaveOrderDetail
            // 
            btSaveOrderDetail.BackColor = System.Drawing.Color.MidnightBlue;
            btSaveOrderDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btSaveOrderDetail.ForeColor = System.Drawing.Color.FloralWhite;
            btSaveOrderDetail.Location = new System.Drawing.Point(875, 70);
            btSaveOrderDetail.Name = "btSaveOrderDetail";
            btSaveOrderDetail.Size = new System.Drawing.Size(110, 39);
            btSaveOrderDetail.TabIndex = 7;
            btSaveOrderDetail.Text = "Cập nhật";
            btSaveOrderDetail.UseVisualStyleBackColor = false;
            btSaveOrderDetail.Click += btSaveOrderDetail_Click;
            // 
            // btClose
            // 
            btClose.BackColor = System.Drawing.Color.Silver;
            btClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btClose.ForeColor = System.Drawing.Color.Black;
            btClose.Location = new System.Drawing.Point(875, 28);
            btClose.Name = "btClose";
            btClose.Size = new System.Drawing.Size(110, 39);
            btClose.TabIndex = 9;
            btClose.Text = "❌ ĐÓNG";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // lblProductImageTitle
            // 
            lblProductImageTitle.AutoSize = true;
            lblProductImageTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblProductImageTitle.ForeColor = System.Drawing.Color.Navy;
            lblProductImageTitle.Location = new System.Drawing.Point(10, 76);
            lblProductImageTitle.Name = "lblProductImageTitle";
            lblProductImageTitle.Size = new System.Drawing.Size(149, 25);
            lblProductImageTitle.TabIndex = 10;
            lblProductImageTitle.Text = "Hình ảnh thuốc:";
            // 
            // picProductImage
            // 
            picProductImage.BackColor = System.Drawing.Color.White;
            picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picProductImage.Location = new System.Drawing.Point(165, 72);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new System.Drawing.Size(269, 48);
            picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 11;
            picProductImage.TabStop = false;
            // 
            // frmProcessOrderDetails
            // 
            ClientSize = new System.Drawing.Size(1000, 700);
            Controls.Add(dgvOrderDetails);
            Controls.Add(gbDetail);
            Controls.Add(gbOrder);
            Controls.Add(pnlTop);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmProcessOrderDetails";
            Text = "Xử lý chi tiết đơn hàng";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
