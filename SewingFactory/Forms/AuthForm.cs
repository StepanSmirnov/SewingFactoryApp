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
            var query = DbContext_.Users.Where(u => u.Login == textBox1.Text && u.Password == textBox2.Text);
            if (query.Count() == 0)
            {
                System.Windows.Forms.MessageBox.Show("Ошибочно введён логин или пароль");
            }
            else
            {
                new StoreKeeperForm(this).Open();
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            //Debug code
            var user = DbContext_.Users.Single(u => u.RoleId == (int)User.UserRole.StoreKeeper);
            textBox1.Text = user.Login;
            textBox2.Text = user.Password;
        }
    }
}
