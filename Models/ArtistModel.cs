using System.ComponentModel.DataAnnotations;

namespace programmeringmed.Net4.Models;

public class ArtistModel{
    public int Id { get; set; }  
    [Required (ErrorMessage = "Artistens namn är obligatorisk.")]  
    public string? ArtistName { get; set; }

    public List<SongModel>? Songs { get; set; }

}