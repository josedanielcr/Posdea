using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Services.Entities;

namespace Posdea.Api.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("active"), Authorize]
        public async Task<IActionResult> GetCurrentUser()
        {
            return Ok(await userService.GetCurrentUser());
        }
    }
}
