using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalogWebService.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Year)
            .IsRequired();
        
        builder.Property(c => c.Set)
            .IsRequired()
            .HasMaxLength(255);
        
        builder.Property(c => c.EngineCapacity)
            .IsRequired();
        
        builder.Property(c => c.HorsePower)
            .IsRequired();
        
        builder.Property(c => c.Description)
            .HasMaxLength(1000);
        
        builder.Property(c => c.Price)
            .IsRequired();

        builder.HasOne<Brand>(c => c.Brand)
            .WithMany(b => b.Cars)
            .HasForeignKey(c => c.BranId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<CarModel>(c => c.CarModel)
            .WithMany(m => m.Cars)
            .HasForeignKey(c => c.CarModelId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<BodyStyle>(c => c.BodyStyle)
            .WithMany(bs => bs.Cars)
            .HasForeignKey(c => c.BodyStyleId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<FuelType>(c => c.FuelType)
            .WithMany(f => f.Cars)
            .HasForeignKey(c => c.FuelTypeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Transmission>(c => c.Transmission)
            .WithMany(t => t.Cars)
            .HasForeignKey(c => c.TransmissionId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<DriveTrain>(c => c.DriveTrain)
            .WithMany(d => d.Cars)
            .HasForeignKey(c => c.DriveTrainId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<CarColor>(c => c.CarColor)
            .WithMany(col => col.Cars)
            .HasForeignKey(c => c.CarColorId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);



        //builder.HasOne(c => c.Features)
          //  .WithMany();
        //  .UsingEntity(j => j.ToTable(CarFeature));
    }
}