namespace BandBlender.Models.DTOs.Instrument
{
    public class InstrumentReadDto
    {
        public Guid InstrumentId { get; set; }
        public string? InstrumentName { get; set; }
        public string? Category { get; set; }
    }
}