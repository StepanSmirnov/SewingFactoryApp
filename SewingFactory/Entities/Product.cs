using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public double Width { get; set; }
        [Required]
        public string WidhtUnit { get; set; }
        public double Length { get; set; }
        [Required]
        public string LengthUnit { get; set; }
        public byte[] Image { get; set; }
        public string Comment { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}
