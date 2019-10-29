using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookService : IService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
        }

        // A generic delegate EventHandlers that represents the method that will handle an event when the event provides data.
        public event EventHandler Updated;

        //Methods that checks if there are subscribers to an event, if there is, the event is raised
        protected virtual void OnUpdated(object sender, EventArgs args)
        {
            Updated?.Invoke(this, args);
        }


        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }


        public IEnumerable<Book> GetAllThatContainsInTitle(string a)
        {
            return bookRepository.All().Where(b => b.Title.Contains(a));
        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Book b)
        {
            bookRepository.Edit(b);
            OnUpdated(this, EventArgs.Empty);
        }
        public void Add(Book b)
        {
            bookRepository.Add(b);
            OnUpdated(this, EventArgs.Empty);
        }
        
    }
}
