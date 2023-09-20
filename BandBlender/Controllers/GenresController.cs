using Microsoft.AspNetCore.Mvc;
using BandBlender.Services;
using BandBlender.Models.DTOs.Genre;

namespace BandBlender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: api/Genre
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenreReadDto>>> GetAllGenres()
        {
            var genres = await _genreService.GetAllGenresAsync();
            return Ok(genres);
        }

        // GET: api/Genre/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GenreReadDto>> GetGenreById(Guid id)
        {
            var genre = await _genreService.GetGenreByIdAsync(id);

            return Ok(genre);
        }

        // POST: api/Genre
        [HttpPost]
        public async Task<ActionResult<GenreReadDto>> CreateGenre([FromBody] GenreCreateDto genreCreateDto)
        {
            var id = await _genreService.CreateGenreAsync(genreCreateDto);
            var newGenre = await _genreService.GetGenreByIdAsync(id);
            return CreatedAtAction(nameof(GetGenreById), new { id }, newGenre);
        }

        // PUT: api/Genre/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGenre(Guid id, [FromBody] GenreUpdateDto genreUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var genre = await _genreService.GetGenreByIdAsync(id);

            await _genreService.UpdateGenreAsync(id, genreUpdateDto);
            return NoContent();
        }

        // DELETE: api/Genre/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenre(Guid id)
        {
            var genre = await _genreService.GetGenreByIdAsync(id);

            await _genreService.DeleteGenreAsync(id);
            return NoContent();
        }
    }
}
