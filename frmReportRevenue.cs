using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmReportRevenue : Form
    {

        public frmReportRevenue()
        {
            InitializeComponent();
        }

        private void frmReportRevenue_Load(object sender, EventArgs e)
        {
            dtpFromDate.ValueChanged -= dtpFromDate_ValueChanged;
            dtpToDate.ValueChanged -= dtpToDate_ValueChanged;
            dtpFromDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpToDate.Value = DateTime.Today;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var categories = db.Categories
                        .Select(c => new { c.CategoryId, c.CategoryName })
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

        private void dtpFromDate_ValueChanged(object? sender, EventArgs e)
        {
            LoadReport();
        }

        private void dtpToDate_ValueChanged(object? sender, EventArgs e)
        {
            LoadReport();
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
                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddTicks(-1);

                using (var db = new PharmacyDbContext())
                {
                    var data = db.OrderDetails
                        .Include(od => od.Order)
                        .Include(od => od.ImportDetail)
                            .ThenInclude(id => id.Product)
                                .ThenInclude(p => p.Category)
                        .Where(od => od.Order.OrderDate >= fromDate 
                                  && od.Order.OrderDate <= toDate 
                                  && od.Order.Status == false
                                  && (selectedCategoryId == 0 || od.ImportDetail.Product.CategoryId == selectedCategoryId))
                        .AsEnumerable()
                        .Select(od => new
                        {
                            OrderId = od.OrderId,
                            OrderDate = od.Order.OrderDate.ToString("dd/MM/yyyy"),
                            ProductCode = od.ImportDetail.Product.ProductCode,
                            ProductName = od.ImportDetail.Product.ProductName,
                            CategoryName = od.ImportDetail.Product.Category.CategoryName,
                            Quantity = od.Quantity,
                            Price = od.Price,
                            TotalAmount = od.Amount
                        })
                        .ToList();

                    reportViewer1.Reset();
                    string rptName = "rptRevenueReport.rdlc";
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rptName);
                    reportViewer1.LocalReport.ReportPath = File.Exists(fullPath) ? fullPath : rptName;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(
                        new ReportDataSource("dsRevenueReport", data)
                    );
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lập báo cáo doanh thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
