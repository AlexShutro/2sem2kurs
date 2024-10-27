using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Laba2
{
    public partial class SearchForm : Form
    {
        private readonly List<BookFile.BookFile> _bookFiles = new List<BookFile.BookFile>();

        public SearchForm()
        {
            InitializeComponent();
        }


        public void GetBookFilesFromBaseListbox(ListBox.ObjectCollection items)
        {
            _bookFiles.Clear();
            foreach (object item in items) _bookFiles.Add(item as BookFile.BookFile);
        }


        private void buttonRegexSearch_Click(object sender, EventArgs e)
        {
            if (textBoxRegex.Text == "") return;

            var regex = new Regex(textBoxRegex.Text);
            listBoxSearchBase.Items.Clear();

            foreach (var bookFile in _bookFiles.Where(bookFile => regex.IsMatch(bookFile.PublishingHouse.Name)))
                listBoxSearchBase.Items.Add(bookFile);
        }

        private void YearPublic_Click(object sender, EventArgs e)
        {
            if (textBoxYear.Text == "") return;
            listBoxSearchBase.Items.Clear();

            int year = int.Parse(textBoxYear.Text);

            foreach (var bookFile in _bookFiles.Where(bookFile => bookFile.Year == year))
            {
                listBoxSearchBase.Items.Add(bookFile);
            }
            
        }

        private void Diapazon_Click(object sender, EventArgs e)
        {
            if (textBoxRangeOfPages.Text == "" ) return;
            var regex = new Regex(@"^(\d+)-(\d+)$");
            if (regex.IsMatch(textBoxRangeOfPages.Text) == false)
             {
                 MessageBox.Show("Неправильный формат ввода диапазона");
                 return;
             }
           listBoxSearchBase.Items.Clear();
            var separatedNumbers = textBoxRangeOfPages.Text.Split('-');
            var firstNumber = int.Parse(separatedNumbers[0]);
            var secondNumber = int.Parse(separatedNumbers[1]);
            
            foreach (var bookFile in _bookFiles.Where(bookFile => bookFile.NumberOfPages >= firstNumber && bookFile.NumberOfPages <= secondNumber))
            {
                listBoxSearchBase.Items.Add(bookFile);
            }
        }


        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            (sender as SearchForm).Hide();
        }


        private void listBoxSearchBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAuthors.Text = "";
            textBoxPublishingHouse.Text = "";

            var selectedBookFile = ((ListBox)sender).SelectedItem as BookFile.BookFile;

            if (selectedBookFile == null) return;
            textBoxPublishingHouse.Text = selectedBookFile.PublishingHouse.ToString();

            foreach (var author in selectedBookFile.Authors) textBoxAuthors.Text += author + Environment.NewLine;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
                e.Handled = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var BookFilesList = (from object item in listBoxSearchBase.Items select item as BookFile.BookFile).ToList();

            using (var reader = new StreamWriter(@"D:\2 сем\ООП\Laba3\Laba3\Json\SearchDB.json"))
            {
                string jsonString = JsonConvert.SerializeObject(BookFilesList);
                reader.Write(jsonString);
            }
        }

      
    }
}