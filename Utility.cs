using System;
using System.IO;
using System.Drawing;

namespace Pharmacy_Nhom1
{
    public static class Utility
    {
        public static Pharmacy_Nhom1.Models.User CurrentUser { get; set; } = null!;
        public static bool IsAdmin => CurrentUser != null && CurrentUser.Role?.RoleName == "Admin";
        public static bool IsEmployee => CurrentUser != null && CurrentUser.Role?.RoleName == "Employee";

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

        public static string PrescriptionPath
        {
            get
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string dir = baseDir;
                string? projectRootDir = null;
                for (int i = 0; i < 5; i++)
                {
                    string checkDir = Path.Combine(dir, "Prescriptions");
                    if (Directory.Exists(checkDir))
                    {
                        return checkDir + Path.DirectorySeparatorChar;
                    }
                    if (Directory.Exists(Path.Combine(dir, "Images")) && projectRootDir == null)
                    {
                        projectRootDir = dir;
                    }
                    var parent = Directory.GetParent(dir);
                    if (parent == null) break;
                    dir = parent.FullName;
                }
                string fallback = projectRootDir != null ? Path.Combine(projectRootDir, "Prescriptions") : Path.Combine(baseDir, "Prescriptions");
                if (!Directory.Exists(fallback))
                {
                    Directory.CreateDirectory(fallback);
                }
                return fallback + Path.DirectorySeparatorChar;
            }
        }

        public static Image? LoadBitmapWithoutLock(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath)) return null;
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var tempImage = Image.FromStream(stream))
                    {
                        return new Bitmap(tempImage);
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public static string ComputeMD5(string filePath)
        {
            if (!File.Exists(filePath)) return string.Empty;
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

    }
}
