using Pharmacy_Nhom1;

namespace Pharmacy_Nhom1
{
    internal static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            if (args.Length > 0 && args[0] == "--test-reports")
            {
                Console.WriteLine("--- STARTING REPORT DIAGNOSTIC ---");
                try {
                    Console.WriteLine("Testing rptProductInventory.rdlc Render...");
                    using var r = new Microsoft.Reporting.WinForms.LocalReport();
                    r.ReportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rptProductInventory.rdlc");
                    r.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsProductInventory", new[] {
                        new { ProductId = 1L, ProductCode = "P001", ProductName = "Thuốc Test", Unit = "Hộp", Price = 10000m, CategoryId = 1, CategoryName = "Danh mục 1", Quantity = 5 }
                    }));
                    var bytes = r.Render("PDF");
                    Console.WriteLine($"rptProductInventory SUCCESS! PDF bytes: {bytes.Length}");
                } catch (Exception ex) {
                    Console.WriteLine("rptProductInventory ERROR: " + ex.ToString());
                    if (ex.InnerException != null) Console.WriteLine("Inner: " + ex.InnerException.ToString());
                }

                try {
                    Console.WriteLine("Testing rptRevenueReport.rdlc Render...");
                    using var r = new Microsoft.Reporting.WinForms.LocalReport();
                    r.ReportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rptRevenueReport.rdlc");
                    r.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRevenueReport", new[] {
                        new { OrderId = 1L, OrderDate = "10/07/2026", ProductCode = "P001", ProductName = "Thuốc Test", CategoryName = "Danh mục 1", Quantity = 2, Price = 10000m, TotalAmount = 20000m }
                    }));
                    var bytes = r.Render("PDF");
                    Console.WriteLine($"rptRevenueReport SUCCESS! PDF bytes: {bytes.Length}");
                } catch (Exception ex) {
                    Console.WriteLine("rptRevenueReport ERROR: " + ex.ToString());
                    if (ex.InnerException != null) Console.WriteLine("Inner: " + ex.InnerException.ToString());
                }

                try {
                    Console.WriteLine("Testing rptOrderInvoice.rdlc Render...");
                    using var r = new Microsoft.Reporting.WinForms.LocalReport();
                    r.ReportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rptOrderInvoice.rdlc");
                    r.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsInvoiceHeader", new[] {
                        new { OrderCode = "HD001", OrderDate = "10/07/2026", CustomerName = "Khách A", CustomerPhone = "0123456789", StaffName = "Dược sĩ A", TotalAmount = 100000m, Discount = 10000m, NetAmount = 90000m }
                    }));
                    r.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsInvoiceDetails", new[] {
                        new { ProductName = "Thuốc A", SoldUnit = "Hộp", Quantity = 2, Price = 50000m, Amount = 100000m }
                    }));
                    var bytes = r.Render("PDF");
                    Console.WriteLine($"rptOrderInvoice SUCCESS! PDF bytes: {bytes.Length}");
                } catch (Exception ex) {
                    Console.WriteLine("rptOrderInvoice ERROR: " + ex.ToString());
                    if (ex.InnerException != null) Console.WriteLine("Inner: " + ex.InnerException.ToString());
                }
                return;
            }

            Application.Run(new frmLogin());
        }
    }
}