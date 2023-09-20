namespace CarCatalogWebService.Services.Users.Requests;

public class UpdateUserRequest
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string EMail { get; set; }
    
    public string Password { get; set; }
    
    public DateTime LastLoginDate { get; set; }
}