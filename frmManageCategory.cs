using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmManageCategory : Form
    {
        public frmManageCategory()
        {
            InitializeComponent();
        }

        private void frmManageCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    string keyword = txtSearch.Text?.Trim() ?? "";
                    var query = db.Categories.AsQueryable();

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(c => c.CategoryName.Contains(keyword) || c.CategoryCode.Contains(keyword));
                    }

                    dgvCategories.AutoGenerateColumns = false;
                    dgvCategories.DataSource = query.Select(c => new
                    {
                        c.CategoryId,
                        c.CategoryCode,
                        c.CategoryName,
                        c.Description,
                        c.Status
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmNewCategory());
            }
            else
            {
                frmNewCategory inputForm = new frmNewCategory();
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var cellIdValue = dgvCategories.Rows[e.RowIndex].Cells["CategoryId"].Value;
            if (cellIdValue == null) return;

            int categoryId = Convert.ToInt32(cellIdValue);
            string categoryName = dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value?.ToString() ?? "";
            string columnName = dgvCategories.Columns[e.ColumnIndex].Name ?? "";

            if (columnName == "Edit")
            {
                if (this.MdiParent is frmMain mainForm)
                {
                    mainForm.OpenChildForm(new frmEditCategory(categoryId));
                }
                else
                {
                    frmEditCategory editForm = new frmEditCategory(categoryId);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }

            if (columnName == "Delete")
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa danh mục thuốc [{categoryName}] khỏi hệ thống?",
                                                      "Xác nhận xóa bỏ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (var db = new PharmacyDbContext())
                        {
                            Category? category = db.Categories.Find(categoryId);

                            if (category != null)
                            {
                                db.Categories.Remove(category);
                                db.SaveChanges();

                                MessageBox.Show("Đã xóa danh mục thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu danh mục không còn tồn tại hoặc đã bị xóa bởi người dùng khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Danh mục này đã chứa các sản phẩm thuốc bên trong, không thể xóa bỏ hoàn toàn để tránh mất liên kết dữ liệu! Hãy bấm nút [Sửa] để chuyển trạng thái tạm khóa danh mục.",
                                        "Bảo vệ toàn vẹn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}