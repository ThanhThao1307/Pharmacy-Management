using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_Nhom1.Models
{
    public partial class ProductUnit
    {
        [Key]
        public long ProductUnitId { get; set; }

        [Required]
        public long ProductId { get; set; }

        [Required(ErrorMessage = "Nhập tên đơn vị quy đổi")]
        [StringLength(50)]
        public string UnitName { get; set; } = null!; // Ví dụ: Vỉ, Hộp

        [Required(ErrorMessage = "Nhập tỉ lệ quy đổi")]
        public int ConversionRate { get; set; } // Hệ số quy đổi ra đơn vị gốc (Ví dụ: Vỉ = 10)

        [Required(ErrorMessage = "Nhập giá bán cho đơn vị quy đổi này")]
        public decimal Price { get; set; } // Giá bán lẻ ra thị trường của đơn vị này

        public decimal? ImportPrice { get; set; } // Giá nhập sỉ (được ghi từ phiếu nhập kho)

        [NotMapped]
        public decimal DisplayRatio { get; set; } // Số lượng đơn vị lẻ trong 1 Đơn vị sỉ (ví dụ: 1 Hộp = 100 Viên -> DisplayRatio của Viên = 100)

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; } = null!;
    }
}