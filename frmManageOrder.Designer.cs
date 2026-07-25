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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlFilter = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
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
            pnlTop.Size = new Size(1258, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(455, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH SÁCH HÓA ĐƠN";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.LightBlue;
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(txtSearch);
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
            pnlFilter.Size = new Size(1258, 110);
            pnlFilter.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(15, 68);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 32);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Từ khóa:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(126, 68);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã hóa đơn, tên/số điện thoại khách hàng hoặc người lập để tìm kiếm...";
            txtSearch.Size = new Size(954, 34);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblNumOfOrder
            // 
            lblNumOfOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumOfOrder.AutoSize = true;
            lblNumOfOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOfOrder.ForeColor = Color.DarkRed;
            lblNumOfOrder.Location = new Point(1067, 20);
            lblNumOfOrder.Name = "lblNumOfOrder";
            lblNumOfOrder.Size = new Size(171, 32);
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
            btFind.Location = new Point(743, 18);
            btFind.Name = "btFind";
            btFind.Size = new Size(142, 38);
            btFind.TabIndex = 6;
            btFind.Text = "🔍 Tìm kiếm";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(547, 18);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(174, 34);
            dtpOrderDate.TabIndex = 5;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.Black;
            lblOrderDate.Location = new Point(427, 20);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(114, 32);
            lblOrderDate.TabIndex = 4;
            lblOrderDate.Text = "Ngày lập:";
            // 
            // cbMonth
            // 
            cbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(309, 20);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(110, 36);
            cbMonth.TabIndex = 3;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.Black;
            lblMonth.Location = new Point(217, 20);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(86, 32);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "Tháng:";
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(91, 20);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(110, 36);
            cbYear.TabIndex = 1;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYear.ForeColor = Color.Black;
            lblYear.Location = new Point(15, 20);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(70, 32);
            lblYear.TabIndex = 0;
            lblYear.Text = "Năm:";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btNew);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 566);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1258, 50);
            pnlButtons.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.BackColor = Color.Tomato;
            btNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNew.ForeColor = Color.FloralWhite;
            btNew.Location = new Point(1038, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(200, 41);
            btNew.TabIndex = 0;
            btNew.Text = "➕ LẬP HÓA ĐƠN MỚI";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToOrderColumns = true;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.LightBlue;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeight = 34;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colOrderCode, colOrderDate, colCustomerName, colUserName, colTotalAmount, colDiscount, colNetAmount, colStatusText, colDetail, colPrint, colDelete });
            dgvOrders.Location = new Point(0, 170);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1258, 396);
            dgvOrders.TabIndex = 3;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // colOrderId
            // 
            colOrderId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colOrderId.DataPropertyName = "OrderId";
            colOrderId.HeaderText = "Mã số";
            colOrderId.MinimumWidth = 8;
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            colOrderId.Visible = false;
            colOrderId.Width = 150;
            // 
            // colOrderCode
            // 
            colOrderCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colOrderCode.DataPropertyName = "OrderCode";
            colOrderCode.HeaderText = "Mã hóa đơn";
            colOrderCode.MinimumWidth = 8;
            colOrderCode.Name = "colOrderCode";
            colOrderCode.ReadOnly = true;
            colOrderCode.Width = 154;
            // 
            // colOrderDate
            // 
            colOrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colOrderDate.DataPropertyName = "OrderDate";
            colOrderDate.HeaderText = "Ngày lập";
            colOrderDate.MinimumWidth = 8;
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            colOrderDate.Width = 127;
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
            colDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDetail.HeaderText = "Chi tiết";
            colDetail.MinimumWidth = 8;
            colDetail.Name = "colDetail";
            colDetail.ReadOnly = true;
            colDetail.Text = "📋 Chi tiết";
            colDetail.UseColumnTextForButtonValue = true;
            colDetail.Width = 80;
            // 
            // colPrint
            // 
            colPrint.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrint.HeaderText = "In";
            colPrint.MinimumWidth = 8;
            colPrint.Name = "colPrint";
            colPrint.ReadOnly = true;
            colPrint.Text = "🖨️ In";
            colPrint.UseColumnTextForButtonValue = true;
            colPrint.Width = 34;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDelete.HeaderText = "Xóa";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "❌ Xóa";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 52;
            // 
            // frmManageOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(dgvOrders);
            Controls.Add(pnlButtons);
            Controls.Add(pnlFilter);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmManageOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh sách hóa đơn bán hàng";
            WindowState = FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
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
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colOrderCode;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colDiscount;
        private DataGridViewTextBoxColumn colNetAmount;
        private DataGridViewTextBoxColumn colStatusText;
        private DataGridViewButtonColumn colDetail;
        private DataGridViewButtonColumn colPrint;
        private DataGridViewButtonColumn colDelete;
    }
}
