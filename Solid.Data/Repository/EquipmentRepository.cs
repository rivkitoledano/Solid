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
        public Task<Equipment> AddEquipmentAsync(Equipment equipment)
        {
            _context.EquipmentList.Add(equipment);
            await _context.SaveChangesAsync();
            return equipment;

        }

        public async Task<Equipment> DeleteEquipmentAsync(int id)
        {
            var tmp = _context.EquipmentList.ToList().Find(x=>x.EquipmentId==id);
            _context.EquipmentList.Remove(tmp);
          await  _context.SaveChangesAsync();
            return tmp;

        }

        public Equipment GetById(int id)
        {
            return _context.EquipmentList.ToList().Find(x => x.EquipmentId == id);
        }

        public IEnumerable<Equipment> GetEquipments()
        {
            return _context.EquipmentList.ToList();
        }

        public async Task<Equipment> UpdateEquipmentAsync(int id, Equipment equipment)
        {
            var tmp = _context.EquipmentList.ToList().Find(x => x.EquipmentId == id);
            tmp = equipment;
            await _context.SaveChangesAsync();
            return equipment;

        }
    }
}
