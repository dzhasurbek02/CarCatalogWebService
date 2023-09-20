using CarCatalogWebService.Enums;
using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogWebService.Configurations;

public class FuelTypeConfiguration : IEntityTypeConfiguration<FuelType>
{
    public void Configure(EntityTypeBuilder<FuelType> builder)
    {
        builder.HasKey(ft => ft.Id);
        
        builder.Property(ft => ft.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasData(
            new FuelType { Id = FuelTypeEnum.Petrol.Value, Name = FuelTypeEnum.Petrol.Name },
            new FuelType { Id = FuelTypeEnum.Diesel.Value, Name = FuelTypeEnum.Diesel.Name });
    }
}