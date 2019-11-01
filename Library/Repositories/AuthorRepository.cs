using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles and respond to requests from the Author service layer and either fetches and returns data or 
    /// save changes that has been made.
    /// </summary>
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor sets the context instance of the BookCopyRepository.
        /// </summary>
        /// <param name="c"></param>
        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Gets all Authors in the context.
        /// </summary>
        /// <returns>All Authors in the database.</returns>
        public IEnumerable<Author> All()
        {
            return context.Authors;
        }

        /// <summary>
        /// Adds an Author to the context.
        /// </summary>
        /// <param name="a">The Author object to be added in the database.</param>
        public void Add(Author a)
        {
            context.Authors.Add(a);
            context.SaveChanges();
        }

        /// <summary>
        /// Removes an Author from the context.
        /// </summary>
        /// <param name="a">The Author object to be removed from the database.</param>
        public void Remove(Author a)
        {
            context.Authors.Remove(a);
            context.SaveChanges();
        }

        /// <summary>
        /// Searches in the context for the Author with the chosen authorID.
        /// </summary>
        /// <param name="authorID">The ID of the Author that wants to be found.</param>
        /// <returns>The Author object with the authorID.</returns>
        public Author Find(int authorID)
        {
            return context.Authors.Find(authorID);
        }

        /// <summary>
        /// Tells the context to Save the changes that has been made.
        /// </summary>
        /// <param name="b">The Author that will be edited and updated in the database.</param>
        public void Edit(Author a)
        {
            context.SaveChanges();
        }
    }
}
