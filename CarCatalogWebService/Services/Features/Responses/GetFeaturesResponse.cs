namespace CarCatalogWebService.Services.Features.Responses;

public class GetFeaturesResponse
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTime CreatedDateTime { get; set; }
}