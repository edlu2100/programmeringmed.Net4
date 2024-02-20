using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace programmeringmed.Net4.Models;

public class CategoryModel
{
    public int Id { get; set; }
    [Required (ErrorMessage = "Kategorinamn är obligatorisk.")]
    public string? CategoryName { get; set; }
    [NotMapped]
    public List<SongModel>? Songs { get; set; }

}