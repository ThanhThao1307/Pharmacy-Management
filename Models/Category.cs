using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Nhom1.Models
{
    public partial class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100, ErrorMessage = "Tên danh mục không quá 100 ký tự")]
        public string CategoryName { get; set; } = null!;

        [StringLength(500, ErrorMessage = "Mô tả không quá 500 ký tự")]
        public string? Description { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Mã danh mục không được để trống")]
        public string CategoryCode { get; set; } = null!;

        [Required]
        public bool Status { get; set; } = true;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}