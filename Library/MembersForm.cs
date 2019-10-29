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
        public MembersForm(MemberService memberService)
        {
            InitializeComponent();

            this.memberService = memberService;

            ShowAllMembers(memberService.All());

            memberService.Updated += memberUpdate;
        }

        private void memberUpdate(object sender, EventArgs e)
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
            AddMemberForm newForm = new AddMemberForm(memberService);
            newForm.Show();
        }
    }
}
