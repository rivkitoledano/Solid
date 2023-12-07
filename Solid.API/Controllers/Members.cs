using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Solid.Core.Entities;
using Solid.Core.Services;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Members : ControllerBase
    {
        private readonly IMemberService _memberService;
        public Members(IMemberService memberService)
        {
            _memberService=memberService;
        }
        // GET: api/<Members>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_memberService.GetMembers());
        }

        // GET api/<Members>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_memberService.GetById(id));
        }

        // POST api/<Members>
        [HttpPost]
        public void Post([FromBody] Member value)
        {
            _memberService.AddMember(value);
        }

        // PUT api/<Members>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Member value)
        {
            _memberService.UpdateMember(id, value);
        }

        // DELETE api/<Members>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _memberService.DeleteMember(id);    
        }
    }
}
