using System;
using System.IO;
using System.Drawing;

namespace Pharmacy_Nhom1
{
    public static class Utility
    {
        // Quản lý phiên đăng nhập (gom từ SessionManager để giảm số file)
        public static Pharmacy_Nhom1.Models.User CurrentUser { get; set; } = null!;
        public static bool IsAdmin => CurrentUser?.Role?.RoleName?.Equals("Admin", StringComparison.OrdinalIgnoreCase) == true;
        public static bool IsEmployee => CurrentUser?.Role?.RoleName?.Equals("Nhân viên", StringComparison.OrdinalIgnoreCase) == true;

        public static void Logout()
        {
            CurrentUser = null!;
        }

        public static string ImagePath
        {
            get
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string dir = baseDir;
                for (int i = 0; i < 5; i++)
                {
                    string checkDir = Path.Combine(dir, "Images");
                    if (Directory.Exists(checkDir))
                    {
                        return checkDir + Path.DirectorySeparatorChar;
                    }
                    var parent = Directory.GetParent(dir);
                    if (parent == null) break;
                    dir = parent.FullName;
                }
                string fallback = Path.Combine(baseDir, "Images");
                if (!Directory.Exists(fallback))
                {
                    Directory.CreateDirectory(fallback);
                }
                return fallback + Path.DirectorySeparatorChar;
            }
        }

        // Hàm load ảnh an toàn từ file, tạo bản sao độc lập trong RAM để không bao giờ bị khóa file (lock file) trên hệ thống
        public static Image? LoadBitmapWithoutLock(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath)) return null;
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var tempImage = Image.FromStream(stream))
                    {
                        return new Bitmap(tempImage); // Tạo bản sao độc lập trong bộ nhớ, ngắt hoàn toàn kết nối với file trên đĩa
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
