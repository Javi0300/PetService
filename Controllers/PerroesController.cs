#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetService.Models;

namespace PetService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerroesController : ControllerBase
    {
        private readonly PetServiceContext _context;

        public PerroesController(PetServiceContext context)
        {
            _context = context;
        }

        // GET: api/Perroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perro>>> GetPerros()
        {
            return await _context.Perros.ToListAsync();
        }

        // GET: api/Perroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Perro>> GetPerro(int id)
        {
            var perro = await _context.Perros.FindAsync(id);

            if (perro == null)
            {
                return NotFound();
            }

            return perro;
        }

        // PUT: api/Perroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerro(int id, Perro perro)
        {
            if (id != perro.IdPerro)
            {
                return BadRequest();
            }

            _context.Entry(perro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerroExists(id))
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

        // POST: api/Perroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Perro>> PostPerro(Perro perro)
        {
            _context.Perros.Add(perro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerro", new { id = perro.IdPerro }, perro);
        }

        // DELETE: api/Perroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerro(int id)
        {
            var perro = await _context.Perros.FindAsync(id);
            if (perro == null)
            {
                return NotFound();
            }

            _context.Perros.Remove(perro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PerroExists(int id)
        {
            return _context.Perros.Any(e => e.IdPerro == id);
        }
    }
}
