using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace IngatlanBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngatlanController : ControllerBase
    {
        IngatlanContext _context;
        public IngatlanController(IngatlanContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Ingatlanok>>> Get()
        {
            
                var ingatlanok = await _context.Ingatlanoks.Include(x => x.KategoriaNavigation).ToListAsync();
            if (ingatlanok.IsNullOrEmpty())
                return BadRequest("Nincs ingatlan.");
            
            return Ok(ingatlanok);
            
        }

        [HttpPost]
        public async Task<ActionResult<Ingatlanok>> Post(Ingatlanok ingatlan)
        {
            _context.Ingatlanoks.Add(ingatlan);
            await _context.SaveChangesAsync();
            return Ok( await _context.Ingatlanoks.Include(i => i.KategoriaNavigation).ToListAsync());

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ingatlan = await _context.Ingatlanoks.FindAsync(id);
            if (ingatlan == null)
                return BadRequest("Az ingatlan nem létzik");

            _context.Ingatlanoks.Remove(ingatlan);
            await _context.SaveChangesAsync();
            return Ok("Sikeres.");
        }

    }
}
