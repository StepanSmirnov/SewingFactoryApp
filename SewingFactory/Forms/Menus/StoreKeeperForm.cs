using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class StoreKeeperForm : BaseMenuForm
    {
        public StoreKeeperForm()
        {
            InitializeComponent();
        }

        public StoreKeeperForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void StoreKeeperForm_Load(object sender, EventArgs e)
        {
            AddMenuItem("Ткани", showMaterials);
            AddMenuItem("Фурнитура", showFurniture);
            showMaterials(sender, e);
        }

        private void showFurniture(object sender, EventArgs e)
        {
            ShowNestedForm(new FurnitureStockForm(this));
        }

        private void showMaterials(object sender, EventArgs e)
        {
            ShowNestedForm(new MaterialStockForm(this));
        }
    }
}
