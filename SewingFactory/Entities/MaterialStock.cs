using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class MaterialStock
    {
        [Key]
        [Column(Order = 1)]
        public int RollId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string MaterialId { get; set; }
        public Material Material { get; set; }
        public double Length { get; set; }
    }
}
