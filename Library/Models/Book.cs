using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {

    /// <summary>
    /// This class is a model for a book with a title, isbn a description, Author and a Collection of BookCopy.
    /// </summary>
    public class Book {

        /// <summary>
        /// Property ID for a Book. Is unique and is set automatically when a new Book object is initialized. Works as the primary key.
        /// </summary>
        public int BookID { get; set; }

        /// <summary>
        /// Property title for a Book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Property ISBN for a Book.
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Property Description for a Book. Optional.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Property Author for a Book. A Book can only have one Author and need to have one.
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Property Collection of BookCopies for a Book. A book can have 0 or more BookCopies.
        /// </summary>
        public ICollection<BookCopy> BookCopies { get; set; }

        /// <summary>
        /// Constructor sets the Book properties and creates a new list for the Collection of BookCopy.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="isbn"></param>
        /// <param name="description"></param>
        /// <param name="author"></param>
        public Book(string title, string isbn, string description, Author author)
        {
            BookCopies = new List<BookCopy>();
            this.Title = title;
            this.ISBN = isbn;
            this.Description = description;
            this.Author = author;
        }

        public Book() { BookCopies = new List<BookCopy>(); }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString() {
            return String.Format("[{0}] | {1} : {2} ({3})", this.BookID, this.ISBN, this.Title, this.Author);
        }
    }
}