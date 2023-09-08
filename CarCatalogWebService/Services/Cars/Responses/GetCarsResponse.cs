namespace CarCatalogWebService.Services.Cars.Responses;

public class GetCarsResponse
{
    public Guid Id { get; set; }
    
    public string BrandName { get; set; }
    
    public string CarModelName { get; set; }
    
    public string BodyStyleName { get; set; }
    
    public short Year { get; set; }
    
    public string Set { get; set; }
    
    public float EngineCapacity { get; set; }
    
    public ushort HorsePower { get; set; }
    
    public string FuelTypeName { get; set; }
    
    public string TransmissionName { get; set; }
    
    public string DriveTrainName { get; set; }
    
    public string CarColorName { get; set; }
    
    public string Description { get; set; }
    
    public float Price { get; set; }
}