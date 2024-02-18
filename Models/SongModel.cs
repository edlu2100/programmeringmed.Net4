using System.ComponentModel.DataAnnotations;

namespace programmeringmed.Net4.Models;

public class SongModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Låttitel är obligatorisk.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "ArtistId är obligatorisk.")]
    public int? ArtistId { get; set; }
    public ArtistModel? Artist { get; set; }

    [Required(ErrorMessage = "CategoryId är obligatorisk.")]
    public int? CategoryId { get; set; }
    public CategoryModel? Category { get; set; }

    [Required(ErrorMessage = "Längd är obligatorisk.")]
    public int? Length { get; set; }

}