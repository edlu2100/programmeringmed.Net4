using Microsoft.EntityFrameworkCore;
using programmeringmed.Net4.Models;

namespace programmeringmed.Net4.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    public DbSet<SongModel> Songs { get; set; }
    public DbSet<ArtistModel> Artists { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }

}
