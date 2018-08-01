using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SawingFactory.DAL.Entities;

namespace SawingFactory.Forms
{
    public partial class StoreKeeperForm : BaseMenuForm
    {
        public StoreKeeperForm()
        {
            InitializeComponent();
        }

        public StoreKeeperForm(BaseForm baseForm, User user) : base(baseForm, user)
        {
            InitializeComponent();
        }

        private void StoreKeeperForm_Load(object sender, EventArgs e)
        {
            AddMenuItem("Остатки ткани", showMaterialsStock);
            AddMenuItem("Остатки фурнитуры", showFurnituresStock);
            AddMenuItem("Поставка ткани", showMaterialSupply);
            AddMenuItem("Поставка фурнитуры", showFurnituresSupply);
            AddMenuItem("Фурнитура", showFurnitures);
            AddMenuItem("Ткани", showMaterials);
            showMaterialsStock(sender, e);
        }

        private void showMaterials(object sender, EventArgs e)
        {
            ShowNestedForm(new MaterialsForm());
        }

        private void showFurnitures(object sender, EventArgs e)
        {
            ShowNestedForm(new FurnituresForm());
        }

        private void showFurnituresSupply(object sender, EventArgs e)
        {
            ShowNestedForm(new FurnitureSupplyForm());
        }

        private void showMaterialSupply(object sender, EventArgs e)
        {
            ShowNestedForm(new MaterialSupplyForm());
        }

        private void showFurnituresStock(object sender, EventArgs e)
        {
            ShowNestedForm(new FurnitureStockForm());
        }

        private void showMaterialsStock(object sender, EventArgs e)
        {
            ShowNestedForm(new MaterialStockForm());
        }
    }
}
