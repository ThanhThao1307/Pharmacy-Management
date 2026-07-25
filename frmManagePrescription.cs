using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmManagePrescription : Form
    {
        public frmManagePrescription()
        {
            InitializeComponent();
            dgvPrescriptions.AutoGenerateColumns = false;
        }

        private void frmManagePrescription_Load(object sender, EventArgs e)
        {
            pnlTitle.Visible = false; // Ẩn tiêu đề lặp
            cbStatus.SelectedIndex = 0; // Tất cả
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;

            // Đăng ký sự kiện sau khi đã set giá trị mặc định để tránh gọi LoadData nhiều lần
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;

            LoadData();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var query = db.PrescriptionFiles.AsQueryable();

                    // Lọc theo từ khóa tìm kiếm
                    string keyword = txtSearch.Text.Trim().ToLower();
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(p => p.FileName.ToLower().Contains(keyword) ||
                                                 (!string.IsNullOrEmpty(p.Note) && p.Note.ToLower().Contains(keyword)) ||
                                                 p.PrescriptionFileId.ToString().Contains(keyword));
                    }

                    // Toa thuốc GPP chỉ có hiệu lực 5 ngày kể từ ngày kê đơn (UploadDate)
                    DateTime limitDate = DateTime.Now.Date.AddDays(-5);

                    // Lọc theo trạng thái
                    if (cbStatus.SelectedIndex == 1) // Hợp lệ
                    {
                        query = query.Where(p => p.Status && p.UploadDate >= limitDate);
                    }
                    else if (cbStatus.SelectedIndex == 2) // Hết hiệu lực
                    {
                        query = query.Where(p => !p.Status || p.UploadDate < limitDate);
                    }

                    // Lọc theo khoảng ngày
                    DateTime from = dtpFromDate.Value.Date;
                    DateTime to = dtpToDate.Value.Date.AddDays(1).AddTicks(-1);
                    query = query.Where(p => p.UploadDate >= from && p.UploadDate <= to);

                    var rawList = query.OrderByDescending(p => p.UploadDate).ToList();

                    // Lấy mã hóa đơn liên kết (nếu có)
                    var orderMap = db.Orders.Where(o => o.PrescriptionFileId != null)
                                            .ToDictionary(o => o.PrescriptionFileId!.Value, o => new { o.OrderId, o.OrderCode });

                    var list = new List<PrescriptionViewModel>();
                    foreach (var p in rawList)
                    {
                        string orderCodeStr = "(Chưa gán HĐ)";
                        long linkedOrderId = 0;
                        if (orderMap.ContainsKey(p.PrescriptionFileId))
                        {
                            orderCodeStr = orderMap[p.PrescriptionFileId].OrderCode;
                            linkedOrderId = orderMap[p.PrescriptionFileId].OrderId;
                        }

                        bool isValid = p.Status && p.UploadDate >= limitDate;

                        list.Add(new PrescriptionViewModel
                        {
                            PrescriptionFileId = p.PrescriptionFileId,
                            FileName = p.FileName,
                            UploadDateText = p.UploadDate.ToString("dd/MM/yyyy HH:mm"),
                            OrderCode = orderCodeStr,
                            LinkedOrderId = linkedOrderId,
                            Note = p.Note ?? string.Empty,
                            StatusText = isValid ? "✔ Hợp lệ" : "❌ Hết hiệu lực"
                        });
                    }

                    dgvPrescriptions.DataSource = list;
                    lblCount.Text = $"Tổng số hồ sơ toa thuốc GPP: {list.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hồ sơ toa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                mainForm.OpenChildForm(new frmNewPrescription(0));
            }
            else
            {
                using (var frm = new frmNewPrescription(0))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void dgvPrescriptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvPrescriptions.Rows[e.RowIndex].DataBoundItem is PrescriptionViewModel item)
            {
                string colName = dgvPrescriptions.Columns[e.ColumnIndex].Name;

                if (colName == "colEdit")
                {
                    if (this.MdiParent is frmMain mainForm)
                    {
                        mainForm.OpenChildForm(new frmEditPrescription(item.PrescriptionFileId, item.LinkedOrderId));
                    }
                    else
                    {
                        using (var frm = new frmEditPrescription(item.PrescriptionFileId, item.LinkedOrderId))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadData();
                            }
                        }
                    }
                }
                else if (colName == "colDelete")
                {
                    if (item.LinkedOrderId > 0)
                    {
                        MessageBox.Show($"Hồ sơ toa thuốc này đang được đính kèm vào hóa đơn '{item.OrderCode}'.\r\nBạn không thể xóa trực tiếp toa thuốc đã gắn vào giao dịch bán hàng!", "Ràng buộc GPP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (MessageBox.Show($"Bạn có chắc chắn muốn xóa hồ sơ toa thuốc số #{item.PrescriptionFileId} ('{item.FileName}') không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            using (var db = new PharmacyDbContext())
                            {
                                var p = db.PrescriptionFiles.Find(item.PrescriptionFileId);
                                if (p != null)
                                {
                                    db.PrescriptionFiles.Remove(p);
                                    db.SaveChanges();
                                    MessageBox.Show("Xóa hồ sơ toa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa hồ sơ toa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }

    public class PrescriptionViewModel
    {
        public long PrescriptionFileId { get; set; }
        public string FileName { get; set; } = null!;
        public string UploadDateText { get; set; } = null!;
        public string OrderCode { get; set; } = null!;
        public long LinkedOrderId { get; set; }
        public string Note { get; set; } = null!;
        public string StatusText { get; set; } = null!;
    }
}
