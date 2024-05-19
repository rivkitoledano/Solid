using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IUserService
    {
        Task<Login> AuthenticateAsync(string username, string password);

    }
}
