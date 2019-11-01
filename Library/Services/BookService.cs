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
    /// It depend on and uses the Book repository for reading and persisting data.
    /// </summary>
    public class BookService : IService
    {
        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
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
        /// Uses the Book repository to get all Book object from the database.
        /// </summary>
        /// <returns>A IEnumerable<Book> including all Book objects from the database.</returns>
        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        /// <summary>
        /// Uses the Book repository to add a new Book object to the database and then raises the Updated() event.
        /// </summary>
        /// <param name="b">The Book object to be added to the database.</param>
        public void Add(Book b)
        {
            bookRepository.Add(b);
            OnUpdated(this, EventArgs.Empty);
        }

        /// <summary>
        /// Uses the Book repository to save the Book object to the database and then raises the Updated() event.
        /// </summary>
        /// <param name="b">The Book object to be edited in the database.</param>
        public void Edit(Book b)
        {
            bookRepository.Edit(b);
            OnUpdated(this, EventArgs.Empty);
        }
    }
}