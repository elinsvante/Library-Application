using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class MemberRepository
    {
        LibraryContext context;
        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }
        public IEnumerable<Member> All()
        {
            return context.Members;
        }

        public void Add(Member m)
        {
            context.Members.Add(m);
            context.SaveChanges();
        }
    }
}
