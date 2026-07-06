namespace Pharmacy_Nhom1
{
    partial class frmPrescriptionDetail
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            gbImage = new GroupBox();
            picPrescription = new PictureBox();
            btBrowse = new Button();
            gbInfo = new GroupBox();
            lblId = new Label();
            txtPrescriptionId = new TextBox();
            lblFileName = new Label();
            txtFileName = new TextBox();
            lblFilePath = new Label();
            txtFilePath = new TextBox();
            lblUploadDate = new Label();
            dtpUploadDate = new DateTimePicker();
            lblStatus = new Label();
            chkStatus = new CheckBox();
            lblNote = new Label();
            txtNote = new TextBox();
            btSave = new Button();
            btClose = new Button();
            pnlHeader.SuspendLayout();
            gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPrescription).BeginInit();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(454, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỒ SƠ THẨM ĐỊNH TOA THUỐC (GPP)";
            // 
            // gbImage
            // 
            gbImage.Controls.Add(picPrescription);
            gbImage.Controls.Add(btBrowse);
            gbImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbImage.ForeColor = Color.Navy;
            gbImage.Location = new Point(15, 75);
            gbImage.Name = "gbImage";
            gbImage.Size = new Size(450, 470);
            gbImage.TabIndex = 1;
            gbImage.TabStop = false;
            gbImage.Text = "Hình ảnh Toa Thuốc";
            // 
            // picPrescription
            // 
            picPrescription.BackColor = Color.White;
            picPrescription.BorderStyle = BorderStyle.FixedSingle;
            picPrescription.Location = new Point(15, 35);
            picPrescription.Name = "picPrescription";
            picPrescription.Size = new Size(420, 370);
            picPrescription.SizeMode = PictureBoxSizeMode.Zoom;
            picPrescription.TabIndex = 0;
            picPrescription.TabStop = false;
            // 
            // btBrowse
            // 
            btBrowse.BackColor = Color.SteelBlue;
            btBrowse.FlatAppearance.BorderSize = 0;
            btBrowse.FlatStyle = FlatStyle.Flat;
            btBrowse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btBrowse.ForeColor = Color.White;
            btBrowse.Location = new Point(15, 415);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(420, 40);
            btBrowse.TabIndex = 1;
            btBrowse.Text = "📁 Chọn / Đổi ảnh Toa...";
            btBrowse.UseVisualStyleBackColor = false;
            btBrowse.Click += btBrowse_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblId);
            gbInfo.Controls.Add(txtPrescriptionId);
            gbInfo.Controls.Add(lblFileName);
            gbInfo.Controls.Add(txtFileName);
            gbInfo.Controls.Add(lblFilePath);
            gbInfo.Controls.Add(txtFilePath);
            gbInfo.Controls.Add(lblUploadDate);
            gbInfo.Controls.Add(dtpUploadDate);
            gbInfo.Controls.Add(lblStatus);
            gbInfo.Controls.Add(chkStatus);
            gbInfo.Controls.Add(lblNote);
            gbInfo.Controls.Add(txtNote);
            gbInfo.Controls.Add(btSave);
            gbInfo.Controls.Add(btClose);
            gbInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbInfo.ForeColor = Color.Navy;
            gbInfo.Location = new Point(480, 75);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(405, 470);
            gbInfo.TabIndex = 2;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin thẩm định & Lưu trữ Toa";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(15, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(132, 28);
            lblId.TabIndex = 0;
            lblId.Text = "Mã hồ sơ Toa:";
            // 
            // txtPrescriptionId
            // 
            txtPrescriptionId.BorderStyle = BorderStyle.FixedSingle;
            txtPrescriptionId.Font = new Font("Segoe UI", 10F);
            txtPrescriptionId.Location = new Point(155, 32);
            txtPrescriptionId.Name = "txtPrescriptionId";
            txtPrescriptionId.ReadOnly = true;
            txtPrescriptionId.Size = new Size(230, 34);
            txtPrescriptionId.TabIndex = 1;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 10F);
            lblFileName.ForeColor = Color.Black;
            lblFileName.Location = new Point(15, 78);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(114, 28);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "Tên file gốc:";
            // 
            // txtFileName
            // 
            txtFileName.BorderStyle = BorderStyle.FixedSingle;
            txtFileName.Font = new Font("Segoe UI", 10F);
            txtFileName.Location = new Point(155, 75);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(230, 34);
            txtFileName.TabIndex = 3;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Font = new Font("Segoe UI", 10F);
            lblFilePath.ForeColor = Color.Black;
            lblFilePath.Location = new Point(15, 121);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(115, 28);
            lblFilePath.TabIndex = 4;
            lblFilePath.Text = "Đường dẫn:";
            // 
            // txtFilePath
            // 
            txtFilePath.BorderStyle = BorderStyle.FixedSingle;
            txtFilePath.Font = new Font("Segoe UI", 10F);
            txtFilePath.Location = new Point(155, 118);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(230, 34);
            txtFilePath.TabIndex = 5;
            // 
            // lblUploadDate
            // 
            lblUploadDate.AutoSize = true;
            lblUploadDate.Font = new Font("Segoe UI", 10F);
            lblUploadDate.ForeColor = Color.Black;
            lblUploadDate.Location = new Point(15, 164);
            lblUploadDate.Name = "lblUploadDate";
            lblUploadDate.Size = new Size(111, 28);
            lblUploadDate.TabIndex = 6;
            lblUploadDate.Text = "Ngày nhận:";
            // 
            // dtpUploadDate
            // 
            dtpUploadDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpUploadDate.Font = new Font("Segoe UI", 10F);
            dtpUploadDate.Format = DateTimePickerFormat.Custom;
            dtpUploadDate.Location = new Point(155, 161);
            dtpUploadDate.Name = "dtpUploadDate";
            dtpUploadDate.Size = new Size(230, 34);
            dtpUploadDate.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(15, 207);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(102, 28);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Trạng thái:";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkStatus.ForeColor = Color.DarkGreen;
            chkStatus.Location = new Point(155, 206);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(254, 32);
            chkStatus.TabIndex = 9;
            chkStatus.Text = "Hợp lệ (Đang áp dụng)";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10F);
            lblNote.ForeColor = Color.Black;
            lblNote.Location = new Point(15, 245);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(356, 28);
            lblNote.TabIndex = 10;
            lblNote.Text = "Ghi chú thẩm định (Bác sĩ, Chẩn đoán...):";
            // 
            // txtNote
            // 
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(15, 276);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(370, 125);
            txtNote.TabIndex = 11;
            // 
            // btSave
            // 
            btSave.BackColor = Color.MidnightBlue;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(15, 415);
            btSave.Name = "btSave";
            btSave.Size = new Size(180, 40);
            btSave.TabIndex = 12;
            btSave.Text = "💾 LƯU HỒ SƠ";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Silver;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btClose.ForeColor = Color.Black;
            btClose.Location = new Point(205, 415);
            btClose.Name = "btClose";
            btClose.Size = new Size(180, 40);
            btClose.TabIndex = 13;
            btClose.Text = "❌ĐÓNG";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // frmPrescriptionDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(900, 560);
            Controls.Add(gbInfo);
            Controls.Add(gbImage);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrescriptionDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Hồ sơ Toa thuốc Kê đơn";
            Load += frmPrescriptionDetail_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPrescription).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.PictureBox picPrescription;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPrescriptionId;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblUploadDate;
        private System.Windows.Forms.DateTimePicker dtpUploadDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
    }
}
