using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookCopy
    {
        public int BookCopyID { get; set; }
        public Book Book { get; set; }
        public int Condition { get; set; }
        public BookCopy() { }
        public BookCopy(Book book, int condition)
        {
            this.Book = book;
            this.Condition = condition;
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1} (Condition: {2})", this.BookCopyID, this.Book.Title, this.Condition);
        }
    }
}
