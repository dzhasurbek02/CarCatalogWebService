namespace CarCatalogWebService.Services.CarModels.Requests;

public class CreateModelRequest
{
    public Guid BranId { get; set; }
    
    public string Name { get; set; }
}