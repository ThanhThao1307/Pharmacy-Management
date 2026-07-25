using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Nhom1.Models;

namespace Pharmacy_Nhom1
{
    public partial class frmEditPrescription : Form
    {
        private long _prescriptionFileId = 0;
        private long _orderId = 0;
        private System.Collections.Generic.List<string> _imagePaths = new System.Collections.Generic.List<string>();
        private System.Collections.Generic.List<bool> _isNewImage = new System.Collections.Generic.List<bool>();
        private int _currentImageIndex = 0;

        public long SavedPrescriptionFileId { get; private set; } = 0;

        public frmEditPrescription(long prescriptionFileId, long orderId = 0)
        {
            InitializeComponent();
            _prescriptionFileId = prescriptionFileId;
            _orderId = orderId;
        }

        private void frmEditPrescription_Load(object sender, EventArgs e)
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

                    _imagePaths.Clear();
                    _isNewImage.Clear();
                    if (!string.IsNullOrEmpty(p.FilePath))
                    {
                        var parts = p.FilePath.Split(';', StringSplitOptions.RemoveEmptyEntries);
                        foreach (var part in parts)
                        {
                            _imagePaths.Add(part.Trim());
                            _isNewImage.Add(false);
                        }
                    }
                    _currentImageIndex = 0;
                    ShowCurrentImage();
                    UpdateImageNavigation();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ Toa thuốc này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void ShowCurrentImage()
        {
            if (_imagePaths.Count == 0 || _currentImageIndex < 0 || _currentImageIndex >= _imagePaths.Count)
            {
                picPrescription.Image = null;
                return;
            }
            string path = _imagePaths[_currentImageIndex];
            string fullPath = _isNewImage[_currentImageIndex] ? path : Path.Combine(Utility.PrescriptionPath, path);
            if (File.Exists(fullPath))
            {
                var oldImg = picPrescription.Image;
                picPrescription.Image = Utility.LoadBitmapWithoutLock(fullPath);
                oldImg?.Dispose();
            }
            else
            {
                picPrescription.Image = null;
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
            if (_imagePaths.Count > 0 && _isNewImage.Any(n => n))
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
                ofd.Title = "Chọn ảnh mới thay thế toàn bộ cho Toa thuốc (Có thể chọn nhiều ảnh)";
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
                    txtFilePath.Text = $"(Đã thay đổi sang {_imagePaths.Count} ảnh - Bấm LƯU để cập nhật)";
                }
            }
        }

        private void btAddMoreImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                ofd.Title = "Thêm ảnh Toa thuốc khác vào hồ sơ hiện tại (Có thể chọn nhiều ảnh)";
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
                    txtFilePath.Text = $"(Đã bổ sung ảnh - Tổng {_imagePaths.Count} ảnh - Bấm LƯU để cập nhật)";
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    var p = db.PrescriptionFiles.Find(_prescriptionFileId);
                    if (p == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi Toa thuốc để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    System.Collections.Generic.List<string> savedRelativePaths = new System.Collections.Generic.List<string>();
                    if (!Directory.Exists(Utility.PrescriptionPath))
                    {
                        Directory.CreateDirectory(Utility.PrescriptionPath);
                    }

                    // HỆ THỐNG KIỂM TRA GIAN LẬN - MD5 HASH
                    long? currentCustomerId = null;
                    if (_orderId > 0)
                    {
                        var currOrder = db.Orders.Find(_orderId);
                        if (currOrder != null) currentCustomerId = currOrder.CustomerId;
                    }
                    else
                    {
                        var currOrder = db.Orders.FirstOrDefault(o => o.PrescriptionFileId == _prescriptionFileId);
                        if (currOrder != null) currentCustomerId = currOrder.CustomerId;
                    }

                    string md5Notes = "";

                    for (int i = 0; i < _imagePaths.Count; i++)
                    {
                        if (_isNewImage[i] && File.Exists(_imagePaths[i]))
                        {
                            string fileHash = Utility.ComputeMD5(_imagePaths[i]);
                            var existingFile = db.PrescriptionFiles.FirstOrDefault(px => px.Note != null && px.Note.Contains("[MD5:" + fileHash + "]") && px.PrescriptionFileId != _prescriptionFileId);
                            
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
                    p.FilePath = relativePath;
                    p.FileName = string.IsNullOrWhiteSpace(txtFileName.Text) ? "Toa_Thuoc_GPP" : txtFileName.Text.Trim();
                    p.UploadDate = dtpUploadDate.Value;
                    p.Status = chkStatus.Checked;
                    p.Note = txtNote.Text.Trim() + (string.IsNullOrEmpty(md5Notes) ? "" : "\r\n" + md5Notes);

                    db.SaveChanges();
                    SavedPrescriptionFileId = p.PrescriptionFileId;

                    if (_orderId > 0)
                    {
                        var order = db.Orders.Find(_orderId);
                        if (order != null && order.PrescriptionFileId != p.PrescriptionFileId)
                        {
                            order.PrescriptionFileId = p.PrescriptionFileId;
                            db.SaveChanges();
                        }
                    }

                    MessageBox.Show($"Cập nhật Toa thuốc GPP #{SavedPrescriptionFileId} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Lỗi khi cập nhật Toa thuốc: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
