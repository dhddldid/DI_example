using DI_example.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_example.Server.Services
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> GetAll()
        {
            return new List<User>()
        {
            new User()
            {
                Name = "김서준",
                DateOfBirth = new DateTime(2007, 1, 3)
            },
            new User()
            {
                Name = "이시우",
                DateOfBirth = new DateTime(2008, 3, 13)
            },
            new User()
            {
                Name = "박이서",
                DateOfBirth = new DateTime(2002, 2, 2)
            },
            new User()
            {
                Name = "최이서",
                DateOfBirth = new DateTime(2010, 4,5)
            }
        };
        }
    }
}
