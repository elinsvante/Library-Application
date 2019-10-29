using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        public void Add(Book b)
        {
            context.Books.Add(b);
            context.SaveChanges();
        }

        public void Remove(Book b)
        {
            context.Books.Remove(b);
            context.SaveChanges();
        }

        public Book Find(int bookID)
        {
            return context.Books.Find(bookID);
        }

        public void Edit(Book b)
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }
    }
}