using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_Nhom1.Models
{
    public partial class Import
    {
        [Key]
        public long ImportId { get; set; }

        [Required(ErrorMessage = "Mã phiếu nhập không được để trống")]
        [StringLength(50)]
        public string ImportCode { get; set; } = null!;

        [Required]
        public long SupplierId { get; set; }

        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; } = null!; // Lưu tên người nhập trực tiếp bằng chuỗi, không tạo khóa ngoại liên kết sang bảng Users

        [Required]
        public DateTime ImportDate { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalAmount { get; set; } = 0;

        [Required]
        public byte Status { get; set; } // 1: Hoàn thành, 0: Nháp, 2: Hủy

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; } = null!;

        public virtual ICollection<ImportDetail> ImportDetails { get; set; } = new List<ImportDetail>();
    }
}