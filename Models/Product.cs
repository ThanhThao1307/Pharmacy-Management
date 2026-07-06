using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Pharmacy_Nhom1.Models
{
    public partial class Product
    {
        [Key]
        public long ProductId { get; set; }

        [Required(ErrorMessage = "Nhập mã thuốc")]
        [StringLength(50)]
        public string ProductCode { get; set; } = null!;

        [Required(ErrorMessage = "Nhập tên thuốc")]
        [StringLength(200)]
        public string ProductName { get; set; } = null!;

        [Required(ErrorMessage = "Vui lòng chọn danh mục thuốc")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Nhập đơn vị tính nhỏ nhất")]
        [StringLength(50)]
        public string Unit { get; set; } = null!;

        public decimal? NormalPrice { get; set; }

        [Required(ErrorMessage = "Nhập giá bán đơn vị nhỏ nhất")]
        public decimal Price { get; set; }

        [Required]
        public bool PrescriptionRequired { get; set; }

        [Required]
        public bool Status { get; set; } = true;

        /// <summary>Mô tả thuốc: công dụng, thành phần, hướng dẫn sử dụng...</summary>
        [StringLength(2000)]
        public string? Description { get; set; }

        /// <summary>Tên file hình ảnh sản phẩm (lưu trong thư mục Images của dự án)</summary>
        [StringLength(200)]
        public string? ImageFile { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;

        public virtual ICollection<ProductUnit> ProductUnits { get; set; } = new List<ProductUnit>();
        public virtual ICollection<ImportDetail> ImportDetails { get; set; } = new List<ImportDetail>();

        [NotMapped]
        public int TotalStock => ImportDetails?
            .Where(id => id.ExpiryDate.Date >= DateTime.Today)
            .Sum(id => id.CurrentQuantity) ?? 0;
    }
}