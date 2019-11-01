using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles instantiation of the repositories.
    /// </summary>
    public class RepositoryFactory
    {
        private LibraryContext context;

        /// <param name="c">A Librarycontext that will be shared among repositories</param>
        public RepositoryFactory(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Retrieve a Book repository instance.
        /// </summary>
        /// <returns></returns>
        public BookRepository CreateBookRepository()
        {
            return new BookRepository(context);
        }

        /// <summary>
        /// Retrieve a BookCopy repository instance.
        /// </summary>
        /// <returns></returns>
        public BookCopyRepository CreateBookCopyRepository()
        {
            return new BookCopyRepository(context);
        }

        /// <summary>
        /// Retrieve an Author repository instance.
        /// </summary>
        /// <returns></returns>
        public AuthorRepository CreateAuthorRepository()
        {
            return new AuthorRepository(context);
        }

        /// <summary>
        /// Retrieve a Loan repository instance.
        /// </summary>
        /// <returns></returns>
        public LoanRepository CreateLoanRepository()
        {
            return new LoanRepository(context);
        }

        /// <summary>
        /// Retrieve a Member repository instance.
        /// </summary>
        /// <returns></returns>
        public MemberRepository CreateMemberRepository()
        {
            return new MemberRepository(context);
        }
    }
}
