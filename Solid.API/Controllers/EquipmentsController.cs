using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.Dto;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service.Services;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        private readonly IMapper _mapper;

        public EquipmentsController(IEquipmentService equipmentService, IMapper mapper)
        {
            _equipmentService = equipmentService;
            _mapper = mapper;
        }


        // GET: api/<Equipment>
        [HttpGet]
        public IActionResult Get()
        {
            var equipments = _equipmentService.GetEquipments();
            var equipmentsDto = _mapper.Map<IEnumerable<EquipmentDto>>(equipments); ;
            return Ok(equipmentsDto);
            
        }

        // GET api/<Equipment>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var equipmemt = _equipmentService.GetById(id);
            var equipmemtDto = _mapper.Map<EquipmentDto>(equipmemt);
            return Ok(equipmemtDto);
        }

        // POST api/<Equipment>
        [HttpPost]
        public async Task<Equipment> Post([FromBody] EquipmentPostModel value)
        {
            var equipmentToAdd = new Equipment { Name = value.Name,Category=value.Category,AmountItem=value.AmountItem};
           return await _equipmentService.AddEquipmentAsync(equipmentToAdd);
        }

        // PUT api/<Equipment>/5
        [HttpPut("{id}")]
        public async Task<Equipment> Put(int id, [FromBody] Equipment  updatedEquipment)
        {
          return await  _equipmentService.UpdateEquipmentAsync(id, updatedEquipment);

        }

        // DELETE api/<Equipment>/5
        [HttpDelete("{id}")]
        public async Task<Equipment> Delete(int id)
        {
           return await _equipmentService.DeleteEquipmentAsync(id);  
        }
    }
}
