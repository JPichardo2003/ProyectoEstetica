using AguaMariaSolution.Server.DAL;
using AguaMariaSolution.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace AguaMariaSolution.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Contexto _context;

        public UsuarioController(Contexto context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginAMS login)
        {
            SesionAMS sesionAMS = new SesionAMS();

            if (login.Correo == "julio@admin.com" && login.Clave == "admin" || login.Correo == "abraham@admin.com" && login.Clave == "admin" || login.Correo == "luis@admin.com" && login.Clave == "admin")
            {
                sesionAMS.Nombre = "admin";
                sesionAMS.Correo = login.Correo;
                sesionAMS.Rol = "Administrador";
                return StatusCode(StatusCodes.Status200OK, sesionAMS);
            }

            var colaboradorEncontrado = await _context.Colaboradores.FirstOrDefaultAsync(e => e.Email == login.Correo);
            if (colaboradorEncontrado != null && colaboradorEncontrado.Clave == login.Clave)
            {
                sesionAMS.Nombre = colaboradorEncontrado.Nombre;
                sesionAMS.Correo = login.Correo;
                sesionAMS.Rol = "Colaborador";
                return StatusCode(StatusCodes.Status200OK, sesionAMS);
            }
            else if (colaboradorEncontrado == null)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Usuario no encontrado");
            }
            else if (login.Clave != colaboradorEncontrado.Clave)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Contraseña incorrecta");
            }

            var clienteEncontrado = await _context.Clientes.FirstOrDefaultAsync(e => e.Email == login.Correo);

            if (clienteEncontrado != null && clienteEncontrado.Clave==login.Clave)
            {
                sesionAMS.Nombre = clienteEncontrado.Nombre;
                sesionAMS.Correo = login.Correo;
                sesionAMS.Rol = "Cliente";
            }
            else if (clienteEncontrado == null)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Usuario no encontrado");
            }
            else if (login.Clave != clienteEncontrado.Clave)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Contraseña incorrecta");
            }

            return StatusCode(StatusCodes.Status200OK, sesionAMS);
        }
    }
}
