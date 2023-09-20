using BandBlender.Data;
using BandBlender.Models.DTOs.Band;
using BandBlender.Models;
using Microsoft.EntityFrameworkCore;


namespace BandBlender.Services
{
    public class BandService : IBandService
    {
        private readonly ApplicationDbContext _context;

        public BandService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BandReadDto>> GetAllBands()
        {
            var bands = await (_context.Bands ?? throw new InvalidOperationException()).AsNoTracking()
                .Include(b => b.MusicianList)
                .Include(b => b.Genre)
                .Select(b => new BandReadDto
                {
                    BandId = b.BandId,
                    BandName = b.BandName,
                    City = b.City,
                    Genre = b.Genre,
                    Biography = b.Biography,
                    Video = b.Video,
                    Demo = b.Demo,
                    MusicianList = b.MusicianList!.ToList()
                })
                .ToListAsync<BandReadDto>();

            return bands;
        }

        public async Task<BandReadDto?> GetBandById(Guid id)
        {
            var band = await (_context.Bands ?? throw new InvalidOperationException()).AsNoTracking()
                .Include(b => b.MusicianList)
                .Include(b => b.Genre)
                .Where(b => b.BandId == id)
                .Select(b => new BandReadDto
                {
                    BandId = b.BandId,
                    BandName = b.BandName,
                    City = b.City,
                    Genre = b.Genre,
                    Biography = b.Biography,
                    Video = b.Video,
                    Demo = b.Demo,
                    MusicianList = b.MusicianList!.ToList()
                })
                .FirstOrDefaultAsync();


            return band;
        }

        public async Task<Guid> CreateBand(BandCreateDto bandCreateDto)
        {
            var band = new Band
            {
                BandName = bandCreateDto.BandName,
                City = bandCreateDto.City,
                Genre = bandCreateDto.GenreId,
                Biography = bandCreateDto.Biography,
                Video = bandCreateDto.Video,
                Demo = bandCreateDto.Demo
            };

            if (_context.Bands != null) await _context.Bands.AddAsync(band);
            await _context.SaveChangesAsync();

            return band.BandId;
        }

        public async Task UpdateBand(Guid id, BandUpdateDto bandUpdateDto)
        {
            if (_context.Bands != null)
            {
                var band = await _context.Bands.FindAsync(id);
                if(band != null)
                {
                    band.BandName = bandUpdateDto.BandName;
                    band.City = bandUpdateDto.City;
                    band.Genre = bandUpdateDto.Genre;
                    band.Biography = bandUpdateDto.Biography;
                    band.Video = bandUpdateDto.Video;
                    band.Demo = bandUpdateDto.Demo;

                    _context.Bands.Update(band);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteBand(Guid id)
        {
            if (_context.Bands != null)
            {
                var band = await _context.Bands.FindAsync(id);
                if(band != null)
                {
                    _context.Bands.Remove(band);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
