using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_Nhom1.Models
{
    public partial class OrderDetail
    {
        [Key]
        public long OrderDetailId { get; set; }

        [Required]
        public long OrderId { get; set; }

        [Required]
        public long ImportDetailId { get; set; } // Xác định bán từ lô nào (Từ đây truy vấn bắc cầu ra ProductId)

        [Required]
        [StringLength(50)]
        public string SoldUnit { get; set; } = null!;

        [Required]
        public int ConversionRate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [NotMapped]
        public int QuantityInSmallestUnit => Quantity * ConversionRate;

        [NotMapped]
        public decimal Amount => Quantity * Price;

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; } = null!;

        [ForeignKey("ImportDetailId")]
        public virtual ImportDetail ImportDetail { get; set; } = null!;
    }
}