using System;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Nhom1.Models
{
    public partial class PrescriptionFile
    {
        [Key]
        public long PrescriptionFileId { get; set; }

        [Required(ErrorMessage = "Tên file không được để trống")]
        [StringLength(200)]
        public string FileName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Đường dẫn file không được để trống")]
        [StringLength(500)]
        public string FilePath { get; set; } = string.Empty;

        [Required]
        public bool Status { get; set; } = true;

        [StringLength(500)]
        public string? Note { get; set; }

        [Required]
        public DateTime UploadDate { get; set; } = DateTime.Now;
    }
}