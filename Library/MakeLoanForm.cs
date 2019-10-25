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
    public partial class MakeLoanForm : Form
    {


        MemberService memberService;
        LoanService loanService;
        private BookCopy bookCopy;


        public MakeLoanForm(BookCopy bookCopy, string bookCopyText)
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.memberService = new MemberService(repFactory);
            this.loanService = new LoanService(repFactory);

            this.bookCopy = bookCopy;
            tbLoan.Text = bookCopyText;
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

        private void BTNMakeLoan_Click(object sender, EventArgs e)
        {
            Member member = lbMembers.SelectedItem as Member;
            if (member != null)
            {
                DateTime timeOfLoan = DateTime.Now;
                DateTime dueDate = timeOfLoan.AddDays(15);
                Loan newLoan = new Loan(timeOfLoan, dueDate, bookCopy, member);
                loanService.Add(newLoan);
                this.Close();
            }
            else
            {
                MessageBox.Show("You have to choose a member to make the loan.");
            }
        }
    }
}
