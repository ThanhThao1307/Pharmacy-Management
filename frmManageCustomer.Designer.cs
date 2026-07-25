namespace Pharmacy_Nhom1
{
    partial class frmManageCustomer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSearchName = new Label();
            btSearch = new Button();
            txtSearch = new TextBox();
            pnlFooter = new Panel();
            btNew = new Button();
            dgvCustomers = new DataGridView();
            colCustomerId = new DataGridViewTextBoxColumn();
            colCustomerCode = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colBirthDate = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colTotalSpent = new DataGridViewTextBoxColumn();
            colLoyaltyPoints = new DataGridViewTextBoxColumn();
            colCustomerGroup = new DataGridViewTextBoxColumn();
            colIsActive = new DataGridViewCheckBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSearchName);
            pnlHeader.Controls.Add(btSearch);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1258, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchName.ForeColor = Color.White;
            lblSearchName.Location = new Point(364, 14);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(259, 32);
            lblSearchName.TabIndex = 0;
            lblSearchName.Text = "Họ tên / SĐT tìm kiếm:";
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSearch.BackColor = Color.Navy;
            btSearch.FlatAppearance.BorderSize = 0;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = Color.FloralWhite;
            btSearch.Location = new Point(1086, 13);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(146, 36);
            btSearch.TabIndex = 1;
            btSearch.Text = "🔍 Tìm kiếm";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(629, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(438, 34);
            txtSearch.TabIndex = 0;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.CadetBlue;
            pnlFooter.Controls.Add(btNew);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlFooter.Location = new Point(0, 566);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1258, 50);
            pnlFooter.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.BackColor = Color.Tomato;
            btNew.FlatAppearance.BorderSize = 0;
            btNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNew.ForeColor = Color.FloralWhite;
            btNew.Location = new Point(1072, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(160, 41);
            btNew.TabIndex = 0;
            btNew.Text = "➕ THÊM MỚI";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToOrderColumns = true;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.LightBlue;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.ColumnHeadersHeight = 36;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustomerId, colCustomerCode, colFullName, colGender, colBirthDate, colPhone, colEmail, colAddress, colCreatedDate, colTotalSpent, colLoyaltyPoints, colCustomerGroup, colIsActive, colEdit, colDelete });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 60);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1258, 506);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // colCustomerId
            // 
            colCustomerId.DataPropertyName = "CustomerId";
            colCustomerId.HeaderText = "Mã số";
            colCustomerId.MinimumWidth = 8;
            colCustomerId.Name = "colCustomerId";
            colCustomerId.ReadOnly = true;
            colCustomerId.Visible = false;
            // 
            // colCustomerCode
            // 
            colCustomerCode.DataPropertyName = "CustomerCode";
            colCustomerCode.HeaderText = "Mã KH";
            colCustomerCode.MinimumWidth = 8;
            colCustomerCode.Name = "colCustomerCode";
            colCustomerCode.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Họ và tên";
            colFullName.MinimumWidth = 8;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "GenderText";
            colGender.HeaderText = "Giới tính";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // colBirthDate
            // 
            colBirthDate.DataPropertyName = "BirthDateText";
            colBirthDate.HeaderText = "Ngày sinh";
            colBirthDate.MinimumWidth = 8;
            colBirthDate.Name = "colBirthDate";
            colBirthDate.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Số điện thoại";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Địa chỉ";
            colAddress.MinimumWidth = 8;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colCreatedDate
            // 
            colCreatedDate.DataPropertyName = "CreatedDateText";
            colCreatedDate.HeaderText = "Ngày tạo";
            colCreatedDate.MinimumWidth = 8;
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.ReadOnly = true;
            // 
            // colTotalSpent
            // 
            colTotalSpent.DataPropertyName = "TotalSpent";
            colTotalSpent.HeaderText = "Tổng chi tiêu";
            colTotalSpent.MinimumWidth = 8;
            colTotalSpent.Name = "colTotalSpent";
            colTotalSpent.ReadOnly = true;
            // 
            // colLoyaltyPoints
            // 
            colLoyaltyPoints.DataPropertyName = "LoyaltyPoints";
            colLoyaltyPoints.HeaderText = "Điểm tích lũy";
            colLoyaltyPoints.MinimumWidth = 8;
            colLoyaltyPoints.Name = "colLoyaltyPoints";
            colLoyaltyPoints.ReadOnly = true;
            // 
            // colCustomerGroup
            // 
            colCustomerGroup.DataPropertyName = "CustomerGroup";
            colCustomerGroup.HeaderText = "Nhóm KH";
            colCustomerGroup.MinimumWidth = 8;
            colCustomerGroup.Name = "colCustomerGroup";
            colCustomerGroup.ReadOnly = true;
            // 
            // colIsActive
            // 
            colIsActive.DataPropertyName = "IsActive";
            colIsActive.HeaderText = "Hoạt động";
            colIsActive.MinimumWidth = 8;
            colIsActive.Name = "colIsActive";
            colIsActive.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Sửa";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Sửa";
            colEdit.UseColumnTextForButtonValue = true;
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
            // frmManageCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(dgvCustomers);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Name = "frmManageCustomer";
            Text = "Quản Lý Khách Hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmManageCustomer_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtSearch;
        private Button btSearch;
        private Label lblSearchName;
        private DataGridView dgvCustomers;
        private Panel pnlFooter;
        private Button btNew;
        private DataGridViewTextBoxColumn colCustomerId;
        private DataGridViewTextBoxColumn colCustomerCode;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colCreatedDate;
        private DataGridViewTextBoxColumn colTotalSpent;
        private DataGridViewTextBoxColumn colLoyaltyPoints;
        private DataGridViewTextBoxColumn colCustomerGroup;
        private DataGridViewCheckBoxColumn colIsActive;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
