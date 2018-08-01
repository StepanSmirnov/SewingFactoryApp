using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.DAL.Entities
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

        public double Length { get; set; }
        [Required]
        public string LengthUnit { get; set; }

        public MaterialRoll() { }
        
        public MaterialRoll(Material material)
        {
            Material = material;
            Length = material.Length;
            LengthUnit = material.LengthUnit;
        }

        public double Area
        {
            get
            {
                return UnitConverter.Area(Material.Width, Material.WidthUnit, Length, LengthUnit, "м");
            }
        }

        public double Price
        {
            get
            {
                return Length / Material.Length * Material.Price; 
            }
        }
    }
}
