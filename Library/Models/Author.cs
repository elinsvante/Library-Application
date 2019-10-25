using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Author
    {
        public int authorID { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

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
            return String.Format("[{0}] -- {1}", this.authorID, this.Name);
        }
    }
}
