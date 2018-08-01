using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.DAL.Entities
{
    public class FurnitureStock
    {
        public FurnitureStock()
        {
        }

        public FurnitureStock(Furniture furniture)
        {
            Furniture = furniture;
            FurnitureId = furniture.FurnitureId;
        }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Party { get; set; }
        [Key]
        [Column(Order = 2)]
        public string FurnitureId { get; set; }
        public virtual Furniture Furniture { get; set; }
        public int Quantity { get; set; }
    }
}
