using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository
    {
        LibraryContext context;
        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        public void Add(BookCopy b)
        {
            context.BookCopies.Add(b);
            context.SaveChanges();
        }
    }
}
