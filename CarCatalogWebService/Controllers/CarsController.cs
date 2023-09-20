using CarCatalogWebService.Services.Cars;
using CarCatalogWebService.Services.Cars.Requests;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    private readonly ICarService _carService;
    private readonly IValidator<CreateCarRequest> _validatorCreate;
    private readonly IValidator<UpdateCarRequest> _validatorUpdate;

    public CarsController(ICarService carService,
        IValidator<CreateCarRequest> validatorCreate,
        IValidator<UpdateCarRequest> validatorUpdate)
    {
        _carService = carService;
        _validatorCreate = validatorCreate;
        _validatorUpdate = validatorUpdate;
    }
    

    [HttpGet(Name = "carList")]
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
    }

    
    
    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateCarRequest createCarRequest)
    {
        var result = await _validatorCreate.ValidateAsync(createCarRequest);

        if (result.IsValid)
        {
            await _carService.Create(createCarRequest);

            return Ok("Автомобиль успешно добавлен!");
        }

        return BadRequest(result.Errors.Select(c => c.ErrorMessage));
    }

    
    
    [HttpPut("Update")]
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
    }
}