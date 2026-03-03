using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using portfolio.Domain.Entities;

namespace portfolio.Infrastructure.Persistence.Configurations;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(x => x.Headline)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.About)
            .HasMaxLength(2000);

        builder.Property(x => x.GithubUrl)
            .HasMaxLength(300);

        builder.Property(x => x.LinkedinUrl)
            .HasMaxLength(300);
    }
}