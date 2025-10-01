
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using SistemaVenta.Model;
using SistemaVenta.DTO;
using SistemaVenta.API.Utilidad;
using SistemaVenta.DAL.DBContext;

namespace SistemaVenta.API.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AccesoController : ControllerBase
    {
        private readonly DbventaContext _dbventaContext;
        private readonly Utilidades _utilidades;

        public AccesoController(DbventaContext dbPruebaContext, Utilidades utilidades)
        {
            _dbventaContext = dbPruebaContext;
            _utilidades = utilidades;
        }

        [HttpPost]
        [Route("Registrarse")]
        public async Task<IActionResult> Registrarse(UsuarioDTO objeto)
        {

            var modeloUsuario = new Usuario
            {
                NombreCompleto = objeto.NombreCompleto,
                Correo = objeto.Correo,
                IdRol = objeto.IdRol,
                Clave = _utilidades.encriptarSHA256(objeto.Clave)
            };

            await _dbventaContext.Usuarios.AddAsync(modeloUsuario);
            await _dbventaContext.SaveChangesAsync();

            if (modeloUsuario.IdUsuario != 0)
                return StatusCode(StatusCodes.Status200OK, new { isSuccess = true });
            else
                return StatusCode(StatusCodes.Status200OK, new { isSuccess = false });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginDTO objeto)
        {
            var usuarioEncontrado = await _dbventaContext.Usuarios
                                                    .Where(u =>
                                                        u.Correo == objeto.Correo &&
                                                        u.Clave == _utilidades.encriptarSHA256(objeto.Clave)
                                                      ).FirstOrDefaultAsync();

            if (usuarioEncontrado == null)
                return StatusCode(StatusCodes.Status200OK, new { isSuccess = false, token = "" });
            else
                return StatusCode(StatusCodes.Status200OK, new { isSuccess = true, token = _utilidades.generarJWT(usuarioEncontrado) });
        }
    }

   
}
