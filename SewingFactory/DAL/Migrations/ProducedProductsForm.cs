using SawingFactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Migrations
{
    public partial class ProducedProductsForm : Forms.BaseNestedForm
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
                    Price = prod.Quantity * prod.Product.Price
                });
            }
        }
    }
}
