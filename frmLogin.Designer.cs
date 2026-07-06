namespace Pharmacy_Nhom1
{
    partial class frmLogin
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
            pnlRight = new Panel();
            btCancel = new Button();
            btLogin = new Button();
            chkShowPass = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSub = new Label();
            lblWelcome = new Label();
            pnlLeft = new Panel();
            lblTagline = new Label();
            lblName = new Label();
            lblLogo = new Label();
            pnlRight.SuspendLayout();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.LightBlue;
            pnlRight.Controls.Add(btCancel);
            pnlRight.Controls.Add(btLogin);
            pnlRight.Controls.Add(chkShowPass);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(lblUsername);
            pnlRight.Controls.Add(lblSub);
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.ForeColor = SystemColors.ControlText;
            pnlRight.Location = new Point(478, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(400, 544);
            pnlRight.TabIndex = 8;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btCancel.BackColor = Color.Crimson;
            btCancel.Cursor = Cursors.Hand;
            btCancel.FlatStyle = FlatStyle.Flat;
            btCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancel.Location = new Point(208, 459);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(153, 43);
            btCancel.TabIndex = 8;
            btCancel.Text = "THOÁT";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // btLogin
            // 
            btLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btLogin.BackColor = Color.DarkSlateGray;
            btLogin.Cursor = Cursors.Hand;
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.LavenderBlush;
            btLogin.Location = new Point(30, 459);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(153, 43);
            btLogin.TabIndex = 7;
            btLogin.Text = "ĐĂNG NHẬP";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.CheckAlign = ContentAlignment.MiddleRight;
            chkShowPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(208, 410);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(153, 29);
            chkShowPass.TabIndex = 6;
            chkShowPass.Text = "Hiện mật khẩu";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.PaleTurquoise;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DarkSlateGray;
            txtPassword.Location = new Point(30, 335);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Nhập mật khẩu...";
            txtPassword.Size = new Size(331, 37);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.ForestGreen;
            lblPassword.Location = new Point(30, 290);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(131, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "🔒  Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.PaleTurquoise;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DarkSlateGray;
            txtUsername.Location = new Point(30, 219);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nhập tên đăng nhập...";
            txtUsername.Size = new Size(331, 37);
            txtUsername.TabIndex = 3;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.ForestGreen;
            lblUsername.Location = new Point(30, 175);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(177, 28);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "👤  Tên đăng nhập";
            // 
            // lblSub
            // 
            lblSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.DarkGreen;
            lblSub.Location = new Point(59, 114);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(279, 25);
            lblSub.TabIndex = 1;
            lblSub.Text = "Vui lòng nhập thông tin tài khoản";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(70, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(268, 54);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "ĐĂNG NHẬP";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.LightBlue;
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Controls.Add(lblName);
            pnlLeft.Controls.Add(lblLogo);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(478, 544);
            pnlLeft.TabIndex = 9;
            // 
            // lblTagline
            // 
            lblTagline.Anchor = AnchorStyles.None;
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.Green;
            lblTagline.Location = new Point(12, 285);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(359, 30);
            lblTagline.TabIndex = 0;
            lblTagline.Text = "Hệ thống quản lý bán thuốc tư nhân";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DarkGreen;
            lblName.Location = new Point(12, 206);
            lblName.Name = "lblName";
            lblName.Size = new Size(289, 60);
            lblName.TabIndex = 0;
            lblName.Text = "NHÀ THUỐC";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.Font = new Font("Segoe UI Emoji", 64F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(12, 101);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(200, 200);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "💊";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(878, 544);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 520);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ NHÀ THUỐC";
            Load += frmLogin_Load;
            Resize += frmLogin_Resize;
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlRight;
        private Panel pnlLeft;
        private Label lblLogo;
        private Label lblName;
        private Label lblWelcome;
        private Label lblTagline;
        private Label lblSub;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private CheckBox chkShowPass;
        private TextBox txtPassword;
        private Button btCancel;
        private Button btLogin;
    }
}