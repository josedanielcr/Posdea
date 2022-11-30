using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Posdea.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CrudController<T> : ControllerBase where T : class
    {
        private readonly ICrudService<T> crudService;
        public CrudController(ICrudService<T> crudService)
        {
            this.crudService = crudService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<T> Results = await crudService.GetAll();
            return Ok(Results);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await crudService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] T model)
        {
            return Ok(await crudService.Insert(model));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] T model)
        {
            return Ok(await crudService.Update(id,model));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await crudService.DeleteById(id));
        }
    }
}