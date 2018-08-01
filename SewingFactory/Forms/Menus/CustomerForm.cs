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
    public partial class CustomerForm : BaseMenuForm
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(BaseForm baseForm, User user) : base(baseForm, user)
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            AddMenuItem("Изделия", showProducts);
            AddMenuItem("Конструктор изделий", showConstructor);
            AddMenuItem("Новый заказ", showCreateOrder);
        }

        private void showCreateOrder(object sender, EventArgs e)
        {
            ShowNestedForm(new CreateOrderForm(user));
        }

        private void showConstructor(object sender, EventArgs e)
        {
            ShowNestedForm(new ProductsConstructorForm());
        }

        private void showProducts(object sender, EventArgs e)
        {
            ShowNestedForm(new ProductsForm());
        }
    }
}
