using SawingFactory.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class CreateOrderForm : BaseNestedForm
    {
        private User user_;
        public CreateOrderForm(User user)
        {
            InitializeComponent();
            user_ = user;
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells[0].Value == null) return;
                var id = row.Cells[0].Value.ToString();
                if (id == null) return;
                using (var context = new FactoryContext())
                {
                    var prod = context.Products.Single(p => p.ProductId == id);
                    if (prod.Image == null) return;
                    MemoryStream s = new MemoryStream(prod.Image);
                    row.Cells[1].Value = System.Drawing.Image.FromStream(s);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                var order = new Order();
                order.Customer = context.Users.Single(u => u.Login == user_.Login && u.Password == user_.Password);
                order.Date = DateTime.Now;
                order.Stage = "новый";
                order.Price = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        var prods = new OrderedProducts();
                        prods.ProductId = row.Cells[0].Value.ToString();
                        prods.Order = order;
                        int count;
                        if (Int32.TryParse(row.Cells[2].Value.ToString(), out count))
                        {
                            prods.Quantity = count;
                        }
                        else
                        {
                            MessageBox.Show("Неправильно указано количество изделий");
                            return;
                        }
                        context.OrderedProducts.Add(prods);
                        order.Price += context.Products.Single(p => p.ProductId == prods.ProductId).Price;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
                context.Orders.Add(order);
                context.SaveChanges();
                MessageBox.Show("Заказ успешно создан");
            }
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                context.Products.Load();
                productBindingSource.DataSource = context.Products.Local.ToBindingList();
            }
        }
    }
}
