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
    public partial class DirectorForm : BaseMenuForm
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        public DirectorForm(BaseForm baseForm, User user) : base(baseForm, user)
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            AddMenuItem("Изделия", showProducts);
            AddMenuItem("Остатки материалов", showMaterialsReport);
            showProducts(sender, e);
        }

        private void showMaterialsReport(object sender, EventArgs e)
        {
            ShowNestedForm(new MaterialsStockReport());
        }

        private void showProducts(object sender, EventArgs e)
        {
            ShowNestedForm(new ProductsForm());
        }
    }
}
