using System.ComponentModel.DataAnnotations;

namespace BandBlender.Models.DTOs.Musician
{
    public class MusicianCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        public Guid InstrumentId { get; set; }

        public List<Guid>? BandIds { get; set; }

        [Required]
        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(500)]
        public string? Biography { get; set; }

        [MaxLength(500)]
        public string? Demo { get; set; }

        [Required]
        public Guid GenreId { get; set; }
    }
}