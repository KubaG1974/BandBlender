using BandBlender.Models.DTOs.Band;

namespace BandBlender.Services
{
    public interface IBandService
    {
        Task<IEnumerable<BandReadDto>> GetAllBands();
        Task<BandReadDto?> GetBandById(Guid id);
        Task<Guid> CreateBand(BandCreateDto bandCreateDto);
        Task UpdateBand(Guid id, BandUpdateDto bandUpdateDto);
        Task DeleteBand(Guid id);
    }
}