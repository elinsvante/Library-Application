using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles and respond to requests from the Member service layer and either fetches and returns data or 
    /// save changes that has been made.
    /// </summary>
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor sets the context instance of the MemberRepository.
        /// </summary>
        /// <param name="c"></param>
        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Gets all Member in the context.
        /// </summary>
        /// <returns>All Member in the database.</returns>
        public IEnumerable<Member> All()
        {
            return context.Members;
        }

        /// <summary>
        /// Adds a Member to the context.
        /// </summary>
        /// <param name="m">The Member to be added to the database.</param>
        public void Add(Member m)
        {
            context.Members.Add(m);
            context.SaveChanges();
        }

        /// <summary>
        /// Removes a Member from the context.
        /// </summary>
        /// <param name="m">The Member object to be removed from the Database.</param>
        public void Remove(Member m)
        {
            context.Members.Remove(m);
            context.SaveChanges();
        }

        /// <summary>
        /// Searches in the context for the Member with the chosen memberID.
        /// </summary>
        /// <param name="memberID">The ID of the Member that wants to be found.</param>
        /// <returns>The Member object with the memberID.</returns>
        public Member Find(int memberID)
        {
            return context.Members.Find(memberID);
        }

        /// <summary>
        /// Tells the context to Save the changes that has been made.
        /// </summary>
        /// <param name="m">The Member object that will be edited and updated in the database.</param>
        public void Edit(Member m)
        {
            context.SaveChanges();
        }
    }
}
