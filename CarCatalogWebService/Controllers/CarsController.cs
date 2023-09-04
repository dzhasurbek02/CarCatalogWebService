using CarCatalogWebService.Enums;
using CarCatalogWebService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    public CarsController()
    {
    }

    [HttpGet(Name = "carList")]
    public IActionResult GetAllCars()
    {
        var cars = new[]
        {
            "Mercedes", "Bentley", "Chilly", "Cool", "Mild"
        };

        var brand = new Brand();
        brand.Id = BrandEnum.Mercedes;
        
        return Ok(cars);
    }
}