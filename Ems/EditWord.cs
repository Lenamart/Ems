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
    public partial class EditWord : Form
    {
        private Word word;
        public EditWord(Word word)
        {
           this.word = word;
           InitializeComponent();

            textBoxWord.Text = this.word.Value;
            TextBoxTranslate.Text = this.word.Translate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            EmsContext _context = new EmsContext();
            Word word = _context.Words.FirstOrDefault(x => x.Id ==this.word.Id);

            if (word != null)
            {
                word.Value = textBoxWord.Text;
                word.Translate = TextBoxTranslate.Text;
                _context.SaveChanges();
                Close();
            }
        }
    }
}
