using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DataContext _context;
        public MemberRepository(DataContext context)
        {
            _context = context;
        }
        public void AddMember(Member member)
        {
            _context.MemberList.Add(member);
        }

        public void DeleteMember(int id)
        {
            var tmp =_context.MemberList.Find(x=>x.MemberId==id);
            _context.MemberList.Remove(tmp);

        }

        public Member GetById(int id)
        {
            return _context.MemberList.Find(x => x.MemberId == id);
            
        }

        public List<Member> GetMembers()
        {
            return _context.MemberList;
        }

        public void UpdateMember(int id, Member member)
        {
            var tmp = _context.MemberList.Find(x => x.MemberId == id);
            tmp = member;
        }
    }
}
