using CarCatalogWebService.Models.BaseModels;

namespace CarCatalogWebService.Models;

public class Feature : AuditableBaseEntity
{
    public string Name { get; set; }
    
    public List<CarFeature> CarFeatures { get; set; }
}