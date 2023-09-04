using CarCatalogWebService.Models.BaseModels;

namespace CarCatalogWebService.Models;

public class Photo : AuditableBaseEntity
{
    public Guid CarId { get; set; }
    public Car Car { get; set; }
    
    public string PhotoURL { get; set; }
}