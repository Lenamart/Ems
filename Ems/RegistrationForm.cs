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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password1 = textBoxPassword1.Text;
            string password2 = textBoxPassword2.Text;

            if(string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (string.IsNullOrEmpty(password1))
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Повторите пароль");
                return;
            }

            if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            using (EmsContext emsContext = new EmsContext())
            {
                User user = emsContext.Users.FirstOrDefault(x => x.Login == login);

                if (user != null)
                {
                    MessageBox.Show("Такой логин уже существует");
                    return;
                }

                user = new User()
                {
                    Login = login,
                    Password = password2
                };

                emsContext.Users.Add(user);
                emsContext.SaveChanges();
            }
            Close();

        }
    }
}
