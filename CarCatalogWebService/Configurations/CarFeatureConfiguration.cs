using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogWebService.Configurations;

public class CarFeatureConfiguration : IEntityTypeConfiguration<CarFeature>
{
    public void Configure(EntityTypeBuilder<CarFeature> builder)
    {
        builder.HasKey(cf => cf.Id);
        
        builder.Property(cf => cf.CarId)
            .IsRequired();
        
        builder.HasOne(cf => cf.Car)
            .WithMany(c => c.CarFeatures)
            .HasForeignKey(cf => cf.CarId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        builder.HasIndex(cf => new
            {
                cf.CarId, cf.FeatureId
            })
            .IsUnique();

        builder.HasOne(cf => cf.Feature)
            .WithMany(f => f.CarFeatures)
            .HasForeignKey(cf => cf.FeatureId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        //builder.HasOne(c => c.Feature)
        //  .WithMany(x=>x.Cars)
        //.HasForeignKey(x=>x.CarId)
        //.IsRequired();
    }
}