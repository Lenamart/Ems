using Ems.DataBase;
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
    public partial class HomeForm : Form
    {
        private readonly EmsContext _context;
        public HomeForm()
        {
            InitializeComponent();
            addWordButton.BringToFront();
            _context = new EmsContext();
            htmlToolTipAddWord.SetToolTip(addWordButton, "Поместить слово в словарь для изучения.");
            htmlToolTipDelete.SetToolTip(imageButtonDelete, "Удалить слово из системы.");
            InitTable();
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            string wordText = textBoxWord.Text;

            Word word = _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

            if (word == null)
            {
                _context.Words.Add(new Word()
                {
                    UserId = LoginForm.CurrentUser.Id,
                    Value = wordText,
                    Count = 1,
                    State = StateStudy.None,
                    IsFavorite = false
                });
            }
            else
            {
                word.Count++;
            }

            _context.SaveChanges();

            InitTable();
        }

        private void InitTable()
        {
            DataGridViewWords.Rows.Clear();

            List<Word> words = _context.Words
                .Where(x => x.UserId == LoginForm.CurrentUser.Id)
                .ToList();

            foreach (Word word in words)
            {
                DataGridViewWords.Rows.Add(word.Value, word.Count);
            }
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            string wordText = (string)DataGridViewWords.SelectedRows[0].Cells[0].Value;
            var translater = new Translator();
            string translateWord = translater.TranslateAsync(wordText, "ru").Result.Result;

            Word word =  _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

            if (word != null)
            {
                word.State = StateStudy.Studying;
                word.Translate = translateWord;
                _context.SaveChanges();
            }



        }

        private void imageButtonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in DataGridViewWords.SelectedRows)
            {
                string wordText = (string)selectedRow.Cells[0].Value;
                Word word = _context.Words.FirstOrDefault(x => x.UserId == LoginForm.CurrentUser.Id && x.Value == wordText);

                if (word != null)
                {
                    _context.Words.Remove(word);
                    _context.SaveChanges();
                    InitTable();
                }
            }
        }
    }
}
