using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace programmeringmed.Net4.Models;

public class ArtistModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Artistens namn är obligatorisk.")]
    public string? ArtistName { get; set; }
    [NotMapped]
    public List<SongModel>? Songs { get; set; }

}