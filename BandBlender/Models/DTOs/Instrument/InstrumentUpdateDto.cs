using System.ComponentModel.DataAnnotations;

namespace BandBlender.Models.DTOs.Instrument
{
    public class InstrumentUpdateDto
    {
        [Required]
        [StringLength(100)]
        public string? InstrumentName { get; set; }

        [StringLength(100)]
        public string? Category { get; set; }
    }
}