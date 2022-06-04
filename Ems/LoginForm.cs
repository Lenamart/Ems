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
    public partial class LoginForm : Form
    {
        public static User CurrentUser { get; set; }
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            EmsContext context = new EmsContext();

            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            User user = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (user == null)
            {
                MessageBox.Show("Неверно введен логин или пароль");
                return;
            }

            Hide();

            CurrentUser = new User() { Id = user.Id, Login = user.Login, Password = user.Password };
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Show();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void labelRegistration_MouseHover(object sender, EventArgs e)
        {
            labelRegistration.Font = new Font(labelRegistration.Font,FontStyle.Underline);
        }

        private void labelRegistration_MouseLeave(object sender, EventArgs e)
        {
            labelRegistration.Font = new Font(labelRegistration.Font, FontStyle.Regular);
        }

        private void labelRegistration_MouseEnter(object sender, EventArgs e)
        {
            labelRegistration.Font = new Font(labelRegistration.Font, FontStyle.Underline);
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
