using CarCatalogWebService.Enums;
using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogWebService.Configurations;

public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.HasKey(t => t.Id);
        
        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasData(
            new Transmission { Id = TransmissionEnum.Automatic.Value, Name = TransmissionEnum.Automatic.Name },
            new Transmission { Id = TransmissionEnum.Manual.Value, Name = TransmissionEnum.Manual.Name });
    }
}