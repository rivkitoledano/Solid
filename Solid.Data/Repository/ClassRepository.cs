using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class ClassRepository : IClassRepository
    {
        private readonly DataContext _context;
        public ClassRepository(DataContext context)
        {
             _context=context;
        }
        public async Task<Class> AddClassAsync(Class clss)
        {
            _context.ClassList.Add(clss);
             await _context.SaveChangesAsync();
            return clss;
        }

        public async Task<Class> DeleteClassAsync(int id)
        {
            var tmp = _context.ClassList.ToList().Find(x => x.ClassId == id);
            _context.ClassList.Remove(tmp);
             await _context.SaveChangesAsync();
            return tmp;
        }

        public Class GetById(int id)
        {
            return _context.ClassList.Find(id);
        }

        public IEnumerable<Class> GetClasses()
        {
            return _context.ClassList.ToList();
        }

        public async Task<Class> UpdateClassAsync(int id, Class clss)
        {
            var tmp = _context.ClassList.ToList().Find(x => x.ClassId == id);
            tmp = clss;
             await _context.SaveChangesAsync();
            return clss;

        }
    }
}
