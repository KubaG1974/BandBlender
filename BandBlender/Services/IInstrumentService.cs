using BandBlender.Models.DTOs.Instrument;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BandBlender.Services
{
    public interface IInstrumentService
    {
        Task<IEnumerable<InstrumentReadDto>> GetAllInstruments();
        Task<InstrumentReadDto?> GetInstrumentById(Guid id);
        Task<Guid> CreateInstrument(InstrumentCreateDto instrumentCreateDto);
        Task UpdateInstrument(Guid id, InstrumentUpdateDto instrumentUpdateDto);
        Task DeleteInstrument(Guid id);
    }
}