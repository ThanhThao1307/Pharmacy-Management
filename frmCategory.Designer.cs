namespace Pharmacy_Nhom1
{
    partial class frmCategory
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            btSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvCategories = new DataGridView();
            CategoryId = new DataGridViewTextBoxColumn();
            CategoryCode = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            pnlFormGroup = new Panel();
            btNew = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            pnlFormGroup.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btSearch);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(lblSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(978, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH MỤC THUỐC";
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSearch.BackColor = Color.Navy;
            btSearch.FlatAppearance.BorderSize = 0;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = Color.FloralWhite;
            btSearch.Location = new Point(816, 10);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(150, 44);
            btSearch.TabIndex = 1;
            btSearch.Text = "🔍 Tìm Kiếm";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(480, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên hoặc mã danh mục...";
            txtSearch.Size = new Size(317, 34);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Lavender;
            lblSearch.Location = new Point(360, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(114, 30);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AllowUserToOrderColumns = true;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.LightBlue;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { CategoryId, CategoryCode, CategoryName, Description, Status, Edit, Delete });
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(0, 60);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 62;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(978, 584);
            dgvCategories.TabIndex = 1;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "Mã số";
            CategoryId.MinimumWidth = 8;
            CategoryId.Name = "CategoryId";
            CategoryId.ReadOnly = true;
            CategoryId.Visible = false;
            // 
            // CategoryCode
            // 
            CategoryCode.DataPropertyName = "CategoryCode";
            CategoryCode.HeaderText = "Mã danh mục";
            CategoryCode.MinimumWidth = 8;
            CategoryCode.Name = "CategoryCode";
            CategoryCode.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Tên nhóm thuốc";
            CategoryName.MinimumWidth = 8;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Mô tả";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
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
            // pnlFormGroup
            // 
            pnlFormGroup.BackColor = Color.CadetBlue;
            pnlFormGroup.Controls.Add(btNew);
            pnlFormGroup.Dock = DockStyle.Bottom;
            pnlFormGroup.Location = new Point(0, 594);
            pnlFormGroup.Name = "pnlFormGroup";
            pnlFormGroup.Size = new Size(978, 50);
            pnlFormGroup.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.BackColor = Color.Tomato;
            btNew.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNew.ForeColor = Color.FloralWhite;
            btNew.Location = new Point(806, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(160, 41);
            btNew.TabIndex = 0;
            btNew.Text = "➕ THÊM MỚI";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(978, 644);
            Controls.Add(pnlFormGroup);
            Controls.Add(dgvCategories);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Danh Mục Nhóm Thuốc";
            WindowState = FormWindowState.Maximized;
            Load += frmCategory_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            pnlFormGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btSearch;
        private DataGridView dgvCategories;
        private Panel pnlFormGroup;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn CategoryCode;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btNew;
    }
}