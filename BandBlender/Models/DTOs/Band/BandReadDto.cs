namespace BandBlender.Models.DTOs.Band
{
    public class BandReadDto
    {
        public Guid BandId { get; set; }
        public string? BandName { get; set; }
        public string? City { get; set; }
        public Guid Genre { get; set; } 
        public string? Biography { get; set; }
        public string? Video { get; set; }
        public string? Demo { get; set; }
        public List<string>? MusicianList { get; set; }
    }

}