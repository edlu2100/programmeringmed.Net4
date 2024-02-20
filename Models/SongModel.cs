using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace programmeringmed.Net4.Models;

public class SongModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Låttitel är obligatorisk.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "ArtistId är obligatorisk.")]
    public int? ArtistId { get; set; }
    [NotMapped]
    public ArtistModel? Artists { get; set; }

    [Required(ErrorMessage = "CategoryId är obligatorisk.")]
    public int? CategoryId { get; set; }
    [NotMapped]
    public CategoryModel? Categories { get; set; }

    [Required(ErrorMessage = "Längd är obligatorisk.")]
    public int? Length { get; set; }

}