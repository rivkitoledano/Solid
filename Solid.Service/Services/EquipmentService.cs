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

        public void AddEquipment(Equipment equipment)
        {
            _equipmentService.AddEquipment(equipment);
        }

        public void DeleteEquipment(int id)
        {
            _equipmentService.DeleteEquipment(id);
        }

        public Equipment GetById(int id)
        {
            return _equipmentService.GetById(id);

        }

        public List<Equipment> GetEquipments()
        {
           return _equipmentService.GetEquipments();
        }

        public void UpdateEquipment(int id, Equipment equipment)
        { _equipmentService.UpdateEquipment(id, equipment);
        }
    }
}
