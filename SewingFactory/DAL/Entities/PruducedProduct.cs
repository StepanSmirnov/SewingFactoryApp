using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SawingFactory.DAL.Entities
{
    public class PruducedProduct
    {
        [Key]
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
