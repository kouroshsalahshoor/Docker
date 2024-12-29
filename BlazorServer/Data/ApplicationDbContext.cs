using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Podcast> Podcasts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var podcasts = new List<Podcast>();
        for (int i = 1; i <= 100; i++)
        {
            podcasts.Add(new Podcast { Id = i, Title = $"Podcast {i.ToString()}" });
        }

        builder.Entity<Podcast>().HasData(podcasts);
    }
}
