using BlankSolution.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlankSolution.Data.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Genre> builder)
    {
        builder.Property(x=>x.Name)
            .IsRequired()
            .HasMaxLength(45);
    }
}
