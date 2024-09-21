using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apis_web_services_fuel_manager.Models;

namespace apis_web_services_fuel_manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PostosController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Postos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Posto>>> GetPostos()
        {
            return await _context.Postos.ToListAsync();
        }

        // GET: api/Postos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Posto>> GetPosto(int id)
        {
            var posto = await _context.Postos.FindAsync(id);

            if (posto == null)
            {
                return NotFound();
            }

            return posto;
        }

        // PUT: api/Postos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosto(int id, Posto posto)
        {
            if (id != posto.Id)
            {
                return BadRequest();
            }

            _context.Entry(posto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostoExists(id))
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

        // POST: api/Postos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Posto>> PostPosto(Posto posto)
        {
            _context.Postos.Add(posto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosto", new { id = posto.Id }, posto);
        }

        // DELETE: api/Postos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosto(int id)
        {
            var posto = await _context.Postos.FindAsync(id);
            if (posto == null)
            {
                return NotFound();
            }

            _context.Postos.Remove(posto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostoExists(int id)
        {
            return _context.Postos.Any(e => e.Id == id);
        }
    }
}
