using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmReportInventory : Form
    {
        private ReportViewer reportViewer1 = null!;

        public frmReportInventory()
        {
            InitializeComponent();
        }

        private void frmReportInventory_Load(object sender, EventArgs e)
        {
            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            pnlContent.Controls.Add(reportViewer1);

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var categories = db.Categories
                        .Select(c => new { c.CategoryId, c.CategoryName })
                        .ToList();

                    categories.Insert(0, new { CategoryId = 0, CategoryName = "-- Tất cả danh mục --" });

                    cbCategories.DisplayMember = "CategoryName";
                    cbCategories.ValueMember = "CategoryId";
                    cbCategories.DataSource = categories;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXemBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCategoryId = cbCategories.SelectedValue == null ? 0 : (int)cbCategories.SelectedValue;

                using (var db = new PharmacyDbContext())
                {
                    var data = db.Products
                        .Include(p => p.Category)
                        .Include(p => p.ImportDetails)
                        .Where(p => selectedCategoryId == 0 || p.CategoryId == selectedCategoryId)
                        .AsEnumerable()
                        .Select(p => new
                        {
                            p.ProductCode,
                            p.ProductName,
                            p.Unit,
                            p.Price,
                            CategoryName = p.Category.CategoryName,
                            Quantity = p.TotalStock
                        })
                        .ToList();

                    reportViewer1.Reset();
                    reportViewer1.LocalReport.ReportPath = "rptProductInventory.rdlc";
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
        }
    }
}
