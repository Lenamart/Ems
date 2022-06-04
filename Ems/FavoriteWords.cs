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

    public partial class FavoriteWords: Form
    {
        private EmsContext _context = new EmsContext();
        public FavoriteWords()
        {
            InitializeComponent();
            InitTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewWords.SelectedRows[0];
            string wordText = (string)selectedRow.Cells[0].Value;
            Word word = _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

            if (word != null)
            {
                word.IsFavorite = false;
                _context.SaveChanges();
                InitTable();
            }
        }
        private void InitTable()
        {
            DataGridViewWords.Rows.Clear();

            _context = new EmsContext();
            List<Word> words = _context.Words
                .Where(x => x.UserId == LoginForm.CurrentUser.Id && x.IsFavorite)
                .ToList();

            foreach (Word word in words)
            {
                DataGridViewWords.Rows.Add(word.Value, word.Translate);
            }
        }

        private void imageButtonFavorite_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewWords.SelectedRows[0];
            string wordText = (string)selectedRow.Cells[0].Value;
            Word word = _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

            if (word != null)
            {
                word.IsFavorite = true;
                _context.SaveChanges();
                InitTable();
            }


        }
    }
}
