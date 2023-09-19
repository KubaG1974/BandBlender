using System.ComponentModel.DataAnnotations;

namespace BandBlender.Models.DTOs.Instrument
{
    public class InstrumentCreateDto
    {
        [Required]
        [StringLength(100)]
        public string? InstrumentName { get; set; }

        [StringLength(100)]
        public string? Category { get; set; }
        
    }
}