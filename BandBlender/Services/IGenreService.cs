using BandBlender.Models.DTOs.Genre;


namespace BandBlender.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreReadDto>> GetAllGenres();
        Task<GenreReadDto> GetGenreById(Guid id);
        Task<Guid> CreateGenre(GenreCreateDto genreCreateDto);
        Task UpdateGenre(Guid id, GenreUpdateDto genreUpdateDto);
        Task DeleteGenre(Guid id);
    }
}