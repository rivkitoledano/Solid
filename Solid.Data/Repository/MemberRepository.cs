using Microsoft.EntityFrameworkCore;
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
        public async Task<Member> AddMemberAsync(Member member)
        {
            _context.MemberList.Add(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task<Member> DeleteMemberAsync(int id)
        {
            var tmp =_context.MemberList.ToList().Find(x=>x.MemberId==id);
            _context.MemberList.Remove(tmp);
            await _context.SaveChangesAsync();
            return tmp; 

        }

        public Member GetById(int id)
        {
            return _context.MemberList.ToList().Find(x => x.MemberId == id);
            
        }

        public IEnumerable<Member> GetMembers()
        {
            return _context.MemberList.Include(cl=>cl.clss);
        }

        public async Task<Member> UpdateMemberAsync(int id, Member member)
        {
            var tmp = _context.MemberList.ToList().Find(x => x.MemberId == id);
            tmp = member;
            await _context.SaveChangesAsync();
            return member;

        }
    }
}
