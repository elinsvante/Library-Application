using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookForm : Form
    {
        BookService bookService;
        AuthorService authorService;

        public AddBookForm(BookService bookService, AuthorService authorService)
        {
            InitializeComponent();

            this.bookService = bookService;
            this.authorService = authorService;

            FillDropDownAuthors(authorService.All());
        }

        public void FillDropDownAuthors(IEnumerable<Author> allAuthors)
        {
            foreach (Author author in allAuthors)
            {
                dropDown_authors.Items.Add(author);
            }
        }

        private void BTNAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                MessageBox.Show("Please enter the title.");
            }
            else if (dropDown_authors.SelectedItem == null)
            {
                MessageBox.Show("Please select an author.");
            }
            else if (string.IsNullOrWhiteSpace(tbISBN.Text))
            {
                MessageBox.Show("Please enter ISBN.");
            }
            else
            {
                string title = tbTitle.Text;
                Author author = dropDown_authors.SelectedItem as Author;
                string isbn = tbISBN.Text;
                string description = tbDescription.Text;

                Book newBook = new Book(title, isbn, description, author);
                bookService.Add(newBook);
                this.Close();
            }
        }
    }
}
