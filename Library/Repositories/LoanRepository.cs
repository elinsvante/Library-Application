using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles and respond to requests from the Loan service layer and either fetches and returns data or 
    /// save changes that has been made.
    /// </summary>
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor sets the context instance of the LoanRepository.
        /// </summary>
        /// <param name="c"></param>
        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Gets all Loan in the context.
        /// </summary>
        /// <returns>All Loan in the database.</returns>
        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        /// <summary>
        /// Adds a Loan to the context.
        /// </summary>
        /// <param name="l">The Loan object to be added to the database.</param>
        public void Add(Loan l)
        {
            context.Loans.Add(l);
            context.SaveChanges();
        }

        /// <summary>
        /// Removes a Loan from the context.
        /// </summary>
        /// <param name="l">The Loan object to be removed from the database.</param>
        public void Remove(Loan l)
        {
            context.Loans.Remove(l);
            context.SaveChanges();
        }

        /// <summary>
        /// Searches in the context for the Loan with the chosen loanID.
        /// </summary>
        /// <param name="loanID">The ID of the Loan that wants to be found.</param>
        /// <returns>The Loan object with the loanID.</returns>
        public Loan Find(int loanID)
        {
            return context.Loans.Find(loanID);
        }

        /// <summary>
        /// Tells the context to Save the changes that has been made.
        /// </summary>
        /// <param name="l">The Loan object that will be edited and updated in the database.</param>
        public void Edit(Loan l)
        {
            context.SaveChanges();
        }
    }
}
