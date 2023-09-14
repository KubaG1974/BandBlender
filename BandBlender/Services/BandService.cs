using BandBlender.Data;
using BandBlender.Models;
using Microsoft.EntityFrameworkCore;

namespace BandBlender.Services
{
    public class BandService
    {
        private readonly ApplicationDbContext _context;

        public BandService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Band>> GetBandsAsync()
        {
            return await (_context.Bands ?? throw new InvalidOperationException()).Include(b => b.Genre).ToListAsync();
        }

        public async Task<Band?> GetBandByIdAsync(Guid id)
        {
            return await (_context.Bands ?? throw new InvalidOperationException()).Include(b => b.Genre).FirstOrDefaultAsync(b => b.BandId == id);
        }

        public async Task CreateBandAsync(Band band)
        {
            if(band == null)
            {
                throw new ArgumentNullException(nameof(band));
            }

            if (_context.Bands != null) await _context.Bands.AddAsync(band);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBandAsync(Band band)
        {
            _context.Bands?.Update(band);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBandAsync(Guid id)
        {
            if (_context.Bands != null)
            {
                var band = await _context.Bands.FindAsync(id);
                if (band != null)
                {
                    _context.Bands.Remove(band);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}