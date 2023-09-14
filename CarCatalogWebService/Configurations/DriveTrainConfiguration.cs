using CarCatalogWebService.Enums;
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

        builder.HasData(
            new DriveTrain { Id = DriveTrainEnum.FWD.Value, Name = DriveTrainEnum.FWD.Name },
            new DriveTrain { Id = DriveTrainEnum.RWD.Value, Name = DriveTrainEnum.RWD.Name },
            new DriveTrain { Id = DriveTrainEnum.AWD.Value, Name = DriveTrainEnum.AWD.Name });
    }
}