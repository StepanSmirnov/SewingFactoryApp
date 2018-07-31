using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class ProductsFurnitureHisotry
    {
        [Key]
        [Column(Order =1)]
        public int SpecId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int FurnitureId { get; set; }
        public virtual Furniture Furniture { get; set; }

        [Required]
        public string Placing { get; set; }
        public double? Width { get; set; }
        public string WidthUnit { get; set; }
        public double? Length { get; set; }
        public string LengthUnit { get; set; }
        public double? Rotation { get; set; }
        public int Quantity { get; set; }
    }
}
