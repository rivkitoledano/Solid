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
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classService;
        public ClassService(IClassRepository classService)
        {
            _classService = classService;
        }

        public void AddClass(Class clss)
        {
            _classService.AddClass(clss);
        }

        public void DeleteClass(int id)
        {
            _classService.DeleteClass(id);
        }

        public Class GetById(int id)
        {
            return _classService.GetById(id);
        }

        public List<Class> GetClasses()
        {
            return _classService.GetClasses();
        }

        public void UpdateClass(int id, Class clss)
        {
            _classService.UpdateClass(id, clss);    
        }
    }
}
