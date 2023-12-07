using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly DataContext _context;
        public EquipmentRepository(DataContext context)
        {
            _context = context;
        }
        public void AddEquipment(Equipment equipment)
        {
            _context.EquipmentList.Add(equipment);
        }

        public void DeleteEquipment(int id)
        {
            var tmp = _context.EquipmentList.Find(x=>x.EquipmentId==id);
           _context.EquipmentList.Remove(tmp);

        }

        public Equipment GetById(int id)
        {
            return _context.EquipmentList.Find(x => x.EquipmentId == id);
        }

        public List<Equipment> GetEquipments()
        {
            return _context.EquipmentList;
        }

        public void UpdateEquipment(int id, Equipment equipment)
        {
            var tmp = _context.EquipmentList.Find(x => x.EquipmentId == id);
            tmp = equipment;
        }
    }
}
