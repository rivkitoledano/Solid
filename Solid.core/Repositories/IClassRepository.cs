using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IClassRepository
    {
        List<Class> GetClasses();

        Class GetById(int id);

        void AddClass(Class clss);

        void UpdateClass(int id, Class clss);

        void DeleteClass(int id); 

        


    }
}
