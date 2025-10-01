using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.DAL.DBContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaVenta.API.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    public class ListaProductos : ControllerBase
    {
        private readonly DbventaContext _dbventaContext;
        public ListaProductos(DbventaContext dbventaContext)
        {
            _dbventaContext = dbventaContext;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var lista = await _dbventaContext.Productos.ToListAsync();
            return StatusCode(StatusCodes.Status200OK, new { value = lista });
        }
    }
}
