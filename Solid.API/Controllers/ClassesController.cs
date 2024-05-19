using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System;
using Solid.Core.Services;
using Solid.Service.Services;
using Solid.Core.Entities;
using AutoMapper;
using Solid.Core.Dto;
using Solid.API.Models;
using AutoMapper.Execution;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace Solid.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;
        private readonly IMapper _mapper;

        public ClassesController(IClassService classService, IMapper mapper)
        {
            _classService = classService;
            _mapper = mapper;
        }

        // GET: api/<Class>
        [HttpGet]
        public IActionResult Get()
        {
            var classes = _classService.GetClasses();


            var classesDto= _mapper.Map<IEnumerable<ClassDto>>(classes);
            return Ok(classes);
        }

        // GET api/<Class>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var clss = _classService.GetById(id);
            var classDto = _mapper.Map<ClassDto>(clss);
            return Ok(classDto);

        }

        // POST api/<Class>
        [HttpPost]
        public async Task<Class> Post([FromBody] ClassPostModel value) {
           var classToAdd = new Class()
            {
                AgeAppropriate = value.AgeAppropriate,
                Day = value.Day,
                Guide = value.Guide,
                Hour = value.Hour,
                Name = value.Name,
                NumOfParticipants = value.NumOfParticipants,
                RomNum = value.RomNum
            };
            return await _classService.AddClassAsync(classToAdd);
        } 

        // PUT api/<Class>/5
        [HttpPut("{id}")]
        public async Task<Class> Put(int id, [FromBody] Class value)
        {
          return await _classService.UpdateClassAsync(id, value);
        }

        // DELETE api/<Class>/5
        [HttpDelete("{id}")]
        public async Task<Class> Delete(int id)
        {
           return await _classService.DeleteClassAsync(id);
        }
    }
}
