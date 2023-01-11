using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services.Auth;
using Posdea.Application.Models.Auth;
using Posdea.Application.Models.UserSegment;

namespace Posdea.Api.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("signUp")]
        public async Task<IActionResult> SignUp([FromBody] UserModel user)
        {
            return Ok(await authService.SignUp(user));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserRegisterModel user)
        {
            return Ok(await authService.Login(user));
        }
    }
}