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

        BookService bookService;
        BookCopyService bookCopyService;

        public AddCopyForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);

            FillDropDownBooks(bookService.All().OrderBy(b => b.Title));
        }

        private void FillDropDownBooks(IEnumerable<Book> allBooks)
        {
            foreach (Book book in allBooks)
            {
                dropDown_books.Items.Add(book.Title);
            }
        }

        private void BTNAddCopy_Click(object sender, EventArgs e)
        {
            Book book = dropDown_books.SelectedItem as Book;
            int condition = Convert.ToInt32(dropDown_condition.SelectedItem);
            BookCopy newCopy = new BookCopy(book, condition);
            bookCopyService.Add(newCopy);
            book.BookCopies.Add(newCopy);
            bookService.Edit(book);
            this.Close();
        }
    }
}
