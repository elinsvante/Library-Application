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
        IEnumerable<Loan> loans;

        public MembersLoanForm(IEnumerable<Loan> loansForMember, string member)
        {
            InitializeComponent();

            this.loans = loansForMember;

            tbMember.Text = member;
            ShowAllLoans(loansForMember);        
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
    }
}




