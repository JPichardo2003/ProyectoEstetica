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

            var adminEncontrado = await _context.Admins.FirstOrDefaultAsync(e => e.Email == login.Correo);

            if (login.Correo =="a" && login.Clave =="a")
            {
                sesionAMS.Nombre = "axdad";
                sesionAMS.Correo = login.Correo;
                sesionAMS.Rol = "Administrador";
                return StatusCode(StatusCodes.Status200OK, sesionAMS);
            }

            var empleadoEncontrado = await _context.Empleados.FirstOrDefaultAsync(e => e.Email == login.Correo);

            if (empleadoEncontrado != null && empleadoEncontrado.Clave == login.Clave)
            {
                sesionAMS.Nombre = empleadoEncontrado.Nombre;
                sesionAMS.Correo = login.Correo;
                sesionAMS.Rol = "Empleado";
                return StatusCode(StatusCodes.Status200OK, sesionAMS);
            }

            var clienteEncontrado = await _context.Clientes.FirstOrDefaultAsync(e => e.Email == login.Correo);

            if (login.Correo == "e" && login.Clave == "e")
            {
                sesionAMS.Nombre = "cliente";
                sesionAMS.Correo = login.Correo;
                sesionAMS.Rol = "Cliente";
                return StatusCode(StatusCodes.Status200OK, sesionAMS);
            }
            return StatusCode(StatusCodes.Status401Unauthorized, "Usuario o contraseña incorrecta");


        }
    }
}
