using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SawingFactory.DAL.Entities
{
    public class Order
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime Date { get; set; }
        [Required]
        public string Stage { get; set; }
        //[ForeignKey("Login")]
        //public string CustomerLogin { get; set; }
        //[ForeignKey("Password")]
        //public string CustomerPassword { get; set; }
        //[ForeignKey("CustomerLogin, CusotomerPassword")]
        [Required]
        public virtual User Customer { get; set; }
        //[ForeignKey("Login")]
        //public string ManagerLogin { get; set; }
        //[ForeignKey("Password")]
        //public string ManagerPassword { get; set; }
        //[ForeignKey("ManagerLogin, ManagerPassword")]
        public virtual User Manager { get; set; }
        public double? Price { get; set; }
    }

}
