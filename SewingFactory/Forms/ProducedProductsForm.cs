using SawingFactory.Entities;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace SawingFactory.Forms
{
    public partial class ProducedProductsForm : BaseNestedForm
    {
        public ProducedProductsForm()
        {
            InitializeComponent();
        }

        private void ProducedProductsForm_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                var query = context.PruducedProducts.Select(prod => new
                {
                    prod.ProductId,
                    prod.Product.Name,
                    prod.Quantity,
                    prod.Product.Price
                });
                
            }
        }
    }
}
