using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Laba2.BookFile;

namespace Laba2
{
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
            CurrentAuthorsList = new List<Author>();
        }

        public List<Author> CurrentAuthorsList { get; set; }

        private void AuthorsFormClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            (sender as AuthorsForm).Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxCountry.Text == "" || textBoxID.Text == "") return;
            try
            {
                if (textBoxName.Text.Length > 30 || textBoxID.Text.Length > 30 || textBoxCountry.Text.Length > 30)
                    throw new Exception("Превышен размер входных данных");

                string name = textBoxName.Text;
                int id = int.Parse(textBoxID.Text);
                string country = textBoxCountry.Text;


                var newAuthor = new Author(name, country, id);
                CurrentAuthorsList.Add(newAuthor);
                listBoxAuthors.Items.Add(newAuthor);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void Clear()
        {
            CurrentAuthorsList.Clear();
            listBoxAuthors.Items.Clear();
        }

        private void textBoxDigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }
    }
}