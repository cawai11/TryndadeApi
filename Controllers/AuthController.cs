using Microsoft.AspNetCore.Mvc;
using TryndadeApi.Interface;
using TryndadeApi.Models;
// outras diretivas de uso...

namespace TryndadeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthUserService _authUserService;

        public AuthController(IAuthUserService authUserService)
        {
            _authUserService = authUserService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthUsers login)
        {
            var user = await _authUserService.AuthUsers(login.Username, login.Password);
            if (user != null)
            {
                var token = _authUserService.GenerateToken(login.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized("Credenciais inválidas");
        }
    }
}
