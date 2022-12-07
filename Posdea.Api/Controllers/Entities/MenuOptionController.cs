using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Models.Entities;
using Posdea.Application.Models.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Api.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuOptionController : ControllerBase
    {
        private readonly IMenuOptionService menuOptionService;

        public MenuOptionController(IMenuOptionService menuOptionService)
        {
            this.menuOptionService = menuOptionService;
        }

        [HttpGet("role/{roleId}"), Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetAllByRole(int roleId)
        {
            return Ok(await menuOptionService.GetAll(roleId));
        }
    }
}
