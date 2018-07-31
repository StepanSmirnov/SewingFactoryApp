using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class MaterialRoll
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RollId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string MaterialId { get; set; }
        public virtual Material Material { get; set; }

        public double Width { get; set; }
        [Required]
        public string WidthUnit { get; set; }

        public double Length { get; set; }
        [Required]
        public string LengthUnit { get; set; }

        public MaterialRoll() { }
        
        public MaterialRoll(Material material)
        {
            Material = material;
            Width = material.Width;
            WidthUnit = material.WidthUnit;
            Length = material.Length;
            LengthUnit = material.LengthUnit;
        }

        [NotMapped]
        public double Area
        {
            get
            {
                return UnitConverter.Area(Width, WidthUnit, Length, LengthUnit, "м");
            }
        }
        [NotMapped]
        public double Price
        {
            get
            {
                return Area / Material.Area * Material.Price; 
            }
        }
    }
}
