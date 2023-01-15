using KahootContracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KahootAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetAllUsers", Name = nameof(GetAllUser))]
        public IActionResult GetAllUser() 
        {
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }
        [HttpGet("user/{id}", Name = nameof(GetUserById))]
        public IActionResult GetUserById(int id) 
        {
            var user = _userRepository.GetUserById(id);
            return Ok(user);
        }

        [HttpPost]

        public IActionResult CreateUser(User user)
        {
            _userRepository.CreateUser(user);
            return Ok();
        }

    }
}
