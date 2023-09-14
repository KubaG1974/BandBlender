using BandBlender.Models.DTOs.Musician;

namespace BandBlender.Services;

public class MusicianService : IMusicianService
{
    public Task<IEnumerable<MusicianReadDto>> GetAllMusicians()
    {
        throw new NotImplementedException();
    }

    public Task<MusicianReadDto> GetMusicianById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Guid> CreateMusician(MusicianCreateDto musicianCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMusician(Guid id, MusicianUpdateDto musicianUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMusician(Guid id)
    {
        throw new NotImplementedException();
    }
}