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
    public class CitasController : ControllerBase
    {
        private readonly Contexto _context;

        public CitasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Citas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citas>>> GetCitas()
        {
          if (_context.Citas == null)
          {
              return NotFound();
          }
            return await _context.Citas.ToListAsync();
        }

        // GET: api/Citas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Citas>> GetCitas(int id)
        {
          if (_context.Citas == null)
          {
              return NotFound();
          }
            var citas = await _context.Citas.Include(c => c.CitasDetalles).Where(c => c.CitaId == id)
                .FirstOrDefaultAsync();

            if (citas == null)
            {
                return NotFound();
            }

            return citas;
        }

        // PUT: api/Citas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCitas(int id, Citas citas)
        {
            if (id != citas.CitaId)
            {
                return BadRequest();
            }

            _context.Entry(citas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitasExists(id))
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

        // POST: api/Citas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Citas>> PostCitas(Citas citas)
        {
          if (!CitasExists(citas.CitaId))
                _context.Citas.Add(citas);
          else
                _context.Citas.Update(citas);
          await _context.SaveChangesAsync();
            return Ok(citas);
        }

        // DELETE: api/Citas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitas(int id)
        {
            if (_context.Citas == null)
            {
                return NotFound();
            }
            var citas = await _context.Citas.FindAsync(id);
            if (citas == null)
            {
                return NotFound();
            }

            _context.Citas.Remove(citas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("DeleteDetalles/{id}")]
        public async Task<IActionResult> DeleteDetalles(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var entradas = await _context.CitasDetalles.FirstOrDefaultAsync(td => td.DetalleId == id);
            if (entradas is null)
            {
                return NotFound();
            }
            _context.CitasDetalles.Remove(entradas);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool CitasExists(int id)
        {
            return (_context.Citas?.Any(e => e.CitaId == id)).GetValueOrDefault();
        }
    }
}
