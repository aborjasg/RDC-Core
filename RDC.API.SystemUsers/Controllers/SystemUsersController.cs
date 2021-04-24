using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RDC.API;
using RDC.API.SystemUsers;

namespace RDC.API.SystemUsers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemUsersController : ControllerBase
    {
        private readonly Data.RDCContext _context;
        private readonly ILogger _logger;

        public SystemUsersController(ILogger<SystemUsersController> logger, Data.RDCContext context)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/SystemUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.SystemUser>>> GetSystemUser()
        {
            _logger.LogInformation($"#rows: {_context.SystemUsers.Count()}");
            return Ok(await _context.SystemUsers.ToListAsync());
        }

        // GET: api/SystemUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.SystemUser>> GetSystemUser(short id)
        {
            var systemUser = await _context.SystemUsers.FindAsync(id);

            if (systemUser == null)
            {
                return NotFound();
            }

            return Ok(systemUser);
        }

        // PUT: api/SystemUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSystemUser(short id, Models.SystemUser systemUser)
        {
            if (id != systemUser.sSystemUserId)
            {
                return BadRequest();
            }

            _context.Entry(systemUser).State = EntityState.Modified;

            try
            {
                Ok(await _context.SaveChangesAsync());
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SystemUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Models.SystemUser>> PostSystemUser(Models.SystemUser systemUser)
        {
            _context.SystemUsers.Add(systemUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSystemUser", new { id = systemUser.sSystemUserId}, systemUser);
        }

        // DELETE: api/SystemUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSystemUser(short id)
        {
            var systemUser = await _context.SystemUsers.FindAsync(id);
            if (systemUser == null)
            {
                return NotFound();
            }

            _context.SystemUsers.Remove(systemUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SystemUserExists(short id)
        {
            return _context.SystemUsers.Any(e => e.sSystemUserId == id);
        }
    }
}
