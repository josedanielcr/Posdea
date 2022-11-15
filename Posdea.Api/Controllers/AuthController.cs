using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Models.UserSegment;

namespace Posdea.Api.Controllers
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
            try
            {
                return Ok(await authService.SignUp(user));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
