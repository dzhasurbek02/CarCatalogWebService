namespace CarCatalogWebService.Services.CarModels.Requests;

public class UpdateCarModelRequest
{
    public Guid Id { get; set; }
    
    public Guid BrandId { get; set; }
    
    public string Name { get; set; }
}