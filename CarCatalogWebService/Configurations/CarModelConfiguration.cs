using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogWebService.Configurations;

public class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
{
    public void Configure(EntityTypeBuilder<CarModel> builder)
    {
        builder.HasKey(m => m.Id);
        
        builder.Property(m => m.BrandId)
            .IsRequired();
        
        builder.Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(30);
    }
}