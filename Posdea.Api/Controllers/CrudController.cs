using Microsoft.AspNetCore.Mvc;
using Posdea.Application.Common.Interfaces;

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

        // GET api/<CrudController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await crudService.GetById(id));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        // POST api/<CrudController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<CrudController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CrudController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}