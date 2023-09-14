namespace CarCatalogWebService.Services.CarModels.Requests;

public class CreateCarModelRequest
{
    public Guid BrandId { get; set; }
    
    public string Name { get; set; }
}