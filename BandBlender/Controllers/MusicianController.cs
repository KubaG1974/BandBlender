using BandBlender.Models.DTOs.Musician;
using BandBlender.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandBlender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly MusicianService _musicianService;

        public MusicianController(MusicianService musicianService)
        {
            _musicianService = musicianService;
        }

        // GET: api/Musician
        [HttpGet]
        public IActionResult GetMusicians()
        {
            // Implementation here...
            return Ok();
        }

        // GET: api/Musician/5
        [HttpGet("{id}", Name = "GetMusician")]
        public IActionResult GetMusician(Guid id)
        {
            // Implementation here...
            return Ok();
        }

        // POST: api/Musician
        [HttpPost]
        public IActionResult CreateMusician(MusicianCreateDto musicianCreateDto)
        {
            // Implementation here...
            return Ok();
        }

        // PUT: api/Musician/5
        [HttpPut("{id}")]
        public IActionResult UpdateMusician(Guid id, MusicianUpdateDto musicianUpdateDto)
        {
            // Implementation here...
            return Ok();
        }

        // DELETE: api/Musician/5
        [HttpDelete("{id}")]
        public IActionResult DeleteMusician(Guid id)
        {
            // Implementation here...
            return Ok();
        }
    }
}