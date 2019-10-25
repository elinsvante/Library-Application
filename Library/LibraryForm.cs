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
    public partial class LibraryForm : Form
    {

        BookService bookService;
        AuthorService authorService;
        BookCopyService bookCopyService;
        LoanService loanService;
        MemberService memberService;

        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.loanService = new LoanService(repFactory);
            this.memberService = new MemberService(repFactory);

            ShowAllBooks(bookService.All());
            ShowAllBookCopies(bookCopyService.All());
            ShowAllCurrentLoans(loanService.AllBookCopiesOnLoan());
            ShowAllReturnedLoans(loanService.AllBookCopiesNotOnLoan());
            IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
            IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
            ShowAllAvailableCopies(bookCopiesNotOnLoan);
            FillDropDownMembers(memberService.All());
            FillDropDownAuthors(authorService.All());

            bookService.Updated += ListChangedMethod;
            loanService.Updated += ListChangedMethod;
        }

        private void ListChangedMethod(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());
            ShowAllBookCopies(bookCopyService.All());
            ShowAllCurrentLoans(loanService.AllBookCopiesOnLoan());
            ShowAllReturnedLoans(loanService.AllBookCopiesNotOnLoan());
            IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
            IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
            ShowAllAvailableCopies(bookCopiesNotOnLoan);
            dropDown_members.SelectedIndex = -1;
        }

        private void UpdateForm(object sender, FormClosingEventArgs e)
        {
            ShowAllBooks(bookService.All());
            ShowAllBookCopies(bookCopyService.All());
            ShowAllCurrentLoans(loanService.AllBookCopiesOnLoan());
            ShowAllReturnedLoans(loanService.AllBookCopiesNotOnLoan());
            IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
            IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
            ShowAllAvailableCopies(bookCopiesNotOnLoan);
            dropDown_authors.Items.Clear();
            dropDown_members.Items.Clear();
            FillDropDownMembers(memberService.All());
            FillDropDownAuthors(authorService.All());
        }


        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }

        private void ShowAllBookCopies(IEnumerable<BookCopy> bookCopies)
        {
            lbCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopies)
            {
                lbCopies.Items.Add(bookCopy);
            }
        }

        private void ShowAllCurrentLoans(IEnumerable<Loan> loans)
        {
            lbCurrentLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                DateTime today = DateTime.Today;
                if (loan.DueDate < today)
                {
                    lbCurrentLoans.Items.Add("Delayed: ");
                    lbCurrentLoans.Items.Add(loan);
                }
                else
                {
                    lbCurrentLoans.Items.Add(loan);
                }
            }
        }

        private void ShowAllReturnedLoans(IEnumerable<Loan> loans)
        {
            lbReturnedLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbReturnedLoans.Items.Add(loan);
            }
        }

        private void ShowAllAvailableCopies(IEnumerable<BookCopy> bookCopiesNotOnLoan)
        {

            lbAvailableCopies.Items.Clear();
            lbCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopiesNotOnLoan)
            {
                lbAvailableCopies.Items.Add(bookCopy);
                lbCopies.Items.Add(bookCopy);
            }
        }

        private void ShowAllAvailableCopiesForBook(IEnumerable<BookCopy> bookCopiesNotOnLoan)
        {

            lbAvailableCopies.Items.Clear();
            lbCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopiesNotOnLoan)
            {
                lbAvailableCopies.Items.Add(bookCopy);
                lbCopies.Items.Add(bookCopy);
            }
        }

        private void FillDropDownMembers(IEnumerable<Member> allMembers)
        {
            foreach (Member member in allMembers)
            {
                dropDown_members.Items.Add(member);
            }
        }

        private void FillDropDownAuthors(IEnumerable<Author> allAuthors)
        {
            foreach (Author author in allAuthors)
            {
                dropDown_authors.Items.Add(author);
            }
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCopies.Items.Clear();
            Book selectedBook = lbBooks.SelectedItem as Book;
            ShowAllBookCopies(bookCopyService.AllBookCopiesForBook(selectedBook));
        }

        private void dropDown_filterCopies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = dropDown_filterCopies.SelectedItem.ToString();
            if (selectedValue == "All Copies")
            {
                Book selectedBook = lbBooks.SelectedItem as Book;
                if (selectedBook != null)
                {
                    ShowAllBookCopies(bookCopyService.AllBookCopiesForBook(selectedBook));
                }
                else
                {
                    ShowAllBookCopies(bookCopyService.All());
                }
            }
            else if (selectedValue == "Available Copies")
            {
                Book selectedBook = lbBooks.SelectedItem as Book;
                if (selectedBook != null)
                {
                    IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
                    IEnumerable<BookCopy> bookCopiesNotOnLoanForBook = bookCopyService.AllExceptWithBook(allCurrentLoans, selectedBook);
                    ShowAllAvailableCopies(bookCopiesNotOnLoanForBook);
                }
                else
                {
                    IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
                    IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
                    ShowAllAvailableCopies(bookCopiesNotOnLoan);
                }
            }
        }

        private void BTNBooksOfAuthor_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = dropDown_authors.SelectedItem as Author;
            ShowAllBooks(authorService.BooksByAuthor(selectedAuthor));
        }

        private void BTNLoan_Click(object sender, EventArgs e)
        {
            BookCopy selectedBookCopy = lbAvailableCopies.SelectedItem as BookCopy;
            Member selectedMember = dropDown_members.SelectedItem as Member;
            DateTime timeOfLoan = DateTime.Now;
            DateTime dueDate = timeOfLoan.AddDays(15);
            Loan newLoan = new Loan(timeOfLoan, dueDate, selectedBookCopy, selectedMember);
            loanService.Add(newLoan);
        }

        private void BTNReturn_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = lbCurrentLoans.SelectedItem as Loan;
            if (selectedLoan != null)
            {
                DateTime timeNow = DateTime.Now;
                selectedLoan.TimeOfReturn = timeNow.ToString();
                loanService.ReturnBook(selectedLoan);
                if (selectedLoan.DueDate > timeNow)
                {
                    MessageBox.Show("Your book has been returned: " + timeNow);
                }
                else
                {
                    TimeSpan elapsed = timeNow - selectedLoan.DueDate;
                    int daysDelayed = elapsed.Days;
                    int fine = daysDelayed * 10;
                    MessageBox.Show("Your return is " + daysDelayed + " days delayed!" + " You have to pay a fine of: " + fine + "kr.");
                }
            }
            else
            {
                MessageBox.Show("You have to choose a loan to return!");
            }

        }

        private void BTNAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm newForm = new AddBookForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateForm);
            newForm.Show();
        }

        private void BTNAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm newForm = new AddAuthorForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateForm);
            newForm.Show();
        }

        private void BTNAddCopy_Click(object sender, EventArgs e)
        {
            AddCopyForm newForm = new AddCopyForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateForm);
            newForm.Show();
        }

        private void BTNMembers_Click(object sender, EventArgs e)
        {
            //MembersForm newForm = new MembersForm();
            //newForm.FormClosing += new FormClosingEventHandler(UpdateForm);
            //newForm.Show();
        }

        private void BTNLoansForMember_Click(object sender, EventArgs e)
        {
            lbCurrentLoans.Items.Clear();
            Member member = dropDown_members.SelectedItem as Member;
            IEnumerable<Loan> loansForMember = loanService.AllLoanForMember(member);
            MembersForm newForm = new MembersForm(loansForMember);
            newForm.FormClosing += new FormClosingEventHandler(UpdateForm);
            newForm.Show();

        }



        private void BTNChangeBook_Click(object sender, EventArgs e)
        {
            Book b = lbBooks.SelectedItem as Book;
            if (b != null)
            {
                b.Title = "Yoyoma koko";
                bookService.Edit(b);
            }
        }
    }
}
