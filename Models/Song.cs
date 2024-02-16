using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace programmeringmed.Net4.Models;

public class Song
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Låttitel är obligatorisk.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "ArtistId är obligatorisk.")]
    public int? ArtistId { get; set; }

    [Required(ErrorMessage = "CategoryId är obligatorisk.")]
    public int? CategoryId { get; set; }

    [Required(ErrorMessage = "Längd är obligatorisk.")]
    public int? Length { get; set; }

    [ForeignKey("ArtistId")]
    public Artist? Artist { get; set; }

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }
}