namespace Pharmacy_Nhom1
{
    partial class frmNewPrescription
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
            pnlButtons = new Panel();
            btSave = new Button();
            btClose = new Button();
            gbImage = new GroupBox();
            picPrescription = new PictureBox();
            btPrevImage = new Button();
            lblImageCount = new Label();
            btNextImage = new Button();
            btAddMoreImage = new Button();
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
            pnlContent = new Panel();
            pnlHeader.SuspendLayout();
            pnlButtons.SuspendLayout();
            gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPrescription).BeginInit();
            gbInfo.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitle);
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
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(339, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN TOA THUỐC";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.CadetBlue;
            pnlButtons.Controls.Add(btSave);
            pnlButtons.Controls.Add(btClose);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 566);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1258, 50);
            pnlButtons.TabIndex = 3;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSave.BackColor = Color.MidnightBlue;
            btSave.Cursor = Cursors.Hand;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(1004, 8);
            btSave.Name = "btSave";
            btSave.Size = new Size(105, 34);
            btSave.TabIndex = 0;
            btSave.Text = "💾 LƯU";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btClose.BackColor = Color.Silver;
            btClose.Cursor = Cursors.Hand;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btClose.ForeColor = Color.Black;
            btClose.Location = new Point(1126, 8);
            btClose.Name = "btClose";
            btClose.Size = new Size(105, 34);
            btClose.TabIndex = 1;
            btClose.Text = "❌ HỦY";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // gbImage
            // 
            gbImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbImage.Controls.Add(picPrescription);
            gbImage.Controls.Add(btPrevImage);
            gbImage.Controls.Add(lblImageCount);
            gbImage.Controls.Add(btNextImage);
            gbImage.Controls.Add(btAddMoreImage);
            gbImage.Controls.Add(btBrowse);
            gbImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbImage.ForeColor = Color.Navy;
            gbImage.Location = new Point(15, 6);
            gbImage.Name = "gbImage";
            gbImage.Size = new Size(556, 494);
            gbImage.TabIndex = 1;
            gbImage.TabStop = false;
            gbImage.Text = "Hình ảnh Toa Thuốc";
            // 
            // picPrescription
            // 
            picPrescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picPrescription.BackColor = Color.White;
            picPrescription.BorderStyle = BorderStyle.FixedSingle;
            picPrescription.Location = new Point(11, 38);
            picPrescription.Name = "picPrescription";
            picPrescription.Size = new Size(531, 346);
            picPrescription.SizeMode = PictureBoxSizeMode.Zoom;
            picPrescription.TabIndex = 0;
            picPrescription.TabStop = false;
            // 
            // btPrevImage
            // 
            btPrevImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btPrevImage.BackColor = Color.CadetBlue;
            btPrevImage.Cursor = Cursors.Hand;
            btPrevImage.FlatAppearance.BorderSize = 0;
            btPrevImage.FlatStyle = FlatStyle.Flat;
            btPrevImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btPrevImage.ForeColor = Color.White;
            btPrevImage.Location = new Point(11, 392);
            btPrevImage.Name = "btPrevImage";
            btPrevImage.Size = new Size(88, 38);
            btPrevImage.TabIndex = 2;
            btPrevImage.Text = "◀ Trước";
            btPrevImage.UseVisualStyleBackColor = false;
            btPrevImage.Click += btPrevImage_Click;
            // 
            // lblImageCount
            // 
            lblImageCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImageCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblImageCount.ForeColor = Color.DarkRed;
            lblImageCount.Location = new Point(104, 398);
            lblImageCount.Name = "lblImageCount";
            lblImageCount.Size = new Size(116, 26);
            lblImageCount.TabIndex = 3;
            lblImageCount.Text = "Chưa có ảnh";
            lblImageCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btNextImage
            // 
            btNextImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btNextImage.BackColor = Color.CadetBlue;
            btNextImage.Cursor = Cursors.Hand;
            btNextImage.FlatAppearance.BorderSize = 0;
            btNextImage.FlatStyle = FlatStyle.Flat;
            btNextImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btNextImage.ForeColor = Color.White;
            btNextImage.Location = new Point(225, 392);
            btNextImage.Name = "btNextImage";
            btNextImage.Size = new Size(88, 38);
            btNextImage.TabIndex = 4;
            btNextImage.Text = "Tiếp ▶";
            btNextImage.UseVisualStyleBackColor = false;
            btNextImage.Click += btNextImage_Click;
            // 
            // btAddMoreImage
            // 
            btAddMoreImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAddMoreImage.BackColor = Color.SeaGreen;
            btAddMoreImage.Cursor = Cursors.Hand;
            btAddMoreImage.FlatAppearance.BorderSize = 0;
            btAddMoreImage.FlatStyle = FlatStyle.Flat;
            btAddMoreImage.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btAddMoreImage.ForeColor = Color.White;
            btAddMoreImage.Location = new Point(320, 392);
            btAddMoreImage.Name = "btAddMoreImage";
            btAddMoreImage.Size = new Size(222, 38);
            btAddMoreImage.TabIndex = 5;
            btAddMoreImage.Text = "➕ Thêm ảnh toa khác...";
            btAddMoreImage.UseVisualStyleBackColor = false;
            btAddMoreImage.Click += btAddMoreImage_Click;
            // 
            // btBrowse
            // 
            btBrowse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btBrowse.BackColor = Color.SteelBlue;
            btBrowse.Cursor = Cursors.Hand;
            btBrowse.FlatAppearance.BorderSize = 0;
            btBrowse.FlatStyle = FlatStyle.Flat;
            btBrowse.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowse.ForeColor = Color.White;
            btBrowse.Location = new Point(11, 439);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(531, 40);
            btBrowse.TabIndex = 6;
            btBrowse.Text = "📁 Chọn / Thay ảnh Toa (Chọn nhiều ảnh)...";
            btBrowse.UseVisualStyleBackColor = false;
            btBrowse.Click += btBrowse_Click;
            // 
            // gbInfo
            // 
            gbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            gbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbInfo.ForeColor = Color.Navy;
            gbInfo.Location = new Point(577, 6);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(669, 494);
            gbInfo.TabIndex = 2;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin Toa mới";
            gbInfo.Enter += gbInfo_Enter;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(15, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(163, 32);
            lblId.TabIndex = 0;
            lblId.Text = "Mã hồ sơ Toa:";
            // 
            // txtPrescriptionId
            // 
            txtPrescriptionId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrescriptionId.BackColor = SystemColors.Window;
            txtPrescriptionId.BorderStyle = BorderStyle.FixedSingle;
            txtPrescriptionId.Font = new Font("Segoe UI", 10F);
            txtPrescriptionId.Location = new Point(184, 53);
            txtPrescriptionId.Name = "txtPrescriptionId";
            txtPrescriptionId.ReadOnly = true;
            txtPrescriptionId.Size = new Size(470, 34);
            txtPrescriptionId.TabIndex = 1;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 12F);
            lblFileName.ForeColor = Color.Black;
            lblFileName.Location = new Point(15, 97);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(143, 32);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "Tên file gốc:";
            // 
            // txtFileName
            // 
            txtFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileName.BackColor = SystemColors.Window;
            txtFileName.BorderStyle = BorderStyle.FixedSingle;
            txtFileName.Font = new Font("Segoe UI", 10F);
            txtFileName.Location = new Point(184, 101);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(470, 34);
            txtFileName.TabIndex = 3;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Font = new Font("Segoe UI", 12F);
            lblFilePath.ForeColor = Color.Black;
            lblFilePath.Location = new Point(15, 144);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(139, 32);
            lblFilePath.TabIndex = 4;
            lblFilePath.Text = "Đường dẫn:";
            // 
            // txtFilePath
            // 
            txtFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilePath.BackColor = SystemColors.Window;
            txtFilePath.BorderStyle = BorderStyle.FixedSingle;
            txtFilePath.Font = new Font("Segoe UI", 10F);
            txtFilePath.Location = new Point(184, 148);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(470, 34);
            txtFilePath.TabIndex = 5;
            // 
            // lblUploadDate
            // 
            lblUploadDate.AutoSize = true;
            lblUploadDate.Font = new Font("Segoe UI", 12F);
            lblUploadDate.ForeColor = Color.Black;
            lblUploadDate.Location = new Point(15, 195);
            lblUploadDate.Name = "lblUploadDate";
            lblUploadDate.Size = new Size(136, 32);
            lblUploadDate.TabIndex = 6;
            lblUploadDate.Text = "Ngày nhận:";
            // 
            // dtpUploadDate
            // 
            dtpUploadDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpUploadDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpUploadDate.Font = new Font("Segoe UI", 10F);
            dtpUploadDate.Format = DateTimePickerFormat.Custom;
            dtpUploadDate.Location = new Point(184, 196);
            dtpUploadDate.Name = "dtpUploadDate";
            dtpUploadDate.Size = new Size(470, 34);
            dtpUploadDate.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(15, 245);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(125, 32);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Trạng thái:";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkStatus.ForeColor = Color.DarkGreen;
            chkStatus.Location = new Point(184, 244);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(303, 36);
            chkStatus.TabIndex = 9;
            chkStatus.Text = "Hợp lệ (Đang áp dụng)";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 12F);
            lblNote.ForeColor = Color.Black;
            lblNote.Location = new Point(15, 292);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(442, 32);
            lblNote.TabIndex = 10;
            lblNote.Text = "Ghi chú thẩm định (Bác sĩ, Chẩn đoán...):";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(15, 338);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(639, 141);
            txtNote.TabIndex = 11;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightBlue;
            pnlContent.Controls.Add(gbImage);
            pnlContent.Controls.Add(gbInfo);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1258, 506);
            pnlContent.TabIndex = 12;
            // 
            // frmNewPrescription
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1258, 616);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "frmNewPrescription";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lập hồ sơ Toa thuốc Kê đơn mới";
            WindowState = FormWindowState.Maximized;
            Load += frmNewPrescription_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlButtons.ResumeLayout(false);
            gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPrescription).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.PictureBox picPrescription;
        private System.Windows.Forms.Button btPrevImage;
        private System.Windows.Forms.Label lblImageCount;
        private System.Windows.Forms.Button btNextImage;
        private System.Windows.Forms.Button btAddMoreImage;
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
        private System.Windows.Forms.Panel pnlContent;
    }
}
