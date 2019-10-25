using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            Author author1 = new Author()
            {
                Name = "Elin Svantesson",
            };

            context.Authors.Add(author1);
            context.SaveChanges();

            Author author2 = new Author()
            {
                Name = "Katarina Bylöw",
            };

            context.Authors.Add(author2);
            context.SaveChanges();

            Book monteCristo = new Book() {
                Title = "The Count of Monte Cristo",
                ISBN = "92872819",
                Author = author1,
            };

            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);
            // Persist changes to the database
            context.SaveChanges();

            Book csharp = new Book()
            {
                Title = "C# Essentials",
                ISBN = "928738919",
                Author = author1,
            };

            context.Books.Add(csharp);
            context.SaveChanges();

            BookCopy bookcopy1 = new BookCopy()
            {
                Condition = 1,
                Book = monteCristo
            };

            BookCopy bookcopy2 = new BookCopy()
            {
                Condition = 10,
                Book = monteCristo
            };

            BookCopy bookcopy3 = new BookCopy()
            {
                Condition = 8,
                Book = monteCristo
            };


            BookCopy bookcopy4 = new BookCopy()
            {
                Condition = 8,
                Book = csharp
            };


            context.BookCopies.Add(bookcopy1);
            context.SaveChanges();
            context.BookCopies.Add(bookcopy2);
            context.SaveChanges();
            context.BookCopies.Add(bookcopy3);
            context.SaveChanges();
            context.BookCopies.Add(bookcopy4);
            context.SaveChanges();

            Member member1 = new Member()
            {
                Name = "Diyar Faraj",
                PersonalIdentityNumber = "8912268877",
                MembershipDate = DateTime.Today
            };

            context.Members.Add(member1);
            context.SaveChanges();

            Member member2 = new Member()
            {
                Name = "Lisa Svantesson",
                PersonalIdentityNumber = "9804240028",
                MembershipDate = DateTime.Today
            };

            context.Members.Add(member2);
            context.SaveChanges();

            Loan loan1 = new Loan()
            {
                TimeOfLoan = DateTime.Today,
                DueDate = DateTime.Today.AddDays(15),
                BookCopy = bookcopy1,
                Member = member1
            };

            context.Loans.Add(loan1);
            context.SaveChanges();

            Loan loan2 = new Loan()
            {
                TimeOfLoan = DateTime.Today.AddDays(-16),
                DueDate = DateTime.Today.AddDays(-1),
                BookCopy = bookcopy2,
                Member = member2
            };

            context.Loans.Add(loan2);
            context.SaveChanges();

        }
    }
}
