using BandBlender.Data;
using BandBlender.Models;
using BandBlender.Models.DTOs.Genre;
using Microsoft.EntityFrameworkCore;

namespace BandBlender.Services
{
    public class GenreService : IGenreService
    {
        private readonly ApplicationDbContext _context;

        public GenreService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GenreReadDto>> GetAllGenres()
        {
            var genres = await _context.Genres!.AsNoTracking()
                .Select(g => new GenreReadDto
                {
                    GenreId = g.GenreId,
                    Name = g.Name
                })
                .ToListAsync();

            return genres;
        }

        public async Task<GenreReadDto> GetGenreById(Guid id)
        {
            var genre = await _context.Genres!.AsNoTracking()
                .Where(g => g.GenreId == id)
                .Select(g => new GenreReadDto
                {
                    GenreId = g.GenreId,
                    Name = g.Name
                })
                .FirstOrDefaultAsync();

            return genre!;
        }

        public async Task<Guid> CreateGenre(GenreCreateDto genreCreateDto)
        {
            var genre = new Genre
            {
                Name = genreCreateDto.Name
            };

            await _context.Genres!.AddAsync(genre);
            await _context.SaveChangesAsync();

            return genre.GenreId;
        }

        public async Task UpdateGenre(Guid id, GenreUpdateDto genreUpdateDto)
        {
            var genre = await _context.Genres!.FindAsync(id);
            if (genre != null)
            {
                genre.Name = genreUpdateDto.Name;

                _context.Genres.Update(genre);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteGenre(Guid id)
        {
            var genre = await _context.Genres!.FindAsync(id);
            if (genre != null)
            {
                _context.Genres.Remove(genre);
                await _context.SaveChangesAsync();
            }
        }
    }
}
