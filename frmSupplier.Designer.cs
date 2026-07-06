namespace Pharmacy_Nhom1
{
    partial class frmSupplier
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
            pnlTop = new Panel();
            lblTitle = new Label();
            btSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlBottom = new Panel();
            btNew = new Button();
            dgvSuppliers = new DataGridView();
            SupplierId = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TaxCode = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.SteelBlue;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(btSearch);
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(lblSearch);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(880, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSearch.BackColor = Color.Navy;
            btSearch.FlatAppearance.BorderSize = 0;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = Color.FloralWhite;
            btSearch.Location = new Point(706, 13);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(147, 34);
            btSearch.TabIndex = 1;
            btSearch.Text = "🔍 Tìm kiếm";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(460, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 34);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.Transparent;
            lblSearch.Location = new Point(350, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(95, 28);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.CadetBlue;
            pnlBottom.Controls.Add(btNew);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 454);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(880, 50);
            pnlBottom.TabIndex = 1;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.BackColor = Color.Tomato;
            btNew.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNew.ForeColor = Color.FloralWhite;
            btNew.Location = new Point(691, 7);
            btNew.Name = "btNew";
            btNew.Size = new Size(162, 38);
            btNew.TabIndex = 2;
            btNew.Text = "➕ THÊM MỚI";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.LightBlue;
            dgvSuppliers.BorderStyle = BorderStyle.None;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { SupplierId, SupplierName, Phone, Email, TaxCode, Address, Status, Edit, Delete });
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.Location = new Point(0, 60);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.RowHeadersWidth = 62;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(880, 394);
            dgvSuppliers.TabIndex = 2;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // SupplierId
            // 
            SupplierId.DataPropertyName = "SupplierId";
            SupplierId.HeaderText = "Mã số";
            SupplierId.MinimumWidth = 8;
            SupplierId.Name = "SupplierId";
            SupplierId.ReadOnly = true;
            SupplierId.Visible = false;
            // 
            // SupplierName
            // 
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "Tên nhà cung cấp";
            SupplierName.MinimumWidth = 8;
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // TaxCode
            // 
            TaxCode.DataPropertyName = "TaxCode";
            TaxCode.HeaderText = "Mã số thuế";
            TaxCode.MinimumWidth = 8;
            TaxCode.Name = "TaxCode";
            TaxCode.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa chỉ văn phòng";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Hoạt động";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
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
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(880, 504);
            Controls.Add(dgvSuppliers);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ THÔNG TIN NHÀ CUNG CẤP";
            WindowState = FormWindowState.Maximized;
            Load += frmSupplier_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btSearch;
        private Panel pnlBottom;
        private Button btNew;
        private DataGridView dgvSuppliers;
        private DataGridViewTextBoxColumn SupplierId;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TaxCode;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}