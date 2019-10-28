using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MembersLoanForm : Form
    {
        LoanService loanService;
        public IEnumerable<Loan> loans;
        public Member member;

        public MembersLoanForm(IEnumerable<Loan> loansForMember, Member member)
        {
            InitializeComponent();
            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.loanService = new LoanService(repFactory);

            this.loans = loansForMember;
            this.member = member;
            ShowAllLoans(loansForMember);

            loanService.Updated += ListChangedMethod;
        }

        private void ListChangedMethod(object sender, EventArgs e)
        {
            ShowAllLoans(loans);
        }


        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbMemberLoan.Items.Clear();
            foreach (Loan loan in loans)
            {
                if(loan.TimeOfReturn != null)
                {
                    lbMemberLoan.Items.Add(loan + " (RETURNED)");                 
                }
                else
                {
                    lbMemberLoan.Items.Add(loan);
                }
            }
        }

        private void dropDown_filterLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown_filterLoans.SelectedItem.ToString() == "All Loans")
            {
                ShowAllLoans(loans);
            }
            else if (dropDown_filterLoans.SelectedItem.ToString() == "Loans Overdue")
            {
                lbMemberLoan.Items.Clear();
                foreach (Loan loan in loans)
                {
                    DateTime timeNow = DateTime.Today;
                    if(loan.DueDate < timeNow )
                    {
                        lbMemberLoan.Items.Add(loan + " Due: " + loan.DueDate);
                    }
                    else
                    {
                        lbMemberLoan.Items.Add("No loans overdue.");
                    }
                }
            }
            else if (dropDown_filterLoans.SelectedItem.ToString() == "Loans Returned")
            {
                lbMemberLoan.Items.Clear();
                foreach (Loan loan in loans)
                {
                    if (loan.TimeOfReturn != null)
                    {
                        lbMemberLoan.Items.Add(loan + " Returned: (" + loan.TimeOfReturn + ")");
                    }
                }
                if (lbMemberLoan.Items.Count == 0)
                {
                    lbMemberLoan.Items.Add("No loans returned.");
                }
            }
        }

        private void BTNReturnBook_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = lbMemberLoan.SelectedItem as Loan;
            loanService.ReturnBook(selectedLoan);
            loans = loanService.AllLoanForMember(member);
            ShowAllLoans(loans);
        }
    }
}




