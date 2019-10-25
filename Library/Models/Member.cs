using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string PersonalIdentityNumber { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; }
        public ICollection<Loan> Loans { get; set; }

        public Member() { Loans = new List<Loan>(); }
        public Member(string name, string id, DateTime date)
        {
            Loans = new List<Loan>();
            this.Name = name;
            this.PersonalIdentityNumber = id;
            this.MembershipDate = date;
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }
    }
}
