using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberService;
        public MemberService(IMemberRepository memberService)
        {
            _memberService = memberService;      
        }

        public async Task<Member> AddMemberAsync(Member member)
        {
         return   await _memberService.AddMemberAsync(member);
                    
        }

        public async Task<Member> DeleteMemberAsync(int id)
        {
          return await  _memberService.DeleteMemberAsync(id);
        }

        public Member GetById(int id)
        {
          return  _memberService.GetById(id); 
        }

        public IEnumerable<Member> GetMembers()
        {
          return  _memberService.GetMembers();    
        
        }

        public async Task<Member> UpdateMemberAsync(int id, Member member)
        {
          return  await _memberService.UpdateMemberAsync(id, member);
        }
    }
}
