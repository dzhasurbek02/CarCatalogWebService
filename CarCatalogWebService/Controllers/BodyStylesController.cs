using CarCatalogWebService.Enums;
using CarCatalogWebService.Interfaces;
using CarCatalogWebService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class BodyStylesController : ControllerBase
{
    private readonly IApplicationDbContext _context;

    public BodyStylesController(
        IApplicationDbContext context)
    {
        _context = context;
    }
    

    /*[HttpGet(Name = "carList")]
    public async Task<IActionResult> GetAll()
    {
        var cars = await _carService.GetAll();
        
        return Ok(cars);
    }
    


    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var cars = await _carService.GetById(id);

        return Ok(cars);
    }*/

    
    
    [HttpPost("Create")]
    public async Task<IActionResult> Create()
    {
        foreach (var bodyStyle in BodyStyleEnum.List)
        {
            _context.BodyStyles.Add(new BodyStyle
            {
                Id = bodyStyle.Value,
                Name = bodyStyle.Name
            });
        }

        await _context.SaveChangesAsync();

        return Ok();
    }

    
    
    /*[HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateCarRequest updateCarRequest)
    {
        var result = await _validatorUpdate.ValidateAsync(updateCarRequest);

        if (result.IsValid)
        {
            await _carService.Update(updateCarRequest);

            return Ok("Автомобиль успешно обновлен!");
        }

        return BadRequest(result.Errors.Select(c => c.ErrorMessage));
    }

    
    
    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _carService.Delete(id);

        return Ok("Автомобиль успешно удален!");
    }*/
}