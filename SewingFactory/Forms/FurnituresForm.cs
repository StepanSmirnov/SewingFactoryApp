using SawingFactory.DAL.Entities;
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
    public partial class FurnituresForm : SawingFactory.Forms.BaseNestedForm
    {
        public FurnituresForm()
        {
            InitializeComponent();
        }

        private void FurnituresForm_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                furnitureBindingSource.DataSource = context.Furnitures.ToList();
            }
        }
    }
}
