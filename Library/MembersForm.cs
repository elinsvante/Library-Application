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
    public partial class MembersForm : Form
    {

        MemberService memberService;
        LoanService loanService;
        BookCopyService bookCopyService;
        BookService bookService;
        IEnumerable<Loan> loans;

        public MembersForm(IEnumerable<Loan> loansForMember)
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.memberService = new MemberService(repFactory);
            this.loanService = new LoanService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.bookService = new BookService(repFactory);

            ShowAllMembers(memberService.All());
            ShowAllLoans(loansForMember);

            this.loans = loansForMember;
        }

        private void UpdateForm(object sender, FormClosingEventArgs e)
        {
            ShowAllMembers(memberService.All());
        }


        private void ShowAllMembers(IEnumerable<Member> members)
        {
            lbMembers.Items.Clear();
            foreach (Member member in members)
            {
                lbMembers.Items.Add(member);
            }
        }

        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbMembersLoan.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbMembersLoan.Items.Add(loan);
            }
        }


        private void BTNAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm newForm = new AddMemberForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateForm);
            newForm.Show();
        }

        private void BTNLoanForMember_Click(object sender, EventArgs e)
        {
            Member selectedMember = lbMembers.SelectedItem as Member;
            IEnumerable<Loan> loansForMember = loanService.AllLoanForMember(selectedMember);

            IEnumerable<BookCopy> allAllBookCopiesOnLoan = bookCopyService.AllBookCopiesOnLoanForMember(loansForMember);

                foreach (BookCopy copy in allAllBookCopiesOnLoan)
                {
                    lbMembersLoan.Items.Add(copy.Book.Title);
                }
        }
    }
}
