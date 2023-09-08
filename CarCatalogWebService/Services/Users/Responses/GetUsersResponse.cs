namespace CarCatalogWebService.Services.Users.Responses;

public class GetUsersResponse
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string EMail { get; set; }
    
    public string Password { get; set; }
    
    public DateTime LastLoginDate { get; set; }
}