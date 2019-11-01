using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    /// <summary>
    /// This class is a model for a loan of a existing BookCopy that a existing Member makes.
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Property ID for a Loan. Is unique and is set automatically when a new Loan object is initialized. Works as the primary key.
        /// </summary>
        public int LoanID { get; set; }

        /// <summary>
        /// Property time for when the loan was made.
        /// </summary>
        public DateTime TimeOfLoan { get; set; }

        /// <summary>
        /// Property time for when the loan is due.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Property to set when the loan is returned. If loan is not returned it is set to null.
        /// </summary>
        public string TimeOfReturn { get; set; }

        /// <summary>
        /// Property BookCopy of a Loan. A Loan needs to refer to a BookCopy.
        /// </summary>
        public BookCopy BookCopy { get; set; }

        /// <summary>
        /// Property Member of a Loan. A Loan needs to be made of a Member.
        /// </summary>
        public Member Member { get; set; }

        /// <summary>
        /// Construct sets the Loan properties.
        /// </summary>
        /// <param name="timeofloan"></param>
        /// <param name="duedate"></param>
        /// <param name="bookcopy"></param>
        /// <param name="member"></param>
        public Loan(DateTime timeofloan, DateTime duedate, BookCopy bookcopy, Member member)
        {
            this.TimeOfLoan = timeofloan;
            this.DueDate = duedate;
            this.BookCopy = bookcopy;
            this.Member = member;
            this.TimeOfReturn = null;
        }

        public Loan() { }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0}", this.BookCopy);
        }
    }
}
