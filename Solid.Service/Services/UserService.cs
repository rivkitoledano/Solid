using Solid.Core.Entities;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class UserService : IUserService
    {
        private readonly List<Login> _users = new List<Login>
    {
        new Login { UserName = "rivki", Password = "3259" } // משתמשים דוגמא
    };

        public Task<Login> AuthenticateAsync(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.UserName == username && x.Password == password);
            return Task.FromResult(user);
        }
    }
}
