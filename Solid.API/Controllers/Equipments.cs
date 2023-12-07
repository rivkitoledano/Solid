using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Equipments : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
         public Equipments(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }


        // GET: api/<Equipment>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_equipmentService.GetEquipments());
        }

        // GET api/<Equipment>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_equipmentService.GetById(id));
        }

        // POST api/<Equipment>
        [HttpPost]
        public void Post([FromBody] Equipment value)
        {
            _equipmentService.AddEquipment(value);
        }

        // PUT api/<Equipment>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Equipment  updatedEquipment)
        {
            _equipmentService.UpdateEquipment(id, updatedEquipment);

        }

        // DELETE api/<Equipment>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _equipmentService.DeleteEquipment(id);  

        }
    }
}
