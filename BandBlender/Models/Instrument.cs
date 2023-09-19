using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BandBlender.Models;

public class Instrument
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid InstrumentId { get; set; }

    [Required]
    [StringLength(100)]
    public string? InstrumentName { get; set; }

    [StringLength(100)]
    public string? Category { get; set; } 
}