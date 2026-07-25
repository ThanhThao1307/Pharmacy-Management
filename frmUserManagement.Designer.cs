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
            btnAddNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
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
            pnlHeader.Size = new Size(1258, 60);
            pnlHeader.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(484, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHÂN SỰ VÀ TÀI KHOẢN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 83);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 132);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(26, 182);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 2;
            label3.Text = "Vai trò:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(667, 83);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(667, 132);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            label5.Visible = false;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(211, 84);
            txtUsername.MaxLength = 100;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(415, 34);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(789, 84);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(442, 34);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(211, 133);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(415, 34);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(789, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "employee@pharmacy.com";
            txtEmail.Size = new Size(442, 34);
            txtEmail.TabIndex = 8;
            txtEmail.Visible = false;
            // 
            // cboRoles
            // 
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoles.FormattingEnabled = true;
            cboRoles.Location = new Point(211, 182);
            cboRoles.Name = "cboRoles";
            cboRoles.Size = new Size(415, 36);
            cboRoles.TabIndex = 9;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Tomato;
            btnAddNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.FloralWhite;
            btnAddNew.Location = new Point(816, 177);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(167, 44);
            btnAddNew.TabIndex = 10;
            btnAddNew.Text = "➕ THÊM MỚI";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FloralWhite;
            btnSave.Location = new Point(1002, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "💾 LƯU";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1126, 182);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "❌ XÓA";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsersList.BackgroundColor = Color.LightBlue;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsersList.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUsername, colFullName, colRoleName, colRoleId, colTrangThai });
            dgvUsersList.Location = new Point(23, 239);
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.RowHeadersVisible = false;
            dgvUsersList.RowHeadersWidth = 62;
            dgvUsersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsersList.Size = new Size(1208, 365);
            dgvUsersList.TabIndex = 13;
            dgvUsersList.Tag = "";
            dgvUsersList.CellClick += dgvUsersList_CellClick;
            dgvUsersList.CellEndEdit += dgvUsersList_CellEndEdit;
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
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Họ và tên";
            colFullName.MinimumWidth = 8;
            colFullName.Name = "colFullName";
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
            ClientSize = new Size(1258, 616);
            Controls.Add(dgvUsersList);
            Controls.Add(btnAddNew);
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
            FormBorderStyle = FormBorderStyle.Sizable;
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
        private Button btnAddNew;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dgvUsersList;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colRoleName;
        private DataGridViewTextBoxColumn colRoleId;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}