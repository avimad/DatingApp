using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;

        }
        public async Task<IActionResult> Register(string username, string password)
        {
            // validate Request
            username = username.ToLower();

            if (await _repo.UserExists(username))
                return BadRequest("User alredy Exist");

            var userToCreate = new User
            {
                Username = username
            };

            var createdUser = _repo.Register(userToCreate, password);
            return StatusCode(201);


        }
    }
}