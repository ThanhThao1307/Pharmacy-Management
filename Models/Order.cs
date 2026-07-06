using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_Nhom1.Models
{
    public partial class Order
    {
        [Key]
        public long OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderCode { get; set; } = null!;

        public long? CustomerId { get; set; }

        [Required]
        public long UserId { get; set; }

        public long? PrescriptionFileId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalAmount { get; set; } = 0;

        [Required]
        public decimal Discount { get; set; } = 0;

        [Required]
        public decimal NetAmount { get; set; } = 0;

        [Required]
        public bool Status { get; set; } // 0: Đã thanh toán, 1: Hủy

        [ForeignKey("CustomerId")]
        public virtual Customer? Customer { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;

        [ForeignKey("PrescriptionFileId")]
        public virtual PrescriptionFile? PrescriptionFile { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}