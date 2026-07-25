namespace Pharmacy_Nhom1
{
    partial class frmManageProduct
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSearchName = new Label();
            btSearch = new Button();
            txtSearch = new TextBox();
            pnlFooter = new Panel();
            btNew = new Button();
            pnlDetails = new Panel();
            rtxtProductDesc = new RichTextBox();
            lblDescTitle = new Label();
            picProductImage = new PictureBox();
            lblDetailTitle = new Label();
            dgvProducts = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            PrescriptionRequired = new DataGridViewCheckBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            NormalPrice = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ImageFile = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
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
            lblTitle.Size = new Size(446, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THUỐC VÀ SẢN PHẨM";
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchName.ForeColor = Color.White;
            lblSearchName.Location = new Point(484, 15);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(252, 32);
            lblSearchName.TabIndex = 1;
            lblSearchName.Text = "Tên sản phẩm / thuốc:";
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSearch.BackColor = Color.Navy;
            btSearch.FlatAppearance.BorderSize = 0;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = Color.FloralWhite;
            btSearch.Location = new Point(1089, 13);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(143, 38);
            btSearch.TabIndex = 2;
            btSearch.Text = "🔍 Tìm kiếm";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(742, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(336, 34);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.CadetBlue;
            pnlFooter.Controls.Add(btNew);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 566);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1258, 50);
            pnlFooter.TabIndex = 2;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.BackColor = Color.Tomato;
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
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.LightCyan;
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(rtxtProductDesc);
            pnlDetails.Controls.Add(lblDescTitle);
            pnlDetails.Controls.Add(picProductImage);
            pnlDetails.Controls.Add(lblDetailTitle);
            pnlDetails.Dock = DockStyle.Right;
            pnlDetails.Location = new Point(938, 60);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Padding = new Padding(8);
            pnlDetails.Size = new Size(320, 506);
            pnlDetails.TabIndex = 3;
            // 
            // rtxtProductDesc
            // 
            rtxtProductDesc.BackColor = Color.White;
            rtxtProductDesc.BorderStyle = BorderStyle.FixedSingle;
            rtxtProductDesc.Dock = DockStyle.Fill;
            rtxtProductDesc.Location = new Point(8, 253);
            rtxtProductDesc.Name = "rtxtProductDesc";
            rtxtProductDesc.ReadOnly = true;
            rtxtProductDesc.Size = new Size(302, 243);
            rtxtProductDesc.TabIndex = 3;
            rtxtProductDesc.Text = "";
            // 
            // lblDescTitle
            // 
            lblDescTitle.Dock = DockStyle.Top;
            lblDescTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescTitle.ForeColor = Color.MidnightBlue;
            lblDescTitle.Location = new Point(8, 218);
            lblDescTitle.Name = "lblDescTitle";
            lblDescTitle.Size = new Size(302, 35);
            lblDescTitle.TabIndex = 2;
            lblDescTitle.Text = "Mô tả thuốc";
            lblDescTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // picProductImage
            // 
            picProductImage.BackColor = Color.White;
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Dock = DockStyle.Top;
            picProductImage.Location = new Point(8, 38);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(302, 180);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 1;
            picProductImage.TabStop = false;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.Dock = DockStyle.Top;
            lblDetailTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailTitle.ForeColor = Color.MidnightBlue;
            lblDetailTitle.Location = new Point(8, 8);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(302, 30);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Hình ảnh && Mô tả chi tiết";
            lblDetailTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToOrderColumns = true;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.LightBlue;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductCode, ProductName, CategoryName, PrescriptionRequired, Unit, NormalPrice, Price, Status, Description, ImageFile, Edit, Delete });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 60);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(938, 506);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "Mã Số";
            ProductId.MinimumWidth = 8;
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
            // 
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "Mã Thuốc";
            ProductCode.MinimumWidth = 8;
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            ProductCode.Width = 117;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Tên Thuốc";
            ProductName.MinimumWidth = 160;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 160;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Nhóm Danh Mục Thuốc";
            CategoryName.MinimumWidth = 220;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.Width = 220;
            // 
            // PrescriptionRequired
            // 
            PrescriptionRequired.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PrescriptionRequired.DataPropertyName = "PrescriptionRequired";
            PrescriptionRequired.HeaderText = "Thuốc kê đơn";
            PrescriptionRequired.MinimumWidth = 8;
            PrescriptionRequired.Name = "PrescriptionRequired";
            PrescriptionRequired.ReadOnly = true;
            PrescriptionRequired.Width = 85;
            // 
            // Unit
            // 
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Unit.DataPropertyName = "Unit";
            Unit.HeaderText = "ĐVT";
            Unit.MinimumWidth = 8;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            Unit.Width = 81;
            // 
            // NormalPrice
            // 
            NormalPrice.DataPropertyName = "NormalPrice";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            NormalPrice.DefaultCellStyle = dataGridViewCellStyle1;
            NormalPrice.HeaderText = "Giá Thị Trường";
            NormalPrice.MinimumWidth = 8;
            NormalPrice.Name = "NormalPrice";
            NormalPrice.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Giá Bán Lẻ Gốc";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Đang Kinh Doanh";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 142;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Mô Tả";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Visible = false;
            // 
            // ImageFile
            // 
            ImageFile.DataPropertyName = "ImageFile";
            ImageFile.HeaderText = "Hình Ảnh";
            ImageFile.MinimumWidth = 8;
            ImageFile.Name = "ImageFile";
            ImageFile.ReadOnly = true;
            ImageFile.Visible = false;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 48;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 49;
            // 
            // frmManageProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(dgvProducts);
            Controls.Add(pnlDetails);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Name = "frmManageProduct";
            Text = "Quản Lý Thuốc";
            WindowState = FormWindowState.Maximized;
            Load += frmManageProduct_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private TextBox txtSearch;
        private Button btSearch;
        private Label lblSearchName;
        private DataGridView dgvProducts;
        private Panel pnlFooter;
        private Button btNew;

        private Panel pnlDetails;
        private Label lblTitle;
        private Label lblDetailTitle;
        private PictureBox picProductImage;
        private Label lblDescTitle;
        private RichTextBox rtxtProductDesc;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductCode;
        private new DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewCheckBoxColumn PrescriptionRequired;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn NormalPrice;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ImageFile;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}