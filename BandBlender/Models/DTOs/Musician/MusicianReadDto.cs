namespace BandBlender.Models.DTOs.Musician
{
    public class MusicianReadDto
    {
        public Guid MusicianId { get; set; }

        public string? Name { get; set; }

        public Guid InstrumentId { get; set; }

        public List<Guid>? BandIds { get; set; }

        public string? City { get; set; }

        public string? Biography { get; set; }

        public string? Demo { get; set; }

        public Guid GenreId { get; set; }
    }
}