using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    /// <summary>
    /// This class holds the business logic for the application and executes the queries requested by the GUI.
    /// It depend on and uses the Loan repository for reading and persisting data.
    /// </summary>
    public class LoanService : IService
    {
        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        LoanRepository loanRepository;
        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
        }

        /// <summary>
        /// An EventHandler that will be raised when a change has been made in the database to update the GUI.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Method to check if there are any subscribers to the event, if there is, the event is raised.
        /// </summary>
        /// <param name="sender">The object sender.</param>
        /// <param name="args">The EventArgs argument.</param>
        protected virtual void OnUpdated(object sender, EventArgs args)
        {
            Updated?.Invoke(this, args);
        }

        /// <summary>
        /// Uses the Loan repository to get all Loan object from the database.
        /// </summary>
        /// <returns>A IEnumerable<Loan> including all Loan objects from the database.</returns>
        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        /// <summary>
        /// Uses the Loan repository to add a new Loan object to the database and then raises the Updated() event.
        /// </summary>
        /// <param name="l">The Loan object to be added to the database.</param>
        public void Add(Loan l)
        {
            loanRepository.Add(l);
            OnUpdated(this, EventArgs.Empty);
        }

        /// <summary>
        /// Uses the Loan repository and LINQ to filter out all the Loans for the selected Member.
        /// </summary>
        /// <param name="member">The selected Member to filter out the Loans to be only the Loans of this Member.</param>
        /// <returns>A IEnumerable<Loan> including all Loan objects from the database for the selected Member.</returns>
        public IEnumerable<Loan> AllLoanForMember(Member member)
        {
            IEnumerable<Loan> loanForMember = loanRepository.All().Where(m => m.Member == member);
            return loanForMember.Where(l => l.TimeOfReturn == null).ToList();
        }

        /// <summary>
        /// Uses the Loan repository and LINQ to filter out all the Loans that are not been returned yet.
        /// </summary>
        /// <returns>A IEnumerable<Loan> including all Loan objects from the database that has not been returned yet.</returns>
        public IEnumerable<Loan> AllBookCopiesOnLoan()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn == null).ToList();
        }

        /// <summary>
        /// Uses the Loan repository and LINQ to filter out all the Loans that are overdue.
        /// </summary>
        /// <returns>A IEnumerable<Loan> including all Loan objects from the database that is overdue.</returns>
        public IEnumerable<Loan> AllBookCopiesOverdue()
        {
            DateTime timeNow = DateTime.Today;
            IEnumerable<Loan> overdueLoans = loanRepository.All().Where(l => l.DueDate < timeNow);
            return overdueLoans.Where(t => t.TimeOfReturn == null).ToList();
        }

        /// <summary>
        /// Uses the Loan repository and LINQ to filter out all the Loans that are overdue for the selected Member.
        /// </summary>
        /// <param name="member">The selected Member to filter out the Loans overdue to be only the Loans overdue of this Member</param>
        /// <returns>A IEnumerable<Loan> including all Loan objects from the database that is overdue for the selected Member.</returns>
        public IEnumerable<Loan> AllBookCopiesOverdueForMember(Member member)
        {
            DateTime timeNow = DateTime.Today;
            IEnumerable<Loan> overdueLoans = loanRepository.All().Where(l => l.DueDate < timeNow);
            IEnumerable<Loan> currentLoans = overdueLoans.Where(t => t.TimeOfReturn == null).ToList();
            return currentLoans.Where(m => m.Member == member);
        }

        /// <summary>
        /// Uses the Loan repository and LINQ to filter out all the Loans that are returned for the selected Member.
        /// </summary>
        /// <param name="member">The selected Member to filter out the returned Loans to be only the returned Loans of this Member</param>
        /// <returns>A IEnumerable<Loan> including all Loan objects from the database that is returned for the selected Member.</returns>
        public IEnumerable<Loan> AllReturnedLoanForMember(Member member)
        {
            IEnumerable<Loan> loanForMember = loanRepository.All().Where(m => m.Member == member);
            return loanForMember.Where(l => l.TimeOfReturn != null).ToList();
        }

        public IEnumerable<Loan> AllReturnedLoan()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn != null).ToList();
        }

        /// <summary>
        /// Uses the Loan Repository to save the changes after Loan.TimeOfReturn is set from null to the return time, then raises the Updated() event.
        /// </summary>
        /// <param name="l">The Loan object to be returned and therefore edited in the database.</param>
        public void ReturnBook(Loan l)
        {
            loanRepository.Edit(l);
            OnUpdated(this, EventArgs.Empty);
        }
    }
}
