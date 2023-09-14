using System.ComponentModel.DataAnnotations;
namespace BandBlender.Models;

public class Genre
{
    [Key]
    public int GenreId { get; set; }
    public string? Name { get; set; }
}