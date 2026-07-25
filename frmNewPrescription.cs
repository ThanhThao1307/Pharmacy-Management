using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmNewPrescription : Form
    {
        private long _orderId = 0;
        private System.Collections.Generic.List<string> _imagePaths = new System.Collections.Generic.List<string>();
        private System.Collections.Generic.List<bool> _isNewImage = new System.Collections.Generic.List<bool>();
        private int _currentImageIndex = 0;

        public long SavedPrescriptionFileId { get; private set; } = 0;

        public frmNewPrescription(long orderId = 0)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void frmNewPrescription_Load(object sender, EventArgs e)
        {
            txtPrescriptionId.Text = "(Tạo mới)";
            dtpUploadDate.Value = DateTime.Now;
            chkStatus.Checked = true;
            if (_orderId > 0)
            {
                txtNote.Text = $"Toa thuốc chỉ định cho Đơn hàng số #{_orderId}\r\n- Bác sĩ kê đơn: \r\n- Chẩn đoán bệnh: \r\n- Bệnh viện/Phòng khám: ";
            }
            else
            {
                txtNote.Text = "- Bác sĩ kê đơn: \r\n- Chẩn đoán bệnh: \r\n- Bệnh viện/Phòng khám: ";
            }
            _imagePaths.Clear();
            _isNewImage.Clear();
            _currentImageIndex = 0;
            UpdateImageNavigation();
        }

        private void ShowCurrentImage()
        {
            if (_imagePaths.Count == 0 || _currentImageIndex < 0 || _currentImageIndex >= _imagePaths.Count)
            {
                picPrescription.Image = null;
                return;
            }
            string path = _imagePaths[_currentImageIndex];
            if (File.Exists(path))
            {
                var oldImg = picPrescription.Image;
                picPrescription.Image = Utility.LoadBitmapWithoutLock(path);
                oldImg?.Dispose();
            }
        }

        private void UpdateImageNavigation()
        {
            if (_imagePaths.Count <= 1)
            {
                btPrevImage.Enabled = false;
                btNextImage.Enabled = false;
                lblImageCount.Text = _imagePaths.Count == 1 ? "Ảnh 1 / 1" : "Chưa có ảnh";
            }
            else
            {
                btPrevImage.Enabled = _currentImageIndex > 0;
                btNextImage.Enabled = _currentImageIndex < _imagePaths.Count - 1;
                lblImageCount.Text = $"Ảnh {_currentImageIndex + 1} / {_imagePaths.Count}";
            }
            if (_imagePaths.Count > 0)
            {
                txtFileName.Text = string.Join("; ", _imagePaths.Select(Path.GetFileName));
            }
        }

        private void btPrevImage_Click(object sender, EventArgs e)
        {
            if (_currentImageIndex > 0)
            {
                _currentImageIndex--;
                ShowCurrentImage();
                UpdateImageNavigation();
            }
        }

        private void btNextImage_Click(object sender, EventArgs e)
        {
            if (_currentImageIndex < _imagePaths.Count - 1)
            {
                _currentImageIndex++;
                ShowCurrentImage();
                UpdateImageNavigation();
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                ofd.Title = "Chọn hình ảnh / File Toa thuốc (Có thể chọn nhiều ảnh cùng lúc)";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _imagePaths.Clear();
                    _isNewImage.Clear();
                    foreach (var f in ofd.FileNames)
                    {
                        _imagePaths.Add(f);
                        _isNewImage.Add(true);
                    }
                    _currentImageIndex = 0;
                    ShowCurrentImage();
                    UpdateImageNavigation();
                    txtFilePath.Text = $"(Đã chọn {_imagePaths.Count} ảnh - Bấm Lưu để cập nhật)";
                }
            }
        }

        private void btAddMoreImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                ofd.Title = "Thêm ảnh Toa thuốc khác vào hồ sơ (Có thể chọn nhiều ảnh)";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in ofd.FileNames)
                    {
                        _imagePaths.Add(f);
                        _isNewImage.Add(true);
                    }
                    _currentImageIndex = _imagePaths.Count - 1;
                    ShowCurrentImage();
                    UpdateImageNavigation();
                    txtFilePath.Text = $"(Đã thêm ảnh - Tổng {_imagePaths.Count} ảnh trong hồ sơ)";
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (_imagePaths.Count == 0)
            {
                if (_orderId > 0)
                {
                    if (MessageBox.Show($"Bạn chưa tải lên ảnh Toa thuốc bác sĩ cho đơn hàng #{_orderId}.\r\nNếu trong đơn hàng có THUỐC KÊ ĐƠN (GPP), hệ thống sẽ từ chối thêm thuốc đó nếu hồ sơ không có ảnh.\r\nBạn có chắc chắn muốn lưu chỉ với thông tin ghi chú không?", "Cảnh báo chuẩn GPP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                else if (MessageBox.Show("Bạn chưa chọn hình ảnh cho Toa thuốc này. Bạn có chắc chắn muốn lưu chỉ với thông tin ghi chú thẩm định không?", "Xác nhận thiếu ảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                System.Collections.Generic.List<string> savedRelativePaths = new System.Collections.Generic.List<string>();
                if (!Directory.Exists(Utility.PrescriptionPath))
                {
                    Directory.CreateDirectory(Utility.PrescriptionPath);
                }

                using (var db = new PharmacyDbContext())
                {
                    // [HỆ THỐNG KIỂM TRA GIAN LẬN - MD5 HASH]
                    long? currentCustomerId = null;
                    if (_orderId > 0)
                    {
                        var currOrder = db.Orders.Find(_orderId);
                        if (currOrder != null) currentCustomerId = currOrder.CustomerId;
                    }

                    string md5Notes = "";

                    for (int i = 0; i < _imagePaths.Count; i++)
                    {
                        if (_isNewImage[i] && File.Exists(_imagePaths[i]))
                        {
                            string fileHash = Utility.ComputeMD5(_imagePaths[i]);
                            var existingFile = db.PrescriptionFiles.FirstOrDefault(p => p.Note != null && p.Note.Contains("[MD5:" + fileHash + "]"));
                            
                            if (existingFile != null)
                            {
                                var prevOrder = db.Orders.FirstOrDefault(o => o.PrescriptionFileId == existingFile.PrescriptionFileId);
                                if (prevOrder != null)
                                {
                                    if (prevOrder.CustomerId != currentCustomerId)
                                    {
                                        MessageBox.Show($"Phát hiện gian lận: Hình ảnh này đã được sử dụng cho toa thuốc của một khách hàng khác (Mã toa: {existingFile.PrescriptionFileId})!\r\nTuyệt đối không được dùng 1 ảnh toa thuốc cho nhiều khách hàng khác nhau.", "Cảnh báo bảo mật GPP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    
                                    if ((DateTime.Now - existingFile.UploadDate).TotalDays > 30)
                                    {
                                        MessageBox.Show($"Toa thuốc này của khách hàng đã quá hạn sử dụng (vượt quá 30 ngày kể từ ngày tải lên: {existingFile.UploadDate:dd/MM/yyyy}).\r\nVui lòng yêu cầu khách hàng đi khám lại và cung cấp toa thuốc mới!", "Cảnh báo GPP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                            }

                            md5Notes += $"[MD5:{fileHash}] ";
                            
                            string ext = Path.GetExtension(_imagePaths[i]);
                            string newName = $"Toa_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString().Substring(0, 6)}{ext}";
                            string destPath = Path.Combine(Utility.PrescriptionPath, newName);
                            File.Copy(_imagePaths[i], destPath, true);
                            savedRelativePaths.Add(newName);
                        }
                        else
                        {
                            savedRelativePaths.Add(_imagePaths[i]);
                        }
                    }

                string relativePath = string.Join(";", savedRelativePaths);

                    var p = new PrescriptionFile
                    {
                        FileName = string.IsNullOrWhiteSpace(txtFileName.Text) ? "Toa_Thuoc_GPP" : txtFileName.Text.Trim(),
                        FilePath = relativePath,
                        UploadDate = dtpUploadDate.Value,
                        Status = chkStatus.Checked,
                        Note = txtNote.Text.Trim() + (string.IsNullOrEmpty(md5Notes) ? "" : "\r\n" + md5Notes)
                    };

                    db.PrescriptionFiles.Add(p);
                    db.SaveChanges();

                    SavedPrescriptionFileId = p.PrescriptionFileId;

                    if (_orderId > 0)
                    {
                        var order = db.Orders.Find(_orderId);
                        if (order != null)
                        {
                            order.PrescriptionFileId = p.PrescriptionFileId;
                            db.SaveChanges();
                        }
                    }

                    MessageBox.Show($"Lập hồ sơ Toa thuốc GPP #{SavedPrescriptionFileId} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.MdiParent is frmMain mainForm)
                    {
                        mainForm.OpenChildForm(new frmManagePrescription());
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu Toa thuốc: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is frmMain mainForm)
            {
                mainForm.OpenChildForm(new frmManagePrescription());
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
