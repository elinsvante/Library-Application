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


/// <summary>
/// Show books available and not available (which book has book copies available?)
/// Notifera medlemmen att lånet är 15 dagar?
/// </summary>

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
            IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
            IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
            ShowAllAvailableCopies(bookCopiesNotOnLoan);
            FillDropDownMembers(memberService.All().OrderBy(m => m.Name));
            FillDropDownAuthors(authorService.All().OrderBy(a => a.Name));

            loanService.Updated += loanUpdated;
        }

        private void loanUpdated (object sender, EventArgs e)
        {
            if (dropDown_members.SelectedItem != null)
            {
                ResetAfterChange();
                BTNLoansForMember_Click(sender, e);
            }
            else
            {
                ResetAfterChange();
            } 
        }

        private void ResetAfterChange()
        {
            lbCurrentLoans.Items.Clear();
            dropDown_filterLoans.SelectedIndex = -1;
            dropDown_filterCopies.SelectedIndex = -1;
            lbBooks.SelectedIndex = -1;
            IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
            IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
            ShowAllAvailableCopies(bookCopiesNotOnLoan);
        }
        private void UpdateBook(object sender, FormClosingEventArgs e)
        {
            lbCopies.Items.Clear();
            ShowAllBooks(bookService.All());   
        }

        private void UpdateBookCopy(object sender, FormClosingEventArgs e)
        {
            lbCopies.Items.Clear();
            IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
            IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
            ShowAllAvailableCopies(bookCopiesNotOnLoan);
        }

        private void UpdateAuthor(object sender, FormClosingEventArgs e)
        {
            dropDown_authors.SelectedIndex = -1;
            dropDown_authors.Items.Clear();
            FillDropDownAuthors(authorService.All());
        }

        private void UpdateMember(object sender, FormClosingEventArgs e)
        {
            lbCurrentLoans.Items.Clear();
            ShowAllCurrentLoans(loanService.AllBookCopiesOnLoan());
            dropDown_members.SelectedIndex = -1;
            dropDown_members.Items.Clear();
            FillDropDownMembers(memberService.All());
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
            lbAvailableCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopies)
            {
                lbAvailableCopies.Items.Add(bookCopy);
            }
        }

        private void ShowAllCurrentLoans(IEnumerable<Loan> loans)
        {
            lbCurrentLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbCurrentLoans.Items.Add(loan);
            }
            if (lbCurrentLoans.Items.Count == 0)
            {
                lbCurrentLoans.Items.Add("No current loans.");
            }
        }

        private void ShowAllReturnedLoans(IEnumerable<Loan> loans)
        {
            lbCurrentLoans.Items.Clear();
            if (loans == null || !loans.Any())
            {
                lbCurrentLoans.Items.Add("No returned loans.");          
            }
            else
            {
                foreach (Loan loan in loans)
                {
                    lbCurrentLoans.Items.Add(loan + " Returned: (" + loan.TimeOfReturn + ")");
                }
            }         
        }

        private void ShowAllCurrentOverDues(IEnumerable<Loan> loans)
        {
            lbCurrentLoans.Items.Clear();
            if (loans == null || !loans.Any())
            {
                lbCurrentLoans.Items.Add("No loans overdue.");         
            }
            else
            {
                foreach (Loan loan in loans)
                {
                    lbCurrentLoans.Items.Add(loan + " Due: " + loan.DueDate.ToString("yyyy/MM/dd"));
                }
            }
        }

        
        private void ShowAllAvailableCopies(IEnumerable<BookCopy> bookCopiesNotOnLoan)
        {
            lbAvailableCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopiesNotOnLoan)
            {
                lbAvailableCopies.Items.Add(bookCopy);
            }
            if (lbAvailableCopies.Items.Count == 0)
            {
                lbAvailableCopies.Items.Add("No copies currently available.");
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
            lbAvailableCopies.Items.Clear();
            lbCopies.Items.Clear();
            Book selectedBook = lbBooks.SelectedItem as Book;
            IEnumerable<BookCopy> bookcopies = bookCopyService.AllBookCopiesForBook(selectedBook);

            IEnumerable<Loan> allLoans = loanService.AllBookCopiesOnLoan();
            int i = 0;

            foreach(BookCopy copy in bookcopies)
            {
                lbCopies.Items.Add(copy);
                foreach (Loan loan in allLoans)
                {
                    if(loan.BookCopy == copy)
                    {
                        i = 0;
                        break;
                    }
                    else
                    {
                        i = 1;
                    }
                }
                if (i == 1)
                {
                    lbAvailableCopies.Items.Add(copy);
                } 
            }
            if (lbAvailableCopies.Items.Count == 0)
            {
                lbAvailableCopies.Items.Add("No available copies.");
            }
        }

        private void label_ShowAllBooks_Click(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());
        }

        private void dropDown_filterBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = dropDown_filterBooks.SelectedItem.ToString();
            if(selectedValue == "All Books")
            {
                ShowAllBooks(bookService.All());
            }
            else if (selectedValue == "Only Available Books")
            {
                IEnumerable<Loan> copiesNotOnLoan = loanService.AllBookCopiesNotOnLoan();
                foreach(Loan loan in copiesNotOnLoan)
                {
                    lbBooks.Items.Add(loan.BookCopy.Book);
                }
            }
        }


        private void dropDown_filterCopies_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBooks.SelectedIndex = -1;
            if (dropDown_filterCopies.SelectedItem != null)
            {
                string selectedValue = dropDown_filterCopies.SelectedItem.ToString();
                if (selectedValue == "All Copies")
                {
                    ShowAllBookCopies(bookCopyService.All());
                }
                else if (selectedValue == "Available Copies")
                {
                    IEnumerable<Loan> allCurrentLoans = loanService.AllBookCopiesOnLoan();
                    IEnumerable<BookCopy> bookCopiesNotOnLoan = bookCopyService.AllExcept(allCurrentLoans);
                    ShowAllAvailableCopies(bookCopiesNotOnLoan);
                }
            }
        }

        private void dropDown_filterLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown_filterLoans.SelectedItem != null)
            {
                string selectedValue = dropDown_filterLoans.SelectedItem.ToString();
                Member selectedMember = dropDown_members.SelectedItem as Member;
                if (selectedMember != null)
                {
                    if (selectedValue == "All Current Loans")
                    {
                        ShowAllCurrentLoans(loanService.AllLoanForMember(selectedMember));
                    }
                    else if (selectedValue == "Loans Overdue")
                    {
                        ShowAllCurrentOverDues(loanService.AllBookCopiesOverdueForMember(selectedMember));
                    }
                    else if (selectedValue == "Loans Returned")
                    {
                        ShowAllReturnedLoans(loanService.AllReturnedLoanForMember(selectedMember));
                    }
                }
                else
                {
                    if (selectedValue == "All Current Loans")
                    {
                        ShowAllCurrentLoans(loanService.AllBookCopiesOnLoan());
                    }
                    else if (selectedValue == "Loans Overdue")
                    {
                        ShowAllCurrentOverDues(loanService.AllBookCopiesOverdue());
                    }
                    else if (selectedValue == "Loans Returned")
                    {
                        ShowAllReturnedLoans(loanService.AllBookCopiesNotOnLoan());
                    }
                }
            }         
        }
            

        private void BTNBooksOfAuthor_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = dropDown_authors.SelectedItem as Author;
            IEnumerable<Book> booksByAuthor = authorService.BooksByAuthor(selectedAuthor);
            if (booksByAuthor == null || !booksByAuthor.Any())
            {
                lbBooks.Items.Clear();
                lbBooks.Items.Add("No books of the selected Author.");
            }
            else
            {
               ShowAllBooks(booksByAuthor);
            }
        }

        private void BTNLoan_Click(object sender, EventArgs e)
        {
            BookCopy selectedBookCopy = lbAvailableCopies.SelectedItem as BookCopy;
            Member selectedMember = dropDown_members.SelectedItem as Member;
            
            if (selectedBookCopy == null)
            {
                MessageBox.Show("Please choose a Book copy to loan.");
            }
            else if (selectedMember == null)
            {
                MessageBox.Show("Please choose a Member to make a loan.");
            }
            else
            {
                if (dropDown_filterCopies.SelectedItem != null)
                {
                    string selectedValue = dropDown_filterCopies.SelectedItem.ToString();
                    if (selectedValue == "All Copies")
                    {
                        MessageBox.Show("Please choose a copy from the Available Copies. ");
                    }
                    else if (selectedValue == "Available Copies")
                    {
                        MakeLoan(selectedBookCopy, selectedMember);
                    }
                }
                else
                {
                    MakeLoan(selectedBookCopy, selectedMember);
                }
            }
        }  

        private void MakeLoan(BookCopy bookCopy, Member member) 
        {
            DateTime timeOfLoan = DateTime.Now;
            DateTime dueDate = timeOfLoan.AddDays(15);
            Loan newLoan = new Loan(timeOfLoan, dueDate, bookCopy, member);
            loanService.Add(newLoan);
        }

        private void label_ShowAll_Click(object sender, EventArgs e)
        {
            dropDown_members.SelectedIndex = -1;
            dropDown_filterLoans.SelectedIndex = -1;
            ShowAllCurrentLoans(loanService.AllBookCopiesOnLoan());
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
                MessageBox.Show("Please choose a loan to return from all current loans.");
            }

        }

        private void BTNAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm newForm = new AddBookForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateBook);
            newForm.Show();
        }

        private void BTNAddCopy_Click(object sender, EventArgs e)
        {
            AddCopyForm newForm = new AddCopyForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateBookCopy);
            newForm.Show();
        }


        private void BTNAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm newForm = new AddAuthorForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateAuthor);
            newForm.Show();
        }

        private void BTNMembers_Click(object sender, EventArgs e)
        {
            MembersForm newForm = new MembersForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateMember);
            newForm.Show();
        }

        private void BTNLoansForMember_Click(object sender, EventArgs e)
        {

            Member selectedMember = dropDown_members.SelectedItem as Member;
            if (selectedMember == null)
            {
                MessageBox.Show("Please select a member.");
            }
            else
            { 
                dropDown_filterLoans.SelectedIndex = -1;
                IEnumerable<Loan> loansForMember = loanService.AllLoanForMember(selectedMember);
                ShowAllCurrentLoans(loansForMember);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
