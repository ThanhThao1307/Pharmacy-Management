using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmReportInventory : Form
    {

        public frmReportInventory()
        {
            InitializeComponent();
        }

        private void frmReportInventory_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var categories = db.Categories
                        .Select(c => new { c.CategoryId, CategoryName = c.Status ? c.CategoryName : c.CategoryName + " [Đã khóa]" })
                        .ToList();

                    categories.Insert(0, new { CategoryId = 0, CategoryName = "-- Tất cả danh mục --" });

                    cbCategories.SelectedIndexChanged -= cbCategories_SelectedIndexChanged;
                    cbCategories.DisplayMember = "CategoryName";
                    cbCategories.ValueMember = "CategoryId";
                    cbCategories.DataSource = categories;
                    cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
                }

                LoadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCategories_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbCategories.SelectedValue is int)
            {
                LoadReport();
            }
        }

        private void btXemBaoCao_Click(object? sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int selectedCategoryId = cbCategories.SelectedValue is int id ? id : 0;

                using (var db = new PharmacyDbContext())
                {
                    var data = db.Products
                        .Include(p => p.Category)
                        .Include(p => p.ImportDetails)
                        .Where(p => selectedCategoryId == 0 || p.CategoryId == selectedCategoryId)
                        .AsEnumerable()
                        .Select(p => new
                        {
                            p.ProductId,
                            p.ProductCode,
                            p.ProductName,
                            p.Unit,
                            p.Price,
                            p.CategoryId,
                            CategoryName = p.Category.CategoryName,
                            Quantity = p.TotalStock
                        })
                        .ToList();

                    reportViewer1.Reset();
                    string rptName = "rptProductInventory.rdlc";
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rptName);
                    reportViewer1.LocalReport.ReportPath = File.Exists(fullPath) ? fullPath : rptName;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(
                        new ReportDataSource("dsProductInventory", data)
                    );
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
