using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class Material
    {
        [Key]
        public string MaterialId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Color { get; set; }
        public string Pattern { get; set; }
        public byte[] Image { get; set; }
        public string Consist { get; set; }
        public double Width { get; set; }
        [Required]
        public string WidhtUnit { get; set; }
        public double Length { get; set; }
        [Required]
        public string LengthUnit { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
