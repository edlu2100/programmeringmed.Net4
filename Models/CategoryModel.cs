using System.ComponentModel.DataAnnotations;

namespace programmeringmed.Net4.Models;

public class CategoryModel
{
    public int Id { get; set; }
    [Required (ErrorMessage = "Kategorinamn är obligatorisk.")]
    public string? CategoryName { get; set; }
    public List<SongModel>? Songs { get; set; }

}