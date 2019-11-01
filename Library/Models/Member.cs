using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    /// <summary>
    /// This class is a model for a member with a name, personal ID number, membership date and a collection of loans.
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Property ID for a Member. Is unique and is set automatically when a new Member object is initialized. Works as the primary key.
        /// </summary>
        public int MemberID { get; set; }

        /// <summary>
        /// Property personal Identity Number of a Member. Is NOT to be mixed up with the MemberID which is the primary key.
        /// </summary>
        public string PersonalIdentityNumber { get; set; }

        /// <summary>
        /// Property name of a Member.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property date when the membership was created.
        /// </summary>
        public DateTime MembershipDate { get; set; }

        /// <summary>
        /// Property Collection of Loans for a Member. A Member can have 0 or more Loans.
        /// </summary>
        public ICollection<Loan> Loans { get; set; }

       /// <summary>
       /// Construct sets the properties of a Member and creates a list for the Loan-collection.
       /// </summary>
       /// <param name="name"></param>
       /// <param name="id"></param>
       /// <param name="date"></param>
        public Member(string name, string id, DateTime date)
        {
            Loans = new List<Loan>();
            this.Name = name;
            this.PersonalIdentityNumber = id;
            this.MembershipDate = date;
        }

        public Member() { Loans = new List<Loan>(); }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }
    }
}
