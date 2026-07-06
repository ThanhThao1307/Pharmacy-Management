using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmPrescriptionDetail : Form
    {
        private long _prescriptionFileId = 0;
        private long _orderId = 0;
        private string _selectedSourcePath = string.Empty;

        public long SavedPrescriptionFileId { get; private set; } = 0;

        public frmPrescriptionDetail(long prescriptionFileId = 0, long orderId = 0)
        {
            InitializeComponent();
            _prescriptionFileId = prescriptionFileId;
            _orderId = orderId;
        }

        private void frmPrescriptionDetail_Load(object sender, EventArgs e)
        {
            if (_prescriptionFileId > 0)
            {
                using (var db = new PharmacyDbContext())
                {
                    var p = db.PrescriptionFiles.Find(_prescriptionFileId);
                    if (p != null)
                    {
                        txtPrescriptionId.Text = p.PrescriptionFileId.ToString();
                        txtFileName.Text = p.FileName;
                        txtFilePath.Text = p.FilePath;
                        dtpUploadDate.Value = p.UploadDate;
                        chkStatus.Checked = p.Status;
                        txtNote.Text = p.Note;

                        if (!string.IsNullOrEmpty(p.FilePath))
                        {
                            string imgPath = Path.Combine(Utility.ImagePath, p.FilePath);
                            picPrescription.Image = Utility.LoadBitmapWithoutLock(imgPath);
                        }
                    }
                }
            }
            else
            {
                txtPrescriptionId.Text = "(Tạo mới)";
                dtpUploadDate.Value = DateTime.Now;
                chkStatus.Checked = true;
                txtNote.Text = _orderId > 0 ? $"Toa thuốc chỉ định cho Đơn hàng số #{_orderId}\r\n- Bác sĩ kê đơn: \r\n- Chẩn đoán bệnh: \r\n- Bệnh viện/Phòng khám: " : "- Bác sĩ kê đơn: \r\n- Chẩn đoán bệnh: \r\n- Bệnh viện/Phòng khám: ";
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedSourcePath = ofd.FileName;
                    txtFileName.Text = Path.GetFileName(_selectedSourcePath);

                    var oldImg = picPrescription.Image;
                    picPrescription.Image = Utility.LoadBitmapWithoutLock(_selectedSourcePath);
                    oldImg?.Dispose();
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Vui lòng chọn file ảnh toa thuốc trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new PharmacyDbContext())
                {
                    PrescriptionFile pFile;
                    if (_prescriptionFileId > 0)
                    {
                        pFile = db.PrescriptionFiles.Find(_prescriptionFileId)!;
                        if (pFile == null)
                        {
                            MessageBox.Show("Không tìm thấy hồ sơ toa thuốc để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        pFile = new PrescriptionFile();
                        db.PrescriptionFiles.Add(pFile);
                    }

                    pFile.FileName = txtFileName.Text.Trim();
                    pFile.UploadDate = dtpUploadDate.Value;
                    pFile.Status = chkStatus.Checked;
                    pFile.Note = txtNote.Text.Trim();

                    db.SaveChanges(); // Lần 1 để lấy ID khi tạo mới

                    // Nếu có tải ảnh mới lên từ nút Chọn ảnh
                    if (!string.IsNullOrEmpty(_selectedSourcePath) && File.Exists(_selectedSourcePath))
                    {
                        string ext = Path.GetExtension(_selectedSourcePath);
                        string newFileName = $"Prescription_{pFile.PrescriptionFileId}{ext}";
                        string destPath = Path.Combine(Utility.ImagePath, newFileName);

                        var previewImg = picPrescription.Image;
                        picPrescription.Image = null;
                        previewImg?.Dispose();

                        string fullSource = Path.GetFullPath(_selectedSourcePath);
                        string fullDest = Path.GetFullPath(destPath);
                        if (!string.Equals(fullSource, fullDest, StringComparison.OrdinalIgnoreCase))
                        {
                            File.Copy(_selectedSourcePath, destPath, true);
                        }

                        pFile.FilePath = newFileName;
                        db.SaveChanges(); // Lần 2 lưu FilePath
                        picPrescription.Image = Utility.LoadBitmapWithoutLock(destPath);
                    }

                    // Nếu form mở từ 1 Đơn hàng cụ thể thì gắn Toa thuốc này cho Đơn hàng đó
                    if (_orderId > 0)
                    {
                        var order = db.Orders.Find(_orderId);
                        if (order != null)
                        {
                            order.PrescriptionFileId = pFile.PrescriptionFileId;
                            db.SaveChanges();
                        }
                    }

                    SavedPrescriptionFileId = pFile.PrescriptionFileId;
                    MessageBox.Show("Lưu thẩm định hồ sơ toa thuốc thành công!", "GPP Compliance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hồ sơ toa thuốc: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} // namespace Pharmacy_Nhom1
