using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services;
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
