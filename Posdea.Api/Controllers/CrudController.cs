using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces.Services;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Posdea.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            try
            {
                IEnumerable<T> Results = await crudService.GetAll();
                return Ok(Results);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await crudService.GetById(id));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] T model)
        {
            try
            {
                return Ok(await crudService.Insert(model));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] T model)
        {
            try
            {
                return Ok(await crudService.Update(id,model));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return Ok(await crudService.DeleteById(id));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}