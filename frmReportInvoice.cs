using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmReportInvoice : Form
    {
        private long initialOrderId = 0;

        public frmReportInvoice(long orderId = 0)
        {
            InitializeComponent();
            this.initialOrderId = orderId;
        }

        private void frmReportInvoice_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var ordersList = db.Orders
                        .Include(o => o.Customer)
                        .OrderByDescending(o => o.OrderDate)
                        .Take(100)
                        .ToList();

                    if (initialOrderId > 0 && !ordersList.Any(o => o.OrderId == initialOrderId))
                    {
                        var targetOrder = db.Orders.Include(o => o.Customer).FirstOrDefault(o => o.OrderId == initialOrderId);
                        if (targetOrder != null)
                        {
                            ordersList.Insert(0, targetOrder);
                        }
                    }

                    var orders = ordersList.Select(o => new
                    {
                        o.OrderId,
                        DisplayInfo = $"{o.OrderCode} - {(o.Customer != null ? o.Customer.FullName : "Khách vãng lai")} ({o.OrderDate:dd/MM/yyyy HH:mm}) - {o.NetAmount:N0}đ"
                    }).ToList();

                    cbOrders.SelectedIndexChanged -= cbOrders_SelectedIndexChanged;
                    cbOrders.DisplayMember = "DisplayInfo";
                    cbOrders.ValueMember = "OrderId";
                    cbOrders.DataSource = orders;
                    cbOrders.SelectedIndexChanged += cbOrders_SelectedIndexChanged;

                    if (initialOrderId > 0 && orders.Any(o => o.OrderId == initialOrderId))
                    {
                        cbOrders.SelectedValue = initialOrderId;
                    }
                    else if (orders.Count > 0)
                    {
                        cbOrders.SelectedIndex = 0;
                    }
                }

                if (cbOrders.SelectedValue is long selectedId)
                {
                    LoadInvoice(selectedId);
                }
                else
                {
                    LoadInvoice(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbOrders_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbOrders.SelectedValue is long orderId)
            {
                LoadInvoice(orderId);
            }
        }

        private void btXemIn_Click(object? sender, EventArgs e)
        {
            if (cbOrders.SelectedValue is long orderId)
            {
                LoadInvoice(orderId);
            }
        }

        private void LoadInvoice(long orderId)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var db = new PharmacyDbContext())
                {
                    var order = db.Orders
                        .Include(o => o.Customer)
                        .Include(o => o.User)
                        .FirstOrDefault(o => o.OrderId == orderId);

                    object[] headerData;
                    object[] detailsData;

                    if (order == null)
                    {
                        headerData = new[]
                        {
                            new
                            {
                                OrderCode = "N/A",
                                OrderDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                                CustomerName = "Chưa có hóa đơn nào được chọn",
                                CustomerPhone = "N/A",
                                StaffName = "Dược sĩ trực quầy",
                                TotalAmount = 0m,
                                Discount = 0m,
                                NetAmount = 0m
                            }
                        };
                        detailsData = Array.Empty<object>();
                    }
                    else
                    {
                        headerData = new[]
                        {
                            new
                            {
                                OrderCode = order.OrderCode,
                                OrderDate = order.OrderDate.ToString("dd/MM/yyyy HH:mm:ss"),
                                CustomerName = order.Customer != null ? order.Customer.FullName : "Khách hàng vãng lai",
                                CustomerPhone = order.Customer != null ? order.Customer.Phone : "N/A",
                                StaffName = order.User != null ? order.User.FullName : "Dược sĩ trực quầy",
                                TotalAmount = order.TotalAmount,
                                Discount = order.Discount,
                                NetAmount = order.NetAmount
                            }
                        };

                        var detailsList = db.OrderDetails
                            .Include(od => od.ImportDetail)
                                .ThenInclude(id => id.Product)
                            .Where(od => od.OrderId == orderId)
                            .ToList();

                        int stt = 1;
                        detailsData = detailsList.Select(od => new
                        {
                            STT = stt++,
                            ProductName = od.ImportDetail.Product.ProductName,
                            SoldUnit = od.SoldUnit,
                            Quantity = od.Quantity,
                            Price = od.Price,
                            Amount = od.Amount
                        }).Cast<object>().ToArray();
                    }

                    reportViewer1.Reset();
                    string rptName = "rptOrderInvoice.rdlc";
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rptName);
                    reportViewer1.LocalReport.ReportPath = File.Exists(fullPath) ? fullPath : rptName;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsInvoiceHeader", headerData));
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsInvoiceDetails", detailsData));
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
