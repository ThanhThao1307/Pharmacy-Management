using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Nhom1.Models
{
    public partial class Supplier
    {
        [Key]
        public long SupplierId { get; set; }

        [Required(ErrorMessage = "Tên nhà cung cấp không được để trống")]
        [StringLength(200)]
        public string SupplierName { get; set; } = null!;

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(15)]
        public string Phone { get; set; } = null!;

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mã số thuế không được để trống")]
        [StringLength(50)]
        public string TaxCode { get; set; } = null!;

        [StringLength(200)]
        public string? Address { get; set; }

        [Required]
        public bool Status { get; set; } = true;

        public virtual ICollection<Import> Imports { get; set; } = new List<Import>();
    }
}