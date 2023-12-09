using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AguaMariaSolution.Server.DAL;
using AguaMariaSolution.Shared.Models;

namespace AguaMariaSolution.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposDeTrabajosController : ControllerBase
    {
        private readonly Contexto _context;

        public TiposDeTrabajosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/TiposDeTrabajos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposDeTrabajos>>> GetTiposDeTrabajos()
        {
          if (_context.TiposDeTrabajos == null)
          {
              return NotFound();
          }
            return await _context.TiposDeTrabajos.ToListAsync();
        }

        // GET: api/TiposDeTrabajos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiposDeTrabajos>> GetTiposDeTrabajos(int id)
        {
          if (_context.TiposDeTrabajos == null)
          {
              return NotFound();
          }
            var tiposDeTrabajos = await _context.TiposDeTrabajos.FindAsync(id);

            if (tiposDeTrabajos == null)
            {
                return NotFound();
            }

            return tiposDeTrabajos;
        }

        // PUT: api/TiposDeTrabajos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposDeTrabajos(int id, TiposDeTrabajos tiposDeTrabajos)
        {
            if (id != tiposDeTrabajos.TipoDeTrabajoId)
            {
                return BadRequest();
            }

            _context.Entry(tiposDeTrabajos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposDeTrabajosExists(id))
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

        // POST: api/TiposDeTrabajos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TiposDeTrabajos>> PostTiposDeTrabajos(TiposDeTrabajos tiposDeTrabajos)
        {
            if (!TiposDeTrabajosExists(tiposDeTrabajos.TipoDeTrabajoId))
                _context.TiposDeTrabajos.Add(tiposDeTrabajos);
            else
                _context.TiposDeTrabajos.Update(tiposDeTrabajos);
            await _context.SaveChangesAsync();
            return Ok(tiposDeTrabajos);
        }

        // DELETE: api/TiposDeTrabajos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiposDeTrabajos(int id)
        {
            if (_context.TiposDeTrabajos == null)
            {
                return NotFound();
            }
            var tiposDeTrabajos = await _context.TiposDeTrabajos.FindAsync(id);
            if (tiposDeTrabajos == null)
            {
                return NotFound();
            }

            _context.TiposDeTrabajos.Remove(tiposDeTrabajos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiposDeTrabajosExists(int id)
        {
            return (_context.TiposDeTrabajos?.Any(e => e.TipoDeTrabajoId == id)).GetValueOrDefault();
        }
    }
}
