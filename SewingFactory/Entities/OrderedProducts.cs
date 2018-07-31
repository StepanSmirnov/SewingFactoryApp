using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class OrderedProducts
    {
        [Key]
        [Column(Order = 1)]
        public string ProductId { get; set; }
        public Product Product { get; set; }
        [Key]
        [Column(Order = 2)]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }
    }
}
