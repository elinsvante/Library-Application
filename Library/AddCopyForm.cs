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
    public partial class AddCopyForm : Form
    {
        BookCopyService bookCopyService;
        BookService bookService;
        Book book;

        public AddCopyForm(BookCopyService bookCopyService, BookService bookService, Book book, string bookString)
        {
            InitializeComponent();

            this.bookCopyService = bookCopyService;
            this.bookService = bookService;
            this.book = book;
            tbBook.Text = bookString;
        }

        private void BTNAddCopy_Click(object sender, EventArgs e)
        {
            int condition = Convert.ToInt32(dropDown_condition.SelectedItem);
            BookCopy newCopy = new BookCopy(book, condition);
            bookCopyService.Add(newCopy);
            book.BookCopies.Add(newCopy);
            bookService.Edit(book);
            this.Close();
        }
    }
}
