using portifolio.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace portifolio.Infrastructure.Persistence;

public class PotifolioDbContext(DbContextOptions<PotifolioDbContext> options) : DbContext(options)
{
    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();
    public DbSet<Experience> Experiences => Set<Experience>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Skill> Skills => Set<Skill>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PotifolioDbContext).Assembly);
    }
}