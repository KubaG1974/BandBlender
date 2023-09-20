using System.ComponentModel.DataAnnotations;
namespace BandBlender.Models;

public class Genre
{
    [Key]
    public Guid GenreId { get; set; }
    public string? Name { get; set; }
}