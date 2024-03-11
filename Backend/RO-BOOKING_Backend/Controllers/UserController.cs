using IdentityServer3.Core.Services;
using Microsoft.AspNetCore.Mvc;
using RO_BOOKING_Backend.Repositories;

namespace RO_BOOKING_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IUserService _service;

        public UserController(IRepositoryWrapper repository, IUserService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _repository.User.GetAllUsers();

            return Ok(new { users });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var User = await _repository.User.GetByIdAsync(id);

            return Ok(new { User });
        }
    }
}
