namespace Pharmacy_Nhom1
{
    partial class frmManageImport
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvImports = new DataGridView();
            ImportId = new DataGridViewTextBoxColumn();
            ImportCode = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            ImportDate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            pnlButtons = new Panel();
            btNew = new Button();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImports).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(btSearch);
            pnlTitle.Controls.Add(txtSearch);
            pnlTitle.Controls.Add(lblSearch);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1258, 60);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHẬP KHO";
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSearch.BackColor = Color.Navy;
            btSearch.FlatAppearance.BorderSize = 0;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = Color.FloralWhite;
            btSearch.Location = new Point(1090, 10);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(143, 38);
            btSearch.TabIndex = 1;
            btSearch.Text = "🔍 Tìm kiếm";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(437, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(632, 34);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(313, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(118, 32);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // dgvImports
            // 
            dgvImports.AllowUserToAddRows = false;
            dgvImports.AllowUserToDeleteRows = false;
            dgvImports.AllowUserToOrderColumns = true;
            dgvImports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImports.BackgroundColor = Color.LightBlue;
            dgvImports.BorderStyle = BorderStyle.None;
            dgvImports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImports.Columns.AddRange(new DataGridViewColumn[] { ImportId, ImportCode, SupplierName, ImportDate, TotalAmount, CreatedBy, Status, Edit });
            dgvImports.Dock = DockStyle.Fill;
            dgvImports.Location = new Point(0, 60);
            dgvImports.Name = "dgvImports";
            dgvImports.ReadOnly = true;
            dgvImports.RowHeadersVisible = false;
            dgvImports.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dgvImports.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvImports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImports.Size = new Size(1258, 556);
            dgvImports.TabIndex = 1;
            dgvImports.CellClick += dgvImports_CellClick;
            // 
            // ImportId
            // 
            ImportId.DataPropertyName = "ImportId";
            ImportId.HeaderText = "Mã Số";
            ImportId.MinimumWidth = 8;
            ImportId.Name = "ImportId";
            ImportId.ReadOnly = true;
            ImportId.Visible = false;
            // 
            // ImportCode
            // 
            ImportCode.DataPropertyName = "ImportCode";
            ImportCode.HeaderText = "Mã Phiếu Nhập";
            ImportCode.MinimumWidth = 8;
            ImportCode.Name = "ImportCode";
            ImportCode.ReadOnly = true;
            // 
            // SupplierName
            // 
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "Nhà Cung Cấp";
            SupplierName.MinimumWidth = 8;
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            // 
            // ImportDate
            // 
            ImportDate.DataPropertyName = "ImportDate";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            ImportDate.DefaultCellStyle = dataGridViewCellStyle1;
            ImportDate.HeaderText = "Ngày Nhập Kho";
            ImportDate.MinimumWidth = 8;
            ImportDate.Name = "ImportDate";
            ImportDate.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            TotalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            TotalAmount.HeaderText = "Tổng Tiền (VNĐ)";
            TotalAmount.MinimumWidth = 8;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.DataPropertyName = "CreatedBy";
            CreatedBy.HeaderText = "Người Lập";
            CreatedBy.MinimumWidth = 8;
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Hoạt Động";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            btNew.Location = new Point(1073, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(160, 41);
            btNew.TabIndex = 0;
            btNew.Text = "➕ THÊM MỚI";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // frmManageImport
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlButtons);
            Controls.Add(dgvImports);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmManageImport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ CHỨNG TỪ NHẬP KHO THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += frmManageImport_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImports).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btSearch;
        private DataGridView dgvImports;
        private Panel pnlButtons;
        private Button btNew;
        private DataGridViewTextBoxColumn ImportId;
        private DataGridViewTextBoxColumn ImportCode;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn ImportDate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Edit;
    }
}