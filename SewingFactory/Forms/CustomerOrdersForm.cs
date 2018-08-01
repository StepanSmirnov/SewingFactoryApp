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
    public partial class CustomerOrdersForm : BaseNestedForm
    {
        private readonly User user;

        public CustomerOrdersForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CustomerOrdersForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new FactoryContext())
            {
                orderBindingSource.DataSource = ctx.Orders.Where(
                    o => o.CustomerLogin == user.Login && 
                    o.CustomerPassword == user.Password
                ).ToList();
            }
        }
    }
}
