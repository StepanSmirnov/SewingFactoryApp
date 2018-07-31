using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class User
    {
        [Key]
        [Column(Order = 1)]
        public string Login { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        public string Name { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Order> CreatedOrders { get; set; }
        [InverseProperty("Manager")]
        public virtual ICollection<Order> ManagedOrders { get; set; }
    }
}
