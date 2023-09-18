namespace CarCatalogWebService.Services.Photos.Requests;

public class UpdatePhotoRequest
{
    public Guid Id { get; set; }
    
    public Guid CarId { get; set; }
    
    public string PhotoURL { get; set; }
    
    public DateTime UpdatedDateTime { get; set; }
    
    public Guid UpdatedByUserId { get; set; }
}