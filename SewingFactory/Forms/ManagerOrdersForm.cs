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
    public partial class ManagerOrdersForm : SawingFactory.Forms.BaseNestedForm
    {
        private readonly User user;

        public ManagerOrdersForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ManagerOrdersForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new FactoryContext())
            {
                orderBindingSource.DataSource = ctx.Orders.Where(o => o.Stage == "новый").ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var id = Int32.Parse(row.Cells[0].Value.ToString());
                using (var ctx = new FactoryContext())
                {
                    var order = ctx.Orders.Single(o => o.OrderId == id);
                    order.Manager = ctx.Users.Single(u => u.Login == user.Login && u.Password == user.Password);
                    order.Stage = "обработка";
                    ctx.SaveChanges();
                    MessageBox.Show("Заказ добавлен в обрабатываемые");
                }
            }
        }
    }
}
