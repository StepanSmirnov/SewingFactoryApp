using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class Product
    {
        public Product()
        {
            Materials = new HashSet<Material>();
        }

        [Key]
        public string ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public double Width { get; set; }
        [Required]
        public string WidthUnit { get; set; }
        public double Length { get; set; }
        [Required]
        public string LengthUnit { get; set; }
        public byte[] Image { get; set; }
        public string Comment { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<ProductsFurniture> ProductsFurnitures { get; set; }

        [NotMapped]
        public double Area
        {
            get
            {
                return UnitConverter.Area(Width, WidthUnit, Length, LengthUnit, "м");
            }
        }

        //I don't understand how to calculate full price using this database
        //There are no data about amount of materials required for product
        [NotMapped]
        public double Price
        {
            get
            {
                return 0;
                //if (ProductsFurnitures == null) return 0;
                //return ProductsFurnitures.Sum(f => f.Quantity * f.Furniture.Price).Value;
            }
        }
    }
}
