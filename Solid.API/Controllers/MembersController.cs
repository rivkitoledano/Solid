using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Solid.API.Models;
using Solid.Core.Dto;
using Solid.Core.Entities;
using Solid.Core.Services;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;

        public MembersController(IMemberService memberService,IMapper mapper)
        {
            _memberService=memberService;
            _mapper=mapper;   
        }
        // GET: api/<Members>
        [HttpGet]
        public IActionResult Get()
        {
            var members = _memberService.GetMembers();
            var memberDtos = _mapper.Map<IEnumerable<MemberDto>>(members);
            return Ok(memberDtos);
        }

        // GET api/<Members>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var member = _memberService.GetById(id);
            var memberDto = _mapper.Map<MemberDto>(member);
            return Ok(memberDto);
        }

        // POST api/<Members>
        [HttpPost]
        public async Task<Member> Post([FromBody] MemberPostModel value)
        {
            var memberToAdd = new Member { Name = value.Name, Age = value.Age,classId=value.classId };
          return  await _memberService.AddMemberAsync(memberToAdd);
        }

        // PUT api/<Members>/5
        [HttpPut("{id}")]
        public async Task<Member> Put(int id, [FromBody] Member value)
        {
           return await _memberService.UpdateMemberAsync(id, value);
        }

        // DELETE api/<Members>/5
        [HttpDelete("{id}")]
        public async Task<Member> Delete(int id)
        {
          return await _memberService.DeleteMemberAsync(id);    
        }
    }
}
