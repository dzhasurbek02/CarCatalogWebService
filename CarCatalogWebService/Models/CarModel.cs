using CarCatalogWebService.Models.BaseModels;

namespace CarCatalogWebService.Models;

public class CarModel : AuditableBaseEntity
{
    public Guid BrandId { get; set; }
    public  Brand Brand { get; set; }
    
    public string Name { get; set; }
    
    public List<Car> Cars { get; set; }
}