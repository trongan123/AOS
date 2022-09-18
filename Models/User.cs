using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Shop.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            WarehouseDetails = new HashSet<WarehouseDetail>();
            Warehouses = new HashSet<Warehouse>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter Name.")]
        [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        public string Fullname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public int Status { get; set; }
        public string RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<WarehouseDetail> WarehouseDetails { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
