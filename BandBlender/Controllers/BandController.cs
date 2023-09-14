using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BandBlender.Data;
using BandBlender.Models;

namespace BandBlender.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BandController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BandController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/Band
        [HttpPost]
        public async Task<ActionResult<Band>> CreateBand(Band band)
        {
            _context.Bands.Add(band);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBand), new { id = band.BandId }, band);
        }

        // GET: api/Band/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Band>> GetBand(int id)
        {
            var band = await _context.Bands.FindAsync(id);

            if (band == null)
            {
                return NotFound();
            }

            return band;
        }

        // PUT: api/Band/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBand(int id, Band band)
        {
            if (id != band.BandId)
            {
                return BadRequest();
            }

            _context.Entry(band).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                if (!BandExists(id))
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

        // DELETE: api/Band/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBand(int id)
        {
            var band = await _context.Bands.FindAsync(id);
            if (band == null)
            {
                return NotFound();
            }

            _context.Bands.Remove(band);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BandExists(int id)
        {
            return _context.Bands.Any(e => e.BandId == id);
        }
    }
}
