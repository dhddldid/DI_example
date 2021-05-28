using DI_example.Server.Services;
using DI_example.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_example.Server.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // IUserRepositoy의 private readonly 인스턴스를 가지고 있다.
        private readonly IUserRepository _userRepository;

        // 생성자는 IUserRepository 타입의 인스턴스를 가져와서 우리의 private 인스턴스에 할당한다.
        // 가장 간단한 형태의 생성자 주입
        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

    }
}
