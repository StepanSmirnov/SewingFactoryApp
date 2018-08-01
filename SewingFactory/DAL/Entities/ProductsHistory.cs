using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class ProductsHistory
    {
        [Key]
        public int SpecId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<ProductsFurnitureHisotry> Furnitures { get; set; }
    }
}
