using Ems.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ems
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            textBoxLogin.Text = LoginForm.CurrentUser.Login;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Поле логин не установленно");
                return;
            }

            string oldPassword = textBoxOldPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string repeatPassword = textBoxRepeatNewPassword.Text;

            EmsContext context = new EmsContext();
            User user = context.Users.Find(LoginForm.CurrentUser.Id);

            if (!string.IsNullOrWhiteSpace(oldPassword))
            {
                if (user.Password != oldPassword)
                {
                    MessageBox.Show("Указан неверный старый пароль");
                    return;
                }

                if (newPassword != repeatPassword)
                {
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }

                user.Password = newPassword;

            }
            user.Login = login;
            context.SaveChanges();
        }
    }
}
