using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles and respond to requests from the Book service layer and either fetches and returns data or 
    /// save changes that has been made using Entity Framework.
    /// </summary>
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor sets the context instance of the BookRepository.
        /// </summary>
        /// <param name="c"></param>
        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Gets all Books in the context.
        /// </summary>
        /// <returns>All Books in the database.</returns>
        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        /// <summary>
        /// Adds a Book to the context.
        /// </summary>
        /// <param name="b">The Book object to be added to the database.</param>
        public void Add(Book b)
        {
            context.Books.Add(b);
            context.SaveChanges();
        }

        /// <summary>
        /// Removes a Book from the context.
        /// </summary>
        /// <param name="b">The Book object to be removed from the database.</param>
        public void Remove(Book b)
        {
            context.Books.Remove(b);
            context.SaveChanges();
        }

        /// <summary>
        /// Searches in the context for the Book with the chosen bookID.
        /// </summary>
        /// <param name="bookID">The ID of the Book that wants to be found.</param>
        /// <returns>The Book object with the bookID.</returns>
        public Book Find(int bookID)
        {
            return context.Books.Find(bookID);
        }

        /// <summary>
        /// Tells the context to Save the changes that has been made.
        /// </summary>
        /// <param name="b">The Book object that will be edited and updated in the database.</param>
        public void Edit(Book b)
        {
            context.SaveChanges();
        }
    }
}