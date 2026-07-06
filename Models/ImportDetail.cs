using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_Nhom1.Models
{
    public partial class ImportDetail
    {
        [Key]
        public long ImportDetailId { get; set; }

        [Required]
        public long ImportId { get; set; }

        [Required]
        public long ProductId { get; set; }

        [Required(ErrorMessage = "Nhập số lô thuốc")]
        [StringLength(100)]
        public string BatchNumber { get; set; } = null!;

        [Required(ErrorMessage = "Nhập hạn sử dụng thuốc")]
        public DateTime ExpiryDate { get; set; }

        // Mọi số lượng lưu trữ trong kho quy về đơn vị nhỏ nhất để đảm bảo tính đồng nhất
        [Required(ErrorMessage = "Nhập số lượng nhập gốc")]
        public int OriginalQuantity { get; set; }

        [Required]
        public int CurrentQuantity { get; set; } // Số lượng còn lại thực tế trong kho của lô này

        [Required(ErrorMessage = "Nhập giá nhập")]
        public decimal ImportPrice { get; set; } // Tính trên đơn vị gốc nhỏ nhất

        [NotMapped]
        public decimal Amount => OriginalQuantity * ImportPrice;

        [NotMapped]
        public bool IsExpired => ExpiryDate.Date < DateTime.Today;

        [ForeignKey("ImportId")]
        public virtual Import Import { get; set; } = null!;

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; } = null!;
    }
}