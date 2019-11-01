using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    /// <summary>
    /// This class is a model for an author with a name and collection of books.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Property ID for an Author. Is unique and is set automatically when a new Author object is initialized. Works as the primary key.
        /// </summary>
        public int authorID { get; set; }

        /// <summary>
        /// Property name of an Author.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property Collection of Books for an Author.
        /// </summary>
        public ICollection<Book> Books { get; set; }

        /// <summary>
        /// Constructor sets the name of an Author and creates a list for the Book-collection.
        /// </summary>
        /// <param name="name"></param>
        public Author(string name)
        {
            Books = new List<Book>();
            this.Name = name;
        }

        public Author() { Books = new List<Book>(); }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }
    }
}
