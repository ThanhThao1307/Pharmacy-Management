namespace Pharmacy_Nhom1
{
    partial class frmManagePrescription
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTitle = new Panel();
            lblTitle = new Label();
            pnlTop = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            btSearch = new Button();
            btNew = new Button();
            pnlCenter = new Panel();
            dgvPrescriptions = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFileName = new DataGridViewTextBoxColumn();
            colUploadDate = new DataGridViewTextBoxColumn();
            colOrderCode = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            colStatusText = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlBottom = new Panel();
            lblCount = new Label();
            pnlTitle.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SteelBlue;
            pnlTitle.Controls.Add(lblTitle);
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
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(468, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THÔNG TIN TOA THUỐC";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.LightBlue;
            pnlTop.Controls.Add(lblSearch);
            pnlTop.Controls.Add(dtpToDate);
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(lblStatus);
            pnlTop.Controls.Add(cbStatus);
            pnlTop.Controls.Add(lblFromDate);
            pnlTop.Controls.Add(dtpFromDate);
            pnlTop.Controls.Add(lblToDate);
            pnlTop.Controls.Add(btSearch);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 60);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1258, 62);
            pnlTop.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(14, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(95, 28);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(115, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(148, 34);
            txtSearch.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(284, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(102, 28);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Trạng thái:";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Tất cả", "✔ Hợp lệ", "❌ Hết hiệu lực" });
            cbStatus.Location = new Point(392, 15);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(163, 36);
            cbStatus.TabIndex = 5;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFromDate.Location = new Point(573, 18);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(86, 28);
            lblFromDate.TabIndex = 6;
            lblFromDate.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(665, 13);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(166, 34);
            dtpFromDate.TabIndex = 7;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToDate.Location = new Point(849, 18);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(49, 28);
            lblToDate.TabIndex = 8;
            lblToDate.Text = "đến:";
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(904, 13);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(160, 34);
            dtpToDate.TabIndex = 9;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSearch.BackColor = Color.Navy;
            btSearch.FlatAppearance.BorderSize = 0;
            btSearch.FlatStyle = FlatStyle.Flat;
            btSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSearch.ForeColor = Color.FloralWhite;
            btSearch.Location = new Point(1098, 14);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(144, 34);
            btSearch.TabIndex = 1;
            btSearch.Text = "🔍 Tìm kiếm";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // btNew
            // 
            btNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNew.BackColor = Color.Tomato;
            btNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNew.ForeColor = Color.FloralWhite;
            btNew.Location = new Point(1086, 5);
            btNew.Name = "btNew";
            btNew.Size = new Size(158, 40);
            btNew.TabIndex = 0;
            btNew.Text = "➕ THÊM MỚI";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(dgvPrescriptions);
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.Location = new Point(0, 122);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(1258, 444);
            pnlCenter.TabIndex = 2;
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.AllowUserToAddRows = false;
            dgvPrescriptions.AllowUserToDeleteRows = false;
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = Color.LightBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrescriptions.ColumnHeadersHeight = 40;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPrescriptions.Columns.AddRange(new DataGridViewColumn[] { colId, colFileName, colUploadDate, colOrderCode, colNote, colStatusText, colEdit, colDelete });
            dgvPrescriptions.Dock = DockStyle.Fill;
            dgvPrescriptions.EnableHeadersVisualStyles = false;
            dgvPrescriptions.Location = new Point(0, 0);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.ReadOnly = true;
            dgvPrescriptions.RowHeadersVisible = false;
            dgvPrescriptions.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dgvPrescriptions.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPrescriptions.RowTemplate.Height = 35;
            dgvPrescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptions.Size = new Size(1258, 444);
            dgvPrescriptions.TabIndex = 0;
            dgvPrescriptions.CellClick += dgvPrescriptions_CellClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "PrescriptionFileId";
            colId.FillWeight = 80F;
            colId.HeaderText = "Mã Toa";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colFileName
            // 
            colFileName.DataPropertyName = "FileName";
            colFileName.FillWeight = 180F;
            colFileName.HeaderText = "Tên File / Ảnh Toa";
            colFileName.MinimumWidth = 6;
            colFileName.Name = "colFileName";
            colFileName.ReadOnly = true;
            // 
            // colUploadDate
            // 
            colUploadDate.DataPropertyName = "UploadDateText";
            colUploadDate.FillWeight = 150F;
            colUploadDate.HeaderText = "Ngày Thẩm Định";
            colUploadDate.MinimumWidth = 6;
            colUploadDate.Name = "colUploadDate";
            colUploadDate.ReadOnly = true;
            // 
            // colOrderCode
            // 
            colOrderCode.DataPropertyName = "OrderCode";
            colOrderCode.FillWeight = 130F;
            colOrderCode.HeaderText = "Đơn Hàng";
            colOrderCode.MinimumWidth = 6;
            colOrderCode.Name = "colOrderCode";
            colOrderCode.ReadOnly = true;
            // 
            // colNote
            // 
            colNote.DataPropertyName = "Note";
            colNote.FillWeight = 260F;
            colNote.HeaderText = "Ghi Chú / Bác Sĩ / Chẩn Đoán";
            colNote.MinimumWidth = 6;
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            // 
            // colStatusText
            // 
            colStatusText.DataPropertyName = "StatusText";
            colStatusText.FillWeight = 110F;
            colStatusText.HeaderText = "Trạng Thái";
            colStatusText.MinimumWidth = 6;
            colStatusText.Name = "colStatusText";
            colStatusText.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.FillWeight = 110F;
            colEdit.HeaderText = "Thẩm Định";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "✏ Xem / Sửa";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.FillWeight = 90F;
            colDelete.HeaderText = "Hủy";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "🗑 Xóa";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.CadetBlue;
            pnlBottom.Controls.Add(btNew);
            pnlBottom.Controls.Add(lblCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 566);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1258, 50);
            pnlBottom.TabIndex = 3;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.Beige;
            lblCount.Location = new Point(26, 7);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(299, 32);
            lblCount.TabIndex = 0;
            lblCount.Text = "Tổng số hồ sơ toa thuốc: 0";
            // 
            // frmManagePrescription
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlCenter);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmManagePrescription";
            Text = "Quản lý Sổ Toa thuốc GPP";
            WindowState = FormWindowState.Maximized;
            Load += frmManagePrescription_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCount;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFileName;
        private DataGridViewTextBoxColumn colUploadDate;
        private DataGridViewTextBoxColumn colOrderCode;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewTextBoxColumn colStatusText;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
