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
            AddMenuItem("Остатки ткани", showMaterials);
            AddMenuItem("Остатки фурнитуры", showFurniture);
            AddMenuItem("Поставка ткани", showMaterialSupply);
            AddMenuItem("Поставка фурнитуры", showFurnituresSupply);
            showMaterials(sender, e);
        }

        private void showFurnituresSupply(object sender, EventArgs e)
        {
            ShowNestedForm(new FurnitureSupplyForm());
        }

        private void showMaterialSupply(object sender, EventArgs e)
        {
            ShowNestedForm(new MaterialSupplyForm());
        }

        private void showFurniture(object sender, EventArgs e)
        {
            ShowNestedForm(new FurnitureStockForm());
        }

        private void showMaterials(object sender, EventArgs e)
        {
            ShowNestedForm(new MaterialStockForm());
        }
    }
}
