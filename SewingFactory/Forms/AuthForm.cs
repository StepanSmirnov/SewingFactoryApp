using System;
using System.Data;
using System.Linq;
using SawingFactory.Entities;
using SawingFactory.Forms;

namespace SawingFactory
{
    public partial class AuthForm : BaseForm
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        public AuthForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                var query = context.Users.Where(u => u.Login == textBox1.Text && u.Password == textBox2.Text);
                if (query.Count() == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Ошибочно введён логин или пароль");
                }
                else
                {
                    switch (query.First().Role)
                    {
                        case User.UserRole.Customer:
                            new CustomerForm(this).Open();
                            break;
                        case User.UserRole.Manager:
                            new ManagerForm(this).Open();
                            break;
                        case User.UserRole.StoreKeeper:
                            new StoreKeeperForm(this).Open();
                            break;
                        case User.UserRole.Director:
                            new DirectorForm(this).Open();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            //Debug code
            using (var context = new FactoryContext())
            {
                var user = context.Users.Single(u => u.RoleId == (int)User.UserRole.Manager);
                textBox1.Text = user.Login;
                textBox2.Text = user.Password;
            }
        }
    }
}
