using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogWebService.Configurations;

public class DriveTrainConfiguration : IEntityTypeConfiguration<DriveTrain>
{
    public void Configure(EntityTypeBuilder<DriveTrain> builder)
    {
        builder.HasKey(dt => dt.Id);
        
        builder.Property(dt => dt.Name)
            .IsRequired()
            .HasMaxLength(30);
    }
}