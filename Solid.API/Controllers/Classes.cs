using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System;
using Solid.Core.Services;
using Solid.Service.Services;
using Solid.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace Solid.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Classes : ControllerBase
    {
        private readonly IClassService _classService;
        public Classes(IClassService classService)
        {
            _classService = classService;
        }

        // GET: api/<Class>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_classService.GetClasses());
        }

        // GET api/<Class>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_classService.GetById(id));
        }

        // POST api/<Class>
        [HttpPost]
        public void Post([FromBody] Class value)
        {
            _classService.AddClass(value);   
        }

        // PUT api/<Class>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Class value)
        {
           _classService.UpdateClass(id, value);
        }

        // DELETE api/<Class>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _classService.DeleteClass(id);
        }
    }
}
