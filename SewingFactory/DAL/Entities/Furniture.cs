using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class Furniture
    {
        [Key]
        public string FurnitureId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double? Width { get; set; }
        public string WidthUnit { get; set; }
        public double? Length { get; set; }
        public string LengthUnit { get; set; }
        public double? Weight { get; set; }
        public string WeightUnit { get; set; }
        public byte[] Image { get; set; }
        public double? Price { get; set; }
    }
}
