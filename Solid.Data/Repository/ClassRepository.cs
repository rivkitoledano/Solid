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
        public void AddClass(Class clss)
        {
            _context.ClassList.Add(clss);
        }

        public void DeleteClass(int id)
        {
            var tmp = _context.ClassList.Find(x => x.ClassId == id);
            _context.ClassList.Remove(tmp);
        }

        public Class GetById(int id)
        {
            return _context.ClassList.Find(x => x.ClassId == id);
        }

        public List<Class> GetClasses()
        {
            return _context.ClassList;
        }

        public void UpdateClass(int id, Class clss)
        {
            var tmp = _context.ClassList.Find(x => x.ClassId == id);
            tmp = clss;
        }
    }
}
