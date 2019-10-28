using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class LoanService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        LoanRepository loanRepository;
        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
        }

        // A generic delegate EventHandlers that represents the method that will handle an event when the event provides data.
        public event EventHandler<EventArgs> Updated;

        //Methods that checks if there are subscribers to an event, if there is, the event is raised
        protected virtual void OnUpdated(object sender, EventArgs args)
        {
            Updated?.Invoke(this, args);
        }


        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        public IEnumerable<Loan> AllLoanForMember(Member member)
        {
            IEnumerable<Loan> loanForMember = loanRepository.All().Where(m => m.Member == member);
            return loanForMember.Where(l => l.TimeOfReturn == null).ToList();
        }

        public IEnumerable<Loan> AllBookCopiesOnLoan()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn == null).ToList();
        }

        public IEnumerable<Loan> AllBookCopiesOverdue()
        {
            DateTime timeNow = DateTime.Today;
            IEnumerable<Loan> overdueLoans = loanRepository.All().Where(l => l.DueDate < timeNow);
            return overdueLoans.Where(t => t.TimeOfReturn == null).ToList();
        }

        public IEnumerable<Loan> AllBookCopiesOverdueForMember(Member member)
        {
            DateTime timeNow = DateTime.Today;
            IEnumerable<Loan> overdueLoans = loanRepository.All().Where(l => l.DueDate < timeNow);
            IEnumerable<Loan> currentLoans = overdueLoans.Where(t => t.TimeOfReturn == null).ToList();
            return currentLoans.Where(m => m.Member == member);
        }

        public IEnumerable<Loan> AllReturnedLoanForMember(Member member)
        {
            IEnumerable<Loan> loanForMember = loanRepository.All().Where(m => m.Member == member);
            return loanForMember.Where(l => l.TimeOfReturn != null).ToList();
        }

        public IEnumerable<Loan> AllBookCopiesNotOnLoan()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn != null).ToList();
        }

        public void Add(Loan l)
        {
            loanRepository.Add(l);
            OnUpdated(this, EventArgs.Empty);
        }
        public void ReturnBook(Loan l)
        {
            loanRepository.Return(l);
            OnUpdated(this, EventArgs.Empty);
        }

    }
}
