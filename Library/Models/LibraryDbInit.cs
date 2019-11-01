using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method it's possible to create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            Author author1 = new Author()
            {
                Name = "Kristina Ohlsson",
            };

            context.Authors.Add(author1);
            context.SaveChanges();

            Author author2 = new Author()
            {
                Name = "Jonas Moström",
            };

            context.Authors.Add(author2);
            context.SaveChanges();

            Book book1 = new Book() {
                Title = "Henrys Hemlighet",
                ISBN = "9789164206138",
                Author = author1,
            };

            // Add the book to the DbSet of books.
            context.Books.Add(book1);
            // Persist changes to the database
            context.SaveChanges();

            Book book2 = new Book()
            {
                Title = "Varulvens Hemlighet",
                ISBN = "9789188279477",
                Author = author1,
            };

            context.Books.Add(book2);
            context.SaveChanges();

            BookCopy bookcopy1 = new BookCopy()
            {
                Condition = 1,
                Book = book1
            };

            BookCopy bookcopy2 = new BookCopy()
            {
                Condition = 10,
                Book = book1
            };

            BookCopy bookcopy3 = new BookCopy()
            {
                Condition = 8,
                Book = book2
            };


            context.BookCopies.Add(bookcopy1);
            context.SaveChanges();
            context.BookCopies.Add(bookcopy2);
            context.SaveChanges();
            context.BookCopies.Add(bookcopy3);
            context.SaveChanges();

            Member member1 = new Member()
            {
                Name = "Elin Svantesson",
                PersonalIdentityNumber = "9602253743",
                MembershipDate = DateTime.Now.AddDays(-12).Date
            };

            context.Members.Add(member1);
            context.SaveChanges();

            Member member2 = new Member()
            {
                Name = "Lisa Svantesson",
                PersonalIdentityNumber = "9804240028",
                MembershipDate = DateTime.Now.AddDays(-150).Date
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
                BookCopy = bookcopy3,
                Member = member2
            };

            context.Loans.Add(loan2);
            context.SaveChanges();
        }
    }
}
