using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData(); // Mở form: luôn hiển thị toàn bộ sản phẩm
        }

        public void LoadData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    string keyword = txtSearch.Text?.Trim() ?? "";

                    var query = db.Products.Include(p => p.Category).AsQueryable();

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(p => p.ProductName.Contains(keyword) || p.ProductCode.Contains(keyword));
                    }

                    var resultList = query.ToList().Select(p => new
                    {
                        p.ProductId,
                        p.ProductCode,
                        p.ProductName,
                        CategoryName = p.Category != null ? p.Category.CategoryName : "",
                        p.PrescriptionRequired,
                        p.Unit,
                        p.NormalPrice,
                        p.Price,
                        p.Status,
                        p.Description,
                        p.ImageFile
                    }).ToList();

                    dgvProducts.DataSource = resultList;

                    // Hiển thị chi tiết (hình ảnh & mô tả) của dòng đầu tiên
                    if (resultList.Count > 0)
                    {
                        ShowProductDetails(0);
                    }
                    else
                    {
                        picProductImage.Image = null;
                        rtxtProductDesc.Text = "Không có dữ liệu.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sản phẩm! Chi tiết lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadData(); // Chỉ khi nhấn nút tìm kiếm mới lọc
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn Enter trong ô tìm kiếm cũng có tác dụng tìm
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
                e.SuppressKeyPress = true;
            }
            // Nhấn Escape hoặc xóa hết chữ thì hiển thị lại toàn bộ
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Clear();
                LoadData();
                e.SuppressKeyPress = true;
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmProductInput inputForm = new frmProductInput();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var cellIdValue = dgvProducts.Rows[e.RowIndex].Cells["ProductId"].Value;
            if (cellIdValue == null) return;

            long productId = Convert.ToInt64(cellIdValue);
            string columnName = dgvProducts.Columns[e.ColumnIndex].Name;

            // Hiển thị chi tiết hình ảnh và mô tả sản phẩm được chọn
            ShowProductDetails(e.RowIndex);

            if (columnName == "Edit")
            {
                frmProductInput editForm = new frmProductInput(productId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }

            if (columnName == "Delete")
            {
                string productName = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value?.ToString() ?? "";
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thuốc [{productName}] và tất cả đơn vị quy đổi phụ liên quan?",
                                                      "Xác nhận xóa hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (var db = new PharmacyDbContext())
                        {
                            bool hasImported = db.ImportDetails.Any(id => id.ProductId == productId);
                            if (hasImported)
                            {
                                MessageBox.Show("Sản phẩm thuốc này đã từng phát sinh dữ liệu nhập kho lịch sử.\nKhông được xóa vật lý để đảm bảo toàn vẹn dữ liệu kế toán! Hãy chọn nút [Sửa] và tắt bỏ dấu tích [Đang kinh doanh] để ngừng hiển thị.",
                                                "Ràng buộc dữ liệu GPP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            var product = db.Products.Include(p => p.ProductUnits).FirstOrDefault(p => p.ProductId == productId);
                            if (product != null)
                            {
                                db.Products.Remove(product);
                                db.SaveChanges();
                                MessageBox.Show("Đã xóa sản phẩm thuốc khỏi hệ thống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa sản phẩm thuốc. Chi tiết lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ShowProductDetails(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvProducts.Rows.Count) return;
            var row = dgvProducts.Rows[rowIndex];

            // 1. Hiển thị mô tả
            var descValue = row.Cells["Description"]?.Value;
            rtxtProductDesc.Text = descValue != null && !string.IsNullOrWhiteSpace(descValue.ToString())
                ? descValue.ToString()
                : "Chưa có thông tin mô tả chi tiết cho sản phẩm thuốc này.";

            // 2. Hiển thị hình ảnh
            var imageFileValue = row.Cells["ImageFile"]?.Value;
            var oldImage = picProductImage.Image;
            if (imageFileValue != null && !string.IsNullOrEmpty(imageFileValue.ToString()))
            {
                string imgPath = Path.Combine(Utility.ImagePath, imageFileValue.ToString()!);
                picProductImage.Image = Utility.LoadBitmapWithoutLock(imgPath);
            }
            else
            {
                picProductImage.Image = null;
            }
            oldImage?.Dispose();
        }
    }
}