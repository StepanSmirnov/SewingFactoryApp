using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class CustomerForm : BaseMenuForm
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            AddMenuItem("Изделия", showProducts);
        }

        private void showProducts(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
