namespace Pharmacy_Nhom1
{
    partial class frmManageOrder
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
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlFilter = new Panel();
            lblNumOfOrder = new Label();
            btFind = new Button();
            dtpOrderDate = new DateTimePicker();
            lblOrderDate = new Label();
            cbMonth = new ComboBox();
            lblMonth = new Label();
            cbYear = new ComboBox();
            lblYear = new Label();
            pnlButtons = new Panel();
            btNew = new Button();
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colOrderCode = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colDiscount = new DataGridViewTextBoxColumn();
            colNetAmount = new DataGridViewTextBoxColumn();
            colStatusText = new DataGridViewTextBoxColumn();
            colDetail = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            colPrint = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlTop.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.SteelBlue;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1100, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(365, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH SÁCH HÓA ĐƠN";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.LightCyan;
            pnlFilter.Controls.Add(lblNumOfOrder);
            pnlFilter.Controls.Add(btFind);
            pnlFilter.Controls.Add(dtpOrderDate);
            pnlFilter.Controls.Add(lblOrderDate);
            pnlFilter.Controls.Add(cbMonth);
            pnlFilter.Controls.Add(lblMonth);
            pnlFilter.Controls.Add(cbYear);
            pnlFilter.Controls.Add(lblYear);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 60);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1100, 65);
            pnlFilter.TabIndex = 1;
            // 
            // lblNumOfOrder
            // 
            lblNumOfOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumOfOrder.AutoSize = true;
            lblNumOfOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOfOrder.ForeColor = Color.DarkRed;
            lblNumOfOrder.Location = new Point(880, 18);
            lblNumOfOrder.Name = "lblNumOfOrder";
            lblNumOfOrder.Size = new Size(143, 28);
            lblNumOfOrder.TabIndex = 7;
            lblNumOfOrder.Text = "Số hóa đơn: 0";
            // 
            // btFind
            // 
            btFind.BackColor = Color.Navy;
            btFind.FlatAppearance.BorderSize = 0;
            btFind.FlatStyle = FlatStyle.Flat;
            btFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btFind.ForeColor = Color.FloralWhite;
            btFind.Location = new Point(707, 13);
            btFind.Name = "btFind";
            btFind.Size = new Size(130, 38);
            btFind.TabIndex = 6;
            btFind.Text = "🔍 Tìm";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(513, 17);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(174, 34);
            dtpOrderDate.TabIndex = 5;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(412, 18);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(95, 28);
            lblOrderDate.TabIndex = 4;
            lblOrderDate.Text = "Ngày lập:";
            // 
            // cbMonth
            // 
            cbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(284, 15);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(110, 36);
            cbMonth.TabIndex = 3;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(208, 18);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(70, 28);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "Tháng:";
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(79, 15);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(110, 36);
            cbYear.TabIndex = 1;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(15, 18);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(58, 28);
            lblYear.TabIndex = 0;
            lblYear.Text = "Năm:";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btNew);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 530);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1100, 50);
            pnlButtons.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.BackColor = Color.Tomato;
            btNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNew.ForeColor = Color.FloralWhite;
            btNew.Location = new Point(880, 6);
            btNew.Name = "btNew";
            btNew.Size = new Size(200, 39);
            btNew.TabIndex = 0;
            btNew.Text = "➕  LẬP HÓA ĐƠN MỚI";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToOrderColumns = true;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.LightBlue;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeight = 34;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colOrderCode, colOrderDate, colCustomerName, colUserName, colTotalAmount, colDiscount, colNetAmount, colStatusText, colDetail, colEdit, colPrint, colDelete });
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 125);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1100, 405);
            dgvOrders.TabIndex = 3;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // colOrderId
            // 
            colOrderId.DataPropertyName = "OrderId";
            colOrderId.HeaderText = "Mã số";
            colOrderId.MinimumWidth = 8;
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            colOrderId.Visible = false;
            // 
            // colOrderCode
            // 
            colOrderCode.DataPropertyName = "OrderCode";
            colOrderCode.HeaderText = "Mã hóa đơn";
            colOrderCode.MinimumWidth = 8;
            colOrderCode.Name = "colOrderCode";
            colOrderCode.ReadOnly = true;
            // 
            // colOrderDate
            // 
            colOrderDate.DataPropertyName = "OrderDate";
            colOrderDate.HeaderText = "Ngày lập";
            colOrderDate.MinimumWidth = 8;
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.DataPropertyName = "CustomerName";
            colCustomerName.HeaderText = "Khách hàng";
            colCustomerName.MinimumWidth = 8;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colUserName
            // 
            colUserName.DataPropertyName = "UserName";
            colUserName.HeaderText = "Nhân viên lập";
            colUserName.MinimumWidth = 8;
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            colTotalAmount.HeaderText = "Tổng tiền";
            colTotalAmount.MinimumWidth = 8;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colDiscount
            // 
            colDiscount.DataPropertyName = "Discount";
            colDiscount.HeaderText = "Giảm giá";
            colDiscount.MinimumWidth = 8;
            colDiscount.Name = "colDiscount";
            colDiscount.ReadOnly = true;
            // 
            // colNetAmount
            // 
            colNetAmount.DataPropertyName = "NetAmount";
            colNetAmount.HeaderText = "Thành tiền";
            colNetAmount.MinimumWidth = 8;
            colNetAmount.Name = "colNetAmount";
            colNetAmount.ReadOnly = true;
            // 
            // colStatusText
            // 
            colStatusText.DataPropertyName = "StatusText";
            colStatusText.HeaderText = "Trạng thái";
            colStatusText.MinimumWidth = 8;
            colStatusText.Name = "colStatusText";
            colStatusText.ReadOnly = true;
            // 
            // colDetail
            // 
            colDetail.HeaderText = "Chi tiết";
            colDetail.MinimumWidth = 8;
            colDetail.Name = "colDetail";
            colDetail.ReadOnly = true;
            colDetail.Text = "📋 Chi tiết";
            colDetail.UseColumnTextForButtonValue = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Sửa";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "✏️ Sửa";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colPrint
            // 
            colPrint.HeaderText = "In";
            colPrint.MinimumWidth = 8;
            colPrint.Name = "colPrint";
            colPrint.ReadOnly = true;
            colPrint.Text = "🖨️ In";
            colPrint.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Xóa";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "❌ Xóa";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // frmManageOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 580);
            Controls.Add(dgvOrders);
            Controls.Add(pnlButtons);
            Controls.Add(pnlFilter);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmManageOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh sách hóa đơn bán hàng";
            Load += frmManageOrder_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label lblNumOfOrder;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusText;
        private System.Windows.Forms.DataGridViewButtonColumn colDetail;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colPrint;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
