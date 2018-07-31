using System;
using System.Data;
using System.Linq;
using SawingFactory.Entities;

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
            var query = DbContext_.Users.Where(u => u.Login == textBox1.Text && u.Password == textBox2.Text);
            if (query.Count() == 0)
            {
                System.Windows.Forms.MessageBox.Show("Ошибочно введён логин или пароль");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Успешно");
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            //DbContext_.Users.Add(new User { Login = "customer1", Password = "customer1", Role = "customer" });
            //DbContext_.SaveChanges();
        }
    }
}
