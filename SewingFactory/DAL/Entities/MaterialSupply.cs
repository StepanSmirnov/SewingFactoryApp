using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.DAL.Entities
{
    public class MaterialSupply
    {
        public string MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int Quantity { get; set; }

        public double Price
        {
            get
            {
                return Material.Price * Quantity;
            }
        }

    }
}
