using DI_example.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_example.Server.Services
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
    }
}
