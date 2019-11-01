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
    public class MemberService : IService
    {
        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        MemberRepository memberRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        /// 
        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
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
        /// Uses the Loan repository to get all Member object from the database.
        /// </summary>
        /// <returns>A IEnumerable<Member> including all Member objects from the database.</returns>
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        /// <summary>
        /// Uses the Member repository to add a new Member object to the database and then raises the Updated() event.
        /// </summary>
        /// <param name="l">The Member object to be added to the database.</param>
        public void Add(Member m)
        {
            memberRepository.Add(m);
            OnUpdated(this, EventArgs.Empty);
        }
    }
}

