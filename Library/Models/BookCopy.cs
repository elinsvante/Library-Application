using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    /// <summary>
    /// This class is a model for a bookcopy that refers to a book and has it's own condition.
    /// </summary>
    public class BookCopy
    {
        /// <summary>
        /// Property ID for a BookCopy. Is unique and is set automatically when a new BookCopy object is initialized. Works as the primary key.
        /// </summary>
        public int BookCopyID { get; set; }

        /// <summary>
        /// Property Book for a BookCopy. A BookCopy needs to refer to an existing Book and can refer to only 1 Book.
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Property condition of the BookCopy.
        /// </summary>
        public int Condition { get; set; }
        
        /// <summary>
        /// Constructor sets the properties of a BookCopy.
        /// </summary>
        /// <param name="book"></param>
        /// <param name="condition"></param>
        public BookCopy(Book book, int condition)
        {
            this.Book = book;
            this.Condition = condition;
        }

        public BookCopy() { }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1} (Condition: {2})", this.BookCopyID, this.Book.Title, this.Condition);
        }
    }
}
