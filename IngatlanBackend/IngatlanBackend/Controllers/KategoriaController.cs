using IngatlanBackend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IngatlanBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriaController : ControllerBase
    {
        IngatlanContext _context;
        public KategoriaController(IngatlanContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Kategorium>> Get(int id)
        {
            return Ok(await _context.Kategoria.FindAsync(id));
        }

        
    }
}
