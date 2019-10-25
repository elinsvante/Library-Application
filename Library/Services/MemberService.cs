using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class MemberService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        MemberRepository memberRepository;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        public IEnumerable<Loan> AllLoanForMember(Member member)
        {
            return memberRepository.All().Where(m => m == member).SelectMany(book => book.Loans);
        }

        public void Add(Member m)
        {
            memberRepository.Add(m);
        }
    }
}

