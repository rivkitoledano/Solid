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
        IEnumerable<Equipment> GetEquipments();
        Equipment GetById(int id);
        Task<Equipment> AddEquipmentAsync(Equipment equipment);

        Task<Equipment> UpdateEquipmentAsync(int id, Equipment equipment);

        Task<Equipment> DeleteEquipmentAsync(int id);
    }
}
