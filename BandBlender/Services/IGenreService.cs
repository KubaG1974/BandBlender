using BandBlender.Models.DTOs.Genre;


namespace BandBlender.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreReadDto>> GetAllGenresAsync();
        Task<GenreReadDto> GetGenreByIdAsync(Guid id);
        Task<Guid> CreateGenreAsync(GenreCreateDto genreCreateDto);
        Task UpdateGenreAsync(Guid id, GenreUpdateDto genreUpdateDto);
        Task DeleteGenreAsync(Guid id);
    }
}