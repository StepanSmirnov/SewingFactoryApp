using System.ComponentModel.DataAnnotations;

namespace SawingFactory.Entities
{
    public class PruducedProduct
    {
        [Key]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
