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

        public MembersForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.memberService = new MemberService(repFactory);

            ShowAllMembers(memberService.All());
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
                lbMembers.Items.Add("[" + member.MemberID + "] -- " + member.Name + " (" + member.PersonalIdentityNumber + ") " + "Member since: " + member.MembershipDate.ToString("yyy/MM/dd"));
            }
        }

        private void BTNAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm newForm = new AddMemberForm();
            newForm.FormClosing += new FormClosingEventHandler(UpdateForm);
            newForm.Show();
        }
    }
}
