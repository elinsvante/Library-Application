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
       
        public Member member;
        LoanService loanService;

        public MembersLoanForm(Member member, LoanService loanService)
        {
            InitializeComponent();

            this.loanService = loanService;

            this.member = member;
            ShowAllLoans(loanService.AllLoanForMember(member));

            loanService.Updated += ListChangedMethod;
        }

        private void ListChangedMethod(object sender, EventArgs e)
        {
            lbMemberLoan.Items.Clear();
            ShowAllLoans(loanService.AllLoanForMember(member));
        }


        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbMemberLoan.Items.Clear();
            foreach (Loan loan in loans)
            {
                if(loan.TimeOfReturn != null)
                {
                    lbMemberLoan.Items.Add(loan);                 
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
                ShowAllLoans(loanService.AllLoanForMember(member));
            }
            else if (dropDown_filterLoans.SelectedItem.ToString() == "Loans Overdue")
            {
                lbMemberLoan.Items.Clear();
                foreach (Loan loan in loanService.AllBookCopiesOverdueForMember(member))
                {
                    DateTime timeNow = DateTime.Today;
                    if(loan.DueDate < timeNow )
                    {
                        lbMemberLoan.Items.Add(loan);
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
                foreach (Loan loan in loanService.AllReturnedLoanForMember(member))
                {
                    if (loan.TimeOfReturn != null)
                    {
                        lbMemberLoan.Items.Add(loan);
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
        }
    }
}




