using Microsoft.AspNetCore.Mvc;
using ProjectAnimes.Models.Requests.Login;

namespace ProjectAnimes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginRequest loginRequest)
        {
            return Ok("Logged in.");
        }
    }
}
