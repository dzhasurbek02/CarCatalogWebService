using CarCatalogWebService.Models;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebService.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<BodyStyle> BodyStyles { get; set; }
    
    public DbSet<Brand> Brands { get; set; }
    
    public DbSet<Car> Cars { get; set; }
    
    public DbSet<CarColor> CarColors { get; set; }
    
    public DbSet<CarFeature> CarFeatures { get; set; }
    
    public DbSet<CarModel> CarModels { get; set; }
    
    public DbSet<DriveTrain> DriveTrains { get; set; }
    
    public DbSet<Feature> Features { get; set; }
    
    public DbSet<FuelType> FuelTypes { get; set; }
    
    public DbSet<Photo> Photos { get; set; }
    
    public DbSet<Transmission> Transmissions { get; set; }
    
    public DbSet<User> Users { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}