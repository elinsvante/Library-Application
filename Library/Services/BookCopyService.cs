using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    /// <summary>
    /// This class holds the business logic for the application and executes the queries requested by the GUI.
    /// It depend on and uses the BookCopy repository for reading and persisting data.
    /// </summary>
    public class BookCopyService : IService
    {
        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        BookCopyRepository bookCopyRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        /// <summary>
        /// An EventHandler that will be raised when a change has been made in the database to update the GUI.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Method to check if there are any subscribers to the event, if there is, the event is raised.
        /// </summary>
        /// <param name="sender">The object sender.</param>
        /// <param name="args">The EventArgs argument.</param>
        protected virtual void OnUpdated(object sender, EventArgs args)
        {
            Updated?.Invoke(this, args);
        }

        /// <summary>
        /// Uses the BookCopy repository to get all Book object from the database.
        /// </summary>
        /// <returns>A IEnumerable<Book> including all Book objects from the database.</returns>
        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        /// <summary>
        /// Uses the BookCopy repository to add a new BookCopy object to the database and then raises the Updated() event.
        /// </summary>
        /// <param name="b">The BookCopy object to be added to the database.</param>
        public void Add(BookCopy b)
        {
            bookCopyRepository.Add(b);
            OnUpdated(this, EventArgs.Empty);
        }

        /// <summary>
        /// Uses the BookCopy repository and LINQ to filter out the result to be only the BookCopies of the selected Book.
        /// </summary>
        /// <param name="b">The Book object we want te BookCopies of.</param>
        /// <returns>A IEnumerable<BookCopy> with the BookCopies for the selected Book.</returns>
        public IEnumerable<BookCopy> AllCopiesForBook (Book b)
        {
            return bookCopyRepository.All().Where(bc => bc.Book == b);
        }

        /// <summary>
        /// Uses the BookCopy repository and LINQ to filter out the result to be only the BookCopies not on loan.
        /// </summary>
        /// <param name="bookCopiesOnLoan">The Loans that are currently on loan to filter out these Loans bookcopies.</param>
        /// <returns>A IEnumerable<BookCopy> with the BookCopies not on loan.</returns>
        public IEnumerable<BookCopy> AllExcept(IEnumerable<Loan> bookCopiesOnLoan)
        {
            IEnumerable<BookCopy> bookCopies = bookCopyRepository.All();
            return bookCopies.Except(bookCopiesOnLoan.Select(b => b.BookCopy)).ToList();
        }

        /// <summary>
        /// Uses the BookCopy repository and LINQ to filter out the result to be only the BookCopies not on loan for the chosen Book.
        /// </summary>
        /// <param name="bookCopiesOnLoan">The Loans that are currently on loan to filter out these Loans bookcopies.</param>
        /// <param name="book">The Book to filter out the BookCopies for only this Book.</param>
        /// <returns>A IEnumerable<BookCopy> with the BookCopies not on loan for the chosen Book.</returns>
        public IEnumerable<BookCopy> AllExceptWithBook(IEnumerable<Loan> bookCopiesOnLoan, Book book)
        {
            IEnumerable<BookCopy> bookCopiesForBook = bookCopyRepository.All().Where(b => b.Book == book);
            return bookCopiesForBook.Except(bookCopiesOnLoan.Select(b => b.BookCopy)).ToList();
        }
    }
}