using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class FurnitureStock
    {
        [Key]
        [Column(Order = 1)]
        public int Party { get; set; }
        [Key]
        [Column(Order = 2)]
        public string FurnitureId { get; set; }
        public Furniture Furniture { get; set; }
        public int Quantity { get; set; }
    }
}
