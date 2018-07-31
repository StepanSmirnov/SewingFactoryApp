using SawingFactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class FurnitureStockForm : BaseNestedForm
    {
        public FurnitureStockForm()
        {
            InitializeComponent();
        }

        public FurnitureStockForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void FurnitureStock_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                var query = context.FurnitureStocks
                    .GroupBy(f => f.Furniture)
                    .Select(group => new
                    {
                        group.Key.FurnitureId,
                        group.Key.Name,
                        Count = group.Count(),
                        Weight = group.Sum(f => f.Furniture.Weight),
                        Price = group.Sum(f => f.Furniture.Price)
                    });
                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
