namespace CarCatalogWebService.Services.Photos.Requests;

public class CreatePhotoRequest
{
    public Guid CarId { get; set; }
    
    public string PhotoURL { get; set; }
    
    public DateTime CreatedDateTime { get; set; }
    
    public Guid CreatedByUserId { get; set; }
}