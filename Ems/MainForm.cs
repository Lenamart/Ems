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
    public partial class MainForm : Form
    {
        private Form _activeForm;

        public MainForm()
        {
            InitializeComponent();

            OpenChildForm(new HomeForm(), null);
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;

            panelActiveForm.Controls.Add(_activeForm);
            panelActiveForm.Tag = _activeForm;

            _activeForm.BringToFront();
            _activeForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TranslateForm(), sender);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm(), sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DictionaryForm(), sender);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FavoriteWords(), sender);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm(), sender);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
