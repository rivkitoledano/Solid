using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IClassService
    {
        IEnumerable<Class> GetClasses();
        Class GetById(int id);
        Task<Class> AddClassAsync(Class clss);

        Task<Class> UpdateClassAsync(int id, Class clss);

        Task<Class> DeleteClassAsync(int id);

    }

}
