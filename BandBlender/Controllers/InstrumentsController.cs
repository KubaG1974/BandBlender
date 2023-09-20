using Microsoft.AspNetCore.Mvc;
using BandBlender.Services;
using BandBlender.Models.DTOs.Instrument;

namespace BandBlender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentsController : ControllerBase
    {
        private readonly IInstrumentService _instrumentService;

        public InstrumentsController(IInstrumentService instrumentService)
        {
            _instrumentService = instrumentService;
        }

        // GET: api/Instruments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InstrumentReadDto>>> GetInstruments()
        {
            var instruments = await _instrumentService.GetAllInstruments();
            return Ok(instruments);
        }

        // GET: api/Instruments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InstrumentReadDto>> GetInstrument(Guid id)
        {
            var instrument = await _instrumentService.GetInstrumentById(id);

            if (instrument == null)
            {
                return NotFound();
            }

            return Ok(instrument);
        }

        // POST: api/Instruments
        [HttpPost]
        public async Task<ActionResult<InstrumentReadDto>> PostInstrument(InstrumentCreateDto instrumentCreateDto)
        {
            var id = await _instrumentService.CreateInstrument(instrumentCreateDto);
            var instrumentReadDto = await _instrumentService.GetInstrumentById(id);

            return CreatedAtAction("GetInstrument", new { id = instrumentReadDto!.InstrumentId }, instrumentReadDto);
        }

        // PUT: api/Instruments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstrument(Guid id, InstrumentUpdateDto instrumentUpdateDto)
        {
            try
            {
                await _instrumentService.UpdateInstrument(id, instrumentUpdateDto);
            }
            catch (Exception)
            {
                var instrument = await _instrumentService.GetInstrumentById(id);
                if (instrument == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Instruments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstrument(Guid id)
        {
            var instrument = await _instrumentService.GetInstrumentById(id);
            if (instrument == null)
            {
                return NotFound();
            }

            await _instrumentService.DeleteInstrument(id);
            return NoContent();
        }
    }
}
