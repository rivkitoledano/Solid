using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentService;
        public EquipmentService(IEquipmentRepository equipmentService)
        {
            _equipmentService = equipmentService;
        }

        public async Task<Equipment> AddEquipmentAsync(Equipment equipment)
        {
           return await _equipmentService.AddEquipmentAsync(equipment);
        }

        public async Task<Equipment> DeleteEquipmentAsync(int id)
        {
         return await   _equipmentService.DeleteEquipmentAsync(id);
        }

        public Equipment GetById(int id)
        {
            return _equipmentService.GetById(id);

        }

        public IEnumerable<Equipment> GetEquipments()
        {
           return _equipmentService.GetEquipments();
        }

        public async Task<Equipment> UpdateEquipmentAsync(int id, Equipment equipment)
        {
           return await _equipmentService.UpdateEquipmentAsync(id, equipment);
        }
    }
}
