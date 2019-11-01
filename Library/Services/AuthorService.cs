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
    /// It depend on and uses the Author repository for reading and persisting data.
    /// </summary>
    public class AuthorService : IService
    {
        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        AuthorRepository authorRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
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
        /// Uses the Author repository to get all Author object from the database.
        /// </summary>
        /// <returns>A IEnumerable<Author> including all Author objects from the database.</returns>
        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        /// <summary>
        /// Uses the Author repository to add a new Author object to the database and then raises the Updated() event.
        /// </summary>
        /// <param name="a">The Author object to be added to the database.</param>
        public void Add(Author a)
        {
            authorRepository.Add(a);
            OnUpdated(this, EventArgs.Empty);
        }

        /// <summary>
        /// Uses the Author repository and LINQ to get all Book objects from the database of the selected Author.
        /// </summary>
        /// <param name="a">The Author object that will filter the Books to be only the Books of this Author.</param>
        /// <returns>A IEnumerable<Book> with all Book objects of the selected Author.</returns>
        public IEnumerable<Book> BooksByAuthor(Author a)
        {
            return authorRepository.All().Where(author => author.Name == a.Name).SelectMany(authorBooks => authorBooks.Books);
        }
    }
}
