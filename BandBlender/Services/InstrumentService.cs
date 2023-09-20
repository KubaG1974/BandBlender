using BandBlender.Data;
using BandBlender.Models;
using BandBlender.Models.DTOs.Instrument;
using Microsoft.EntityFrameworkCore;


namespace BandBlender.Services
{
    public class InstrumentService : IInstrumentService
    {
        private readonly ApplicationDbContext _context;

        public InstrumentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InstrumentReadDto>> GetAllInstruments()
        {
            var instruments = await _context.Instruments!.AsNoTracking()
                .Select(i => new InstrumentReadDto
                {
                    InstrumentId = i.InstrumentId,
                    InstrumentName = i.InstrumentName,
                    Category = i.Category
                })
                .ToListAsync();

            return instruments;
        }

        public async Task<InstrumentReadDto?> GetInstrumentById(Guid id)
        {
            var instrument = await _context.Instruments!.AsNoTracking()
                .Where(i => i.InstrumentId == id)
                .Select(i => new InstrumentReadDto
                {
                    InstrumentId = i.InstrumentId,
                    InstrumentName = i.InstrumentName,
                    Category = i.Category
                })
                .FirstOrDefaultAsync();

            return instrument!;
        }

        public async Task<Guid> CreateInstrument(InstrumentCreateDto instrumentCreateDto)
        {
            var instrument = new Instrument
            {
                InstrumentName = instrumentCreateDto.InstrumentName,
                Category = instrumentCreateDto.Category
            };

            await _context.Instruments!.AddAsync(instrument);
            await _context.SaveChangesAsync();

            return instrument.InstrumentId;
        }

        public async Task UpdateInstrument(Guid id, InstrumentUpdateDto instrumentUpdateDto)
        {
            var instrument = await _context.Instruments!.FindAsync(id);
            if (instrument != null)
            {
                instrument.InstrumentName = instrumentUpdateDto.InstrumentName;
                instrument.Category = instrumentUpdateDto.Category;

                _context.Instruments.Update(instrument);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteInstrument(Guid id)
        {
            var instrument = await _context.Instruments!.FindAsync(id);
            if (instrument != null)
            {
                _context.Instruments.Remove(instrument);
                await _context.SaveChangesAsync();
            }
        }
    }
}
