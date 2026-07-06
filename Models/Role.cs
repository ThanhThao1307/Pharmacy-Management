using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Nhom1.Models
{
    public partial class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; } = string.Empty;

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}