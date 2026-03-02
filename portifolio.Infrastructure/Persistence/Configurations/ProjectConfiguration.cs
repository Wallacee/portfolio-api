using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using portifolio.Domain.Entities;

namespace portifolio.Infrastructure.Persistence.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(x => x.RepositoryUrl)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(x => x.DemoUrl)
            .HasMaxLength(300);

        builder.Property(x => x.CreatedAt)
            .IsRequired();
    }
}