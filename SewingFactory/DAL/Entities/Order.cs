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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime Date { get; set; }
        [Required]
        public string Stage { get; set; }
        public string CustomerLogin { get; set; }
        public string CustomerPassword { get; set; }
        [Required]
        [ForeignKey("CustomerLogin, CustomerPassword")]
        public virtual User Customer { get; set; }
        //[ForeignKey("Login")]
        public string ManagerLogin { get; set; }
        //[ForeignKey("Password")]
        public string ManagerPassword { get; set; }
        [ForeignKey("ManagerLogin, ManagerPassword")]
        public virtual User Manager { get; set; }
        public double? Price { get; set; }
    }

}
