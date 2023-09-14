using BandBlender.Models.DTOs.Musician;

namespace BandBlender.Services
{
    public interface IMusicianService
    {
        Task<IEnumerable<MusicianReadDto>> GetAllMusicians();
        Task<MusicianReadDto> GetMusicianById(Guid id);
        Task<Guid> CreateMusician(MusicianCreateDto musicianCreateDto);
        Task UpdateMusician(Guid id, MusicianUpdateDto musicianUpdateDto);
        Task DeleteMusician(Guid id);
    }
}