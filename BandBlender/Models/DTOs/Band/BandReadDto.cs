namespace BandBlender.Models.DTOs.Band
{
    public class BandReadDto
    {
        public Guid BandId { get; set; }
        public string? BandName { get; set; }
        public string? City { get; set; }
        public Guid GenreId { get; set; }
        public List<Guid>? MusicianIds { get; set; }
        public string? Biography { get; set; }
        public string? VideoUrl { get; set; }
        public string? DemoUrl { get; set; }
    }
}