using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AguaMariaSolution.Server.DAL;
using AguaMariaSolution.Shared.Models;
using AguaMariaSolution.Client.Pages.Registros;

namespace AguaMariaSolution.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradoresController : ControllerBase
    {
        private readonly Contexto _context;

        public ColaboradoresController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Colaboradores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Colaboradores>>> GetColaboradores()
        {
            if (_context.Colaboradores == null)
            {
                return NotFound();
            }
            return await _context.Colaboradores.Include(c => c.Citas).ToListAsync();
        }

        // GET: api/Colaboradores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Colaboradores>> GetColaboradores(int id)
        {
            if (_context.Colaboradores == null)
            {
                return NotFound();
            }
            var colaboradores = await _context.Colaboradores.Include(c => c.Citas).Where(e => e.ColaboradorId == id).FirstOrDefaultAsync();
            ;

            if (colaboradores == null)
            {
                return NotFound();
            }

            return colaboradores;
        }

        // PUT: api/Colaboradores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColaboradores(int id, Colaboradores colaboradores)
        {
            if (id != colaboradores.ColaboradorId)
            {
                return BadRequest();
            }

            _context.Entry(colaboradores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColaboradoresExists(id))
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

        // POST: api/Colaboradores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colaboradores>> PostColaboradores(Colaboradores colaboradores)
        {
            if (!ColaboradoresExists(colaboradores.ColaboradorId))
                _context.Colaboradores.Add(colaboradores);
            else
                _context.Colaboradores.Update(colaboradores);
            await _context.SaveChangesAsync();
            return Ok(colaboradores);
        }

        // DELETE: api/Colaboradores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColaboradores(int id)
        {
            if (_context.Colaboradores == null)
            {
                return NotFound();
            }
            var colaboradores = await _context.Colaboradores.FindAsync(id);
            if (colaboradores == null)
            {
                return NotFound();
            }

            _context.Colaboradores.Remove(colaboradores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("DeleteTrabajo/{colaboradorId}/{trabajoId}")]
        public async Task<IActionResult> DeleteTrabajo(int colaboradorId, int trabajoId)
        {
            var colaborador = await _context.Colaboradores
                .Where(c => c.ColaboradorId == colaboradorId)
                .FirstOrDefaultAsync();

            if (colaborador == null)
            {
                return NotFound("Colaborador no encontrado");
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ColaboradoresExists(int id)
        {
            return (_context.Colaboradores?.Any(e => e.ColaboradorId == id)).GetValueOrDefault();
        }
    }
}
