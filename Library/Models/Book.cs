using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {

        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public ICollection<BookCopy> BookCopies { get; set; }

        public Book(string title, string isbn, string description, Author author)
        {
            BookCopies = new List<BookCopy>();
            //BookCopy bookCopy = new BookCopy(this, 10);
            //BookCopies.Add(bookCopy);
            this.Title = title;
            this.ISBN = isbn;
            this.Description = description;
            this.Author = author;
        }

        public Book()
        {
            BookCopies = new List<BookCopy>();
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString() {
            return String.Format("[{0}] | {1} : {2} ({3})", this.BookID, this.ISBN, this.Title, this.Author.Name);
        }
    }
}