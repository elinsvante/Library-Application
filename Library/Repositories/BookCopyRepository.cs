using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles and respond to requests from the BookCopy service layer and either fetches and returns data or 
    /// save changes that has been made.
    /// </summary>
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor sets the context instance of the BookCopyRepository.
        /// </summary>
        /// <param name="c"></param>
        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Gets all BookCopy in the context.
        /// </summary>
        /// <returns>All BookCopy in the database.</returns>
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        /// <summary>
        /// Adds a BookCopy to the context.
        /// </summary>
        /// <param name="b">The BookCopy object to be added in the database.</param>
        public void Add(BookCopy b)
        {
            context.BookCopies.Add(b);
            context.SaveChanges();
        }

        /// <summary>
        /// Removes a Book from the context.
        /// </summary>
        /// <param name="b">The BookCopy object to be removed from the database.</param>
        public void Remove(BookCopy b)
        {
            context.BookCopies.Remove(b);
            context.SaveChanges();
        }

        /// <summary>
        /// Searches in the context for the BookCopy with the chosen bookCopyID.
        /// </summary>
        /// <param name="bookCopyID">The ID of the BookCopy that wants to be found.</param>
        /// <returns>The BookCopy object with the bookCopyID.</returns>
        public BookCopy Find(int bookCopyID)
        {
            return context.BookCopies.Find(bookCopyID);
        }

        /// <summary>
        /// Tells the context to Save the changes that has been made.
        /// </summary>
        /// <param name="b">The BookCopy that will be edited and updated in the database.</param>
        public void Edit(BookCopy b)
        {
            context.SaveChanges();
        }
    }
}
