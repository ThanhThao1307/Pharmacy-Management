namespace Pharmacy_Nhom1
{
    partial class frmReportInventory
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
            btXemBaoCao = new Button();
            cbCategories = new ComboBox();
            lblCategory = new Label();
            lblTitle = new Label();
            pnlContent = new Panel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(btXemBaoCao);
            pnlHeader.Controls.Add(cbCategories);
            pnlHeader.Controls.Add(lblCategory);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeader.ForeColor = Color.FloralWhite;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 70);
            pnlHeader.TabIndex = 0;
            // 
            // btXemBaoCao
            // 
            btXemBaoCao.BackColor = Color.Navy;
            btXemBaoCao.FlatAppearance.BorderSize = 0;
            btXemBaoCao.FlatStyle = FlatStyle.Flat;
            btXemBaoCao.ForeColor = Color.White;
            btXemBaoCao.Location = new Point(903, 20);
            btXemBaoCao.Name = "btXemBaoCao";
            btXemBaoCao.Size = new Size(185, 38);
            btXemBaoCao.TabIndex = 3;
            btXemBaoCao.Text = "🔍 Xem Báo Cáo";
            btXemBaoCao.UseVisualStyleBackColor = false;
            btXemBaoCao.Click += btXemBaoCao_Click;
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(607, 22);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(273, 36);
            cbCategories.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(406, 25);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(195, 28);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Lọc theo danh mục:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÁO CÁO TỒN KHO THUỐC";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1100, 630);
            pnlContent.TabIndex = 1;
            // 
            // frmReportInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "frmReportInventory";
            Text = "BÁO CÁO TỒN KHO";
            Load += frmReportInventory_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblCategory;
        private ComboBox cbCategories;
        private Button btXemBaoCao;
        private Panel pnlContent;
    }
}