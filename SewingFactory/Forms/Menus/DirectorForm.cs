using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class DirectorForm : BaseMenuForm
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        public DirectorForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            AddMenuItem("Изделия", showProducts);
            showProducts(sender, e);
        }

        private void showProducts(object sender, EventArgs e)
        {
            ShowNestedForm(new ProductsForm());
        }
    }
}
