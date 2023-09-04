using CarCatalogWebService.Models.BaseModels;

namespace CarCatalogWebService.Models;

public class Brand : AuditableBaseEntity
{
    public string Name { get; set; }
    
    public List<Car> Cars { get; set; }
}