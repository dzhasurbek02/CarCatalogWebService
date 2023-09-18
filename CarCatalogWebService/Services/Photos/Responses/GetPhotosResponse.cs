namespace CarCatalogWebService.Services.Photos.Responses;

public class GetPhotosResponse
{
    public Guid Id { get; set; }
    
    public Guid CarId { get; set; }
    
    public string PhotoURL { get; set; }
    
    public DateTime CreatedDateTime { get; set; }
    
    public DateTime? UpdatedDateTime { get; set; }
    
    public Guid CreatedByUserId { get; set; }
    
    public Guid? UpdatedByUserId { get; set; }
}