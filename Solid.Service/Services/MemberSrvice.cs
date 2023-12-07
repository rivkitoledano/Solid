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

        public void AddMember(Member member)
        {
            _memberService.AddMember(member);
                    
        }

        public void DeleteMember(int id)
        {
            _memberService.DeleteMember(id);
        }

        public Member GetById(int id)
        {
          return  _memberService.GetById(id); 
        }

        public List<Member> GetMembers()
        {
          return  _memberService.GetMembers();    
        
        }

        public void UpdateMember(int id, Member member)
        {
            _memberService.UpdateMember(id, member);
        }
    }
}
