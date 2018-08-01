using SawingFactory.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class ProductsForm : BaseNestedForm
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            using (var context= new FactoryContext())
            {
                dataGridView1.DataSource = context.Products.Select(p =>
                new
                {
                    p.ProductId,
                    p.Name,
                    p.Width,
                    p.WidthUnit,
                    p.Length,
                    p.LengthUnit,
                    //p.Price,
                    p.Image,
                    p.Comment,
                }).ToList();
                //dataGridView1.DataSource = context.Products.Include("Materials").Include("ProductsFurnitures").ToList();

            }
        }
    }
}
