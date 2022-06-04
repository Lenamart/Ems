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

    public partial class DictionaryForm : Form
    {
        private EmsContext _context = new EmsContext();
        public DictionaryForm()
        {
            InitializeComponent();
            InitTable();
            htmlToolTipEdit.SetToolTip(imageButtonEdit, "Изменить слово в словаре.");
            htmlToolTipDelete.SetToolTip(imageButtonDelete, "Удалить слово из словаря.");
            htmlToolTipFavorite.SetToolTip(imageButtonFavorite, "Добавить слово в избранное.");
            htmlToolTipStudied.SetToolTip(imageButtonStudied, "Перенести слово в писок изученных.");

        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewWords.SelectedRows[0];
            string wordText = (string)selectedRow.Cells[0].Value;
            Word word = _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

            if (word != null)
            {
                word.State = StateStudy.Studied;
                _context.SaveChanges();
                InitTable();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewWords.SelectedRows[0];
            string wordText = (string)selectedRow.Cells[0].Value;
            Word word = _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

            if (word != null)
            {
                EditWord editWord = new EditWord(word);
                editWord.ShowDialog();
                InitTable();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewWords.SelectedRows[0];
            string wordText = (string)selectedRow.Cells[0].Value;
            Word word = _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

            if (word != null)
            {
                word.State = StateStudy.None;
                _context.SaveChanges();
                InitTable();
            }


        }
        private void InitTable()
        {
            DataGridViewWords.Rows.Clear();

            _context = new EmsContext();
            List<Word> words = _context.Words
                .Where(x => x.UserId == LoginForm.CurrentUser.Id && x.State == StateStudy.Studying)
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
