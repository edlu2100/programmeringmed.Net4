using System.ComponentModel.DataAnnotations;

namespace programmeringmed.Net4.Models;

public class Artist{
    public int Id { get; set; }  
    [Required (ErrorMessage = "Artistens namn är obligatorisk.")]  
    public string? ArtistName { get; set; }

    public List<Song>? Songs { get; set; }

}