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
        private readonly IClassRepository _ClassRepository;
        public ClassService(IClassRepository classService)
        {
            _ClassRepository = classService;
        }
        public async Task<Class> AddClassAsync(Class clss)
        {
            return await  _ClassRepository.AddClassAsync(clss);
             
        }

        public async Task<Class> DeleteClassAsync(int id)
        {
         return await  _ClassRepository.DeleteClassAsync(id);
            
        }

        public Class GetById(int id)
        {
            return _ClassRepository.GetById(id);
        }

        public IEnumerable<Class> GetClasses()
        {
            return _ClassRepository.GetClasses();
        }

        public async Task<Class> UpdateClassAsync(int id, Class clss)
        {
           return  await _ClassRepository.UpdateClassAsync(id, clss);  
            
        }
    }
}
