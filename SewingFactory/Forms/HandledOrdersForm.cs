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
    public partial class HandledOrdersForm : SawingFactory.Forms.BaseNestedForm
    {
        private readonly User user;

        public HandledOrdersForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = SelectedOrder();
            if (id == null) return;
            using (var ctx = new FactoryContext())
            {
                var order = ctx.Orders.Single(o => o.OrderId == id);
                if (order.Stage != "новый" && order.Stage != "ожидает")
                {
                    MessageBox.Show("Заказ уже был одобрен");
                    return;
                }
                order.Stage = "отклонен";
                ctx.SaveChanges();
                MessageBox.Show("Заказ отклонен");
            }
        }

        private void HandledOrdersForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new FactoryContext())
            {
                orderBindingSource.DataSource = ctx.Orders.Where(o => o.ManagerLogin == user.Login && o.ManagerPassword == user.Password).ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = SelectedOrder();
            if (id == null) return;
            using (var ctx = new FactoryContext())
            {
                var order = ctx.Orders.Single(o => o.OrderId == id);
                if (order.Stage != "обработка")
                {
                    MessageBox.Show("Заказ не находится в стадии обработки");
                    return;
                }
                order.Stage = "к оплате";
                ctx.SaveChanges();
                MessageBox.Show("Заказ одобрен");
            }
        }

        private int? SelectedOrder()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    var row = dataGridView1.SelectedRows[0];
                    var id = Int32.Parse(row.Cells[0].Value.ToString());
                    return id;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return null;
        }
    }
}
