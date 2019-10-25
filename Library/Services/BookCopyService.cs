using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookCopyService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookCopyRepository bookCopyRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        // A generic delegate EventHandlers that represents the method that will handle an event when the event provides data.
        public event EventHandler<EventArgs> Updated;

        //Methods that checks if there are subscribers to an event, if there is, the event is raised
        protected virtual void OnUpdated(object sender, EventArgs args)
        {
            Updated?.Invoke(this, args);
        }

        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        public void Add(BookCopy b)
        {
            bookCopyRepository.Add(b);
            OnUpdated(this, EventArgs.Empty);
        }
        public IEnumerable<BookCopy> AllExcept(IEnumerable<Loan> bookCopiesOnLoan)
        {
            IEnumerable<BookCopy> bookCopies = bookCopyRepository.All();
            return bookCopies.Except(bookCopiesOnLoan.Select(b => b.BookCopy)).ToList();
        }

        public IEnumerable<BookCopy> AllExceptWithBook(IEnumerable<Loan> bookCopiesOnLoan, Book book)
        {
            IEnumerable<BookCopy> bookCopies = bookCopyRepository.All().Where(b => b.Book == book);
            return bookCopies.Except(bookCopiesOnLoan.Select(b => b.BookCopy)).ToList();
        }

        public IEnumerable<BookCopy> AllBookCopiesOnLoanForMember (IEnumerable<Loan> bookCopiesOnLoanForMember)
        {
            IEnumerable<BookCopy> bookCopies = bookCopyRepository.All();
            return bookCopies.Where(b => b == bookCopiesOnLoanForMember);
        }

        public IEnumerable<BookCopy> AllBookCopiesForBook(Book book)
        {
            IEnumerable<BookCopy> bookCopies = bookCopyRepository.All();
            return bookCopies.Where(b => b.Book == book);
        }
    }
}

