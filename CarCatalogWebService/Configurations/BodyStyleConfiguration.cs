using CarCatalogWebService.Enums;
using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogWebService.Configurations;

public class BodyStyleConfiguration : IEntityTypeConfiguration<BodyStyle>
{
    public void Configure(EntityTypeBuilder<BodyStyle> builder)
    {
        builder.HasKey(bs => bs.Id);
        
        builder.Property(bs => bs.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasData(
            new BodyStyle { Id = BodyStyleEnum.Sedan.Value, Name = BodyStyleEnum.Sedan.Name},
            new BodyStyle { Id = BodyStyleEnum.Hatchback.Value, Name = BodyStyleEnum.Hatchback.Name},
            new BodyStyle {Id = BodyStyleEnum.Coupe.Value, Name = BodyStyleEnum.Coupe.Name});
    }
}