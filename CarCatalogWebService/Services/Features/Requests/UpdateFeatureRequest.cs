namespace CarCatalogWebService.Services.Features.Requests;

public class UpdateFeatureRequest
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
}