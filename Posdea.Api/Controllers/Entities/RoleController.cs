using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Models.UserSegment;

namespace Posdea.Api.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : CrudController<RoleModel>
    {
        public RoleController(ICrudService<RoleModel> crudService): base(crudService){}
    }
}
