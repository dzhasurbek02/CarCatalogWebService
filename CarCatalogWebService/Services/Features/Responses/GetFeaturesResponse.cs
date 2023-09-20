using CarCatalogWebService.Services.Cars.Responses;

namespace CarCatalogWebService.Services.Features.Responses;

public class GetFeaturesResponse
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public List<GetCarsResponse>? Cars { get; set; }
    
    public DateTime CreatedDateTime { get; set; }
    
    public DateTime? UpdatedDateTime { get; set; }
    
    public Guid CreatedByUserId { get; set; }
    
    public Guid? UpdatedByUserId { get; set; }
}