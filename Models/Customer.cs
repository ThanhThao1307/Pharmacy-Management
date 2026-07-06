using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Nhom1.Models
{
    public partial class Customer
    {
        [Key]
        public long CustomerId { get; set; }

        [Required(ErrorMessage = "Nhập mã khách hàng")]
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;

        [Required(ErrorMessage = "Không được để trống tên khách hàng")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;

        /// <summary>Giới tính: true = Nam, false = Nữ, null = Chưa xác định</summary>
        public bool? Gender { get; set; }

        /// <summary>Ngày tháng năm sinh</summary>
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "Nhập số điện thoại liên hệ")]
        [StringLength(15)]
        public string Phone { get; set; } = null!;

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string? Email { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public decimal TotalSpent { get; set; } = 0;

        [Required]
        public int LoyaltyPoints { get; set; } = 0;

        [Required]
        [StringLength(50)]
        public string CustomerGroup { get; set; } = "Thường";

        [Required]
        public bool IsActive { get; set; } = true;

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}