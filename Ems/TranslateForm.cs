using GTranslate.Results;
using GTranslate.Translators;
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
    public partial class TranslateForm : Form
    {
        public TranslateForm()
        {
            InitializeComponent();
            comboBoxLang.SelectedItem = comboBoxLang.Items[0];
        }

        private void panelActiveForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            string text = textBoxFromTranslate.Text;
            string lang = textBoxToLang.Text;

            var translater = new Translator();
            if (lang == "Русский")
            {
                textBoxToTranslate.Text = translater.TranslateAsync(text, "ru").Result.Result;
            }
            else
            {
                textBoxToTranslate.Text = translater.TranslateAsync(text, "en").Result.Result;
            }


        }

        private void comboBoxLang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            string fromLang = comboBoxLang.Text;

            if (fromLang == "Русский")
            {
                comboBoxLang.SelectedItem = comboBoxLang.Items[1];
                textBoxToLang.Text = "Русский";
            }
            else
            {
                comboBoxLang.SelectedItem = comboBoxLang.Items[0];
                textBoxToLang.Text = "Английсский";
            }
        }

        private void comboBoxLang_SelectedValueChanged(object sender, EventArgs e)
        {
            string fromLang = comboBoxLang.SelectedItem.ToString();
            
            if (fromLang == "Русский")
            {
                textBoxToLang.Text = "Английсский";
            }
            else
            {
                textBoxToLang.Text = "Русский";
            }
        }
    }
}
