using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posdea.Api.Controllers.Util;
using Posdea.Application.Common.Interfaces.Services.Util;
using Posdea.Application.Models.UserSegment;

namespace Posdea.Api.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ParameterController<RoleModel>
    {
        public RoleController(IParameterService<RoleModel> crudService): base(crudService){}
    }
}
