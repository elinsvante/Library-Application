using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Loan
    {
        public int LoanID { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public string TimeOfReturn { get; set; }
        public BookCopy BookCopy { get; set; }
        public Member Member { get; set; }

        public Loan() { }
        public Loan(DateTime timeofloan, DateTime duedate, BookCopy bookcopy, Member member)
        {
            this.TimeOfLoan = timeofloan;
            this.DueDate = duedate;
            this.BookCopy = bookcopy;
            this.Member = member;
            this.TimeOfReturn = null;
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.LoanID, this.BookCopy);
        }
    }
}
