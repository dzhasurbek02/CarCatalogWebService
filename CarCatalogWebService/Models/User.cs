using CarCatalogWebService.Models.BaseModels;

namespace CarCatalogWebService.Models;

public class User : BaseEntity
{
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public DateTime? LastLoginDate { get; set; }
}