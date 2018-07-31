using SawingFactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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

        public ProductsForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            using (var context= new FactoryContext())
            {
                context.Products.Load();
                dataGridView1.DataSource = context.Products.Local.ToBindingList();
            }
        }
    }
}
