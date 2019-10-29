using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class AuthorService : IService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        AuthorRepository authorRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        // A generic delegate EventHandlers that represents the method that will handle an event when the event provides data.
        public event EventHandler Updated;

        //Methods that checks if there are subscribers to an event, if there is, the event is raised
        protected virtual void OnUpdated(object sender, EventArgs args)
        {
            Updated?.Invoke(this, args);
        }

        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        public void Add(Author a)
        {
            authorRepository.Add(a);
            OnUpdated(this, EventArgs.Empty);
        }

        public IEnumerable<Book> BooksByAuthor(Author a)
        {
            return authorRepository.All().Where(author => author.Name == a.Name).SelectMany(authorBooks => authorBooks.Books);
        }
    }
}
