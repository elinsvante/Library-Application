using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository
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
    }
}
