using SawingFactory.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SawingFactory.Forms
{
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (passwordEdit.Text != confirmEdit.Text)
            {
                MessageBox.Show("Ошибка при повторном вводе пароля");
                return;
            }
            else if (!CheckPassword(passwordEdit.Text))
            {
                MessageBox.Show("Пароль должен...");
                return;
            }
            using (var context = new FactoryContext())
            {
                try
                {
                    var user = new User
                    {
                        Login = loginEdit.Text,
                        Password = passwordEdit.Text,
                        RoleId = (int)User.UserRole.Customer,
                        Name = nameEdit.Text
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Вы успешно зарегистрированы и можете войти в систему");
                    Back();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordEdit.PasswordChar = '\0';
            confirmEdit.PasswordChar = '\0';
        }

        private void ShowButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordEdit.PasswordChar = '*';
            confirmEdit.PasswordChar = '*';
        }

        private static bool CheckPassword(string password)
        {
            return true;
        }
    }
}
