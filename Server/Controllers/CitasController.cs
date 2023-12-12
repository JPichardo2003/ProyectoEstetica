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
            var citas = await _context.Citas.Include(c => c.CitasDetalles).Where(c => c.CitaId == id).FirstOrDefaultAsync();

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
        // DELETE: api/Citas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitas(int id)
        {
            if (_context.Citas == null)
            {
                return NotFound();
            }

            // Buscar la cita por su ID
            var cita = await _context.Citas.FindAsync(id);
            if (cita == null)
            {
                return NotFound();
            }

            // Eliminar la cita del cliente
            var clienteId = cita.ClienteId;
            var cliente = await _context.Clientes.FindAsync(clienteId);
            if (cliente != null)
            {
                cliente.Citas.Remove(cita);
            }

            // Eliminar la cita del colaborador
            var colaboradorId = cita.ColaboradorId;
            var colaborador = await _context.Colaboradores.FindAsync(colaboradorId);
            if (colaborador != null)
            {
                colaborador.Citas.Remove(cita);
            }

            // Eliminar la cita
            _context.Citas.Remove(cita);

            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool CitasExists(int id)
        {
            return (_context.Citas?.Any(e => e.CitaId == id)).GetValueOrDefault();
        }
    }
}
