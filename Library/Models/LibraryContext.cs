using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models {

    /// <summary>
    /// Derived context.
    /// </summary>
    public class LibraryContext : DbContext {

        /// <summary>
        /// Context is configured to use a 'LibraryContext' connection string from the application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Library.Models.LibraryContext' database on the LocalDb instance.
        /// </summary>
        public LibraryContext(){
            // Database strategy
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());
        }

        /// <summary>
        /// A DBSet for the entity type Books.
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// A DBSet for the entity type Authors.
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <summary>
        /// A DBSet for the entity type BookCopies.
        /// </summary>
        public DbSet<BookCopy> BookCopies { get; set; }

        /// <summary>
        /// A DBSet for the entity type Loans.
        /// </summary>
        public DbSet<Loan> Loans { get; set; }

        /// <summary>
        /// A DBSet for the entity type Members.
        /// </summary>
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}