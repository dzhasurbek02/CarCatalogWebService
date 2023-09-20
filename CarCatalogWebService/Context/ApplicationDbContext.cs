using System.Reflection;
using CarCatalogWebService.Interfaces;
using CarCatalogWebService.Models;
using CarCatalogWebService.Models.BaseModels;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebService.Context;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        base.OnModelCreating(builder);
    }

    /*public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        var entries = ChangeTracker.Entries();

        foreach (var entry in entries)
        {
            if (entry.Entity is AuditableBaseEntity)
            {
                if (entry.State == EntityState.Added)
                {
                    
                }
            }
        }
        
        return base.SaveChangesAsync(cancellationToken);
    }*/
}