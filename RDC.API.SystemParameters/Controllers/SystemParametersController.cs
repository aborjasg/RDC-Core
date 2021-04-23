using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RDC.API.SystemParameters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemParametersController : ControllerBase
    {
        private readonly Data.RDCContext _context;

        public SystemParametersController(Data.RDCContext context)
        {
            this._context = context;
        }
        // GET: api/<SystemParametersController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.SystemParameter>>> Get()
        {
            return await _context.SystemParameters.ToListAsync();
        }

        // GET api/<SystemParametersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.SystemParameter>> Get(int id)
        {
            return await _context.SystemParameters.Where(x => x.SParameterId == id).FirstOrDefaultAsync();
        }

        // POST api/<SystemParametersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SystemParametersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SystemParametersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
