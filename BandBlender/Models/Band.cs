namespace BandBlender.Models
{
    public class Band
    {
        public Guid BandId { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public Genre? Genre { get; set; }
        public List<Musician>? Musicians { get; set; } = new List<Musician>();
        public string? Biography { get; set; }
        public string? VideoUrl { get; set; }
        public string? DemoUrl { get; set; }
    }
    
}