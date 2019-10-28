using System;
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
    public partial class AddMemberForm : Form
    {
        MemberService memberService;
        public AddMemberForm()
        {
            InitializeComponent();
            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.memberService = new MemberService(repFactory);
        }

        private void BTNAddMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please enter the new members name.");
            }
            else if (string.IsNullOrWhiteSpace(tbPersonalNumber.Text))
            {
                MessageBox.Show("Please enter the members personal identification number.");
            }
            else
            {
                string name = tbName.Text;
                string personalNumber = tbPersonalNumber.Text;
                DateTime dateTimeToday = DateTime.Today.Date;
                Member newMember = new Member(name, personalNumber, dateTimeToday);
                memberService.Add(newMember);
                this.Close();
            }
        }
    }
}
