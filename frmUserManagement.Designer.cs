namespace Pharmacy_Nhom1
{
    partial class frmUserManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            cboRoles = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            dgvUsersList = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colRoleName = new DataGridViewTextBoxColumn();
            colRoleId = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(880, 55);
            pnlHeader.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(416, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHÂN SỰ VÀ TÀI KHOẢN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 107);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 151);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 2;
            label3.Text = "Vai trò:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 68);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 107);
            label5.Name = "label5";
            label5.Size = new Size(63, 28);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            label5.Visible = false;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(171, 62);
            txtUsername.MaxLength = 100;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 34);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(580, 62);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 34);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(171, 101);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(270, 34);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(580, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "employee@pharmacy.com";
            txtEmail.Size = new Size(252, 34);
            txtEmail.TabIndex = 8;
            txtEmail.Visible = false;
            // 
            // cboRoles
            // 
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoles.FormattingEnabled = true;
            cboRoles.Location = new Point(171, 143);
            cboRoles.Name = "cboRoles";
            cboRoles.Size = new Size(270, 36);
            cboRoles.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSalmon;
            btnSave.Location = new Point(21, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 37);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu thông tin";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.Location = new Point(699, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 37);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa nhân sự";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Wheat;
            btnReset.Location = new Point(389, 217);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 37);
            btnReset.TabIndex = 12;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsersList.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUsername, colFullName, colRoleName, colRoleId, colTrangThai });
            dgvUsersList.Location = new Point(23, 277);
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.RowHeadersVisible = false;
            dgvUsersList.RowHeadersWidth = 62;
            dgvUsersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsersList.Size = new Size(832, 215);
            dgvUsersList.TabIndex = 13;
            dgvUsersList.Tag = "";
            dgvUsersList.CellClick += dgvUsersList_CellClick;
            // 
            // colUserId
            // 
            colUserId.DataPropertyName = "UserId";
            colUserId.HeaderText = "Mã số";
            colUserId.MinimumWidth = 8;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Visible = false;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Tên đăng nhập";
            colUsername.MinimumWidth = 8;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Họ và tên";
            colFullName.MinimumWidth = 8;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colRoleName
            // 
            colRoleName.DataPropertyName = "RoleName";
            colRoleName.HeaderText = "Vai trò";
            colRoleName.MinimumWidth = 8;
            colRoleName.Name = "colRoleName";
            colRoleName.ReadOnly = true;
            // 
            // colRoleId
            // 
            colRoleId.DataPropertyName = "RoleId";
            colRoleId.HeaderText = "Mã vai trò";
            colRoleId.MinimumWidth = 8;
            colRoleId.Name = "colRoleId";
            colRoleId.ReadOnly = true;
            colRoleId.Visible = false;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 8;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(880, 504);
            Controls.Add(dgvUsersList);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(cboRoles);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmUserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TRANG QUẢN LÝ NHÂN SỰ";
            WindowState = FormWindowState.Maximized;
            Load += frmUserManagement_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private ComboBox cboRoles;
        private Button btnSave;
        private Button btnDelete;
        private Button btnReset;
        private DataGridView dgvUsersList;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colRoleName;
        private DataGridViewTextBoxColumn colRoleId;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}