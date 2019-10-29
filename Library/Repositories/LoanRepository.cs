using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;
        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        public void Add(Loan l)
        {
            context.Loans.Add(l);
            context.SaveChanges();
        }

        public void Return(Loan l)
        {
            context.SaveChanges();
        }

        public void Remove(Loan l)
        {
            context.Loans.Remove(l);
            context.SaveChanges();
        }

        public Loan Find(int loanID)
        {
            return context.Loans.Find(loanID);
        }

        public void Edit(Loan l)
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }
    }
}
