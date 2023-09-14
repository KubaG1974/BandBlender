using System.ComponentModel.DataAnnotations;

namespace BandBlender.Models.DTOs.Band
{
    public class BandUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string? BandName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? City { get; set; }

        [Required]
        public Guid GenreId { get; set; }

        public List<Guid>? MusicianIds { get; set; }

        [MaxLength(1000)]
        public string? Biography { get; set; }

        [MaxLength(200)]
        public string? VideoUrl { get; set; }

        [MaxLength(200)]
        public string? DemoUrl { get; set; }
    }
}