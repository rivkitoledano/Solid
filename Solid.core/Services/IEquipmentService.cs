using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IEquipmentService
    {
        List<Equipment> GetEquipments();
        Equipment GetById(int id);
        void AddEquipment(Equipment equipment);

        void UpdateEquipment(int id, Equipment equipment);

        void DeleteEquipment(int id);
    }
}
