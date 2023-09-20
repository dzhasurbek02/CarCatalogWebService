using CarCatalogWebService.Services.CarModels;
using CarCatalogWebService.Services.CarModels.Requests;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class CarModelsController : ControllerBase
{
    private readonly ICarModelService _carModelService;
    private readonly IValidator<CreateCarModelRequest> _validatorCreate;
    private readonly IValidator<UpdateCarModelRequest> _validatorUpdate;

    public CarModelsController(ICarModelService carModelService,
        IValidator<CreateCarModelRequest> validatorCreate,
        IValidator<UpdateCarModelRequest> validatorUpdate)
    {
        _carModelService = carModelService;
        _validatorCreate = validatorCreate;
        _validatorUpdate = validatorUpdate;
    }
    
    
    [HttpGet(Name = "carModelList")]
    public async Task<IActionResult> GetAll()
    {
        var models = await _carModelService.GetAll();

        return Ok(models);
    }
    
    
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var model = await _carModelService.GetById(id);

        return Ok(model);
    }



    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateCarModelRequest createCarModelRequest)
    {
        var result = await _validatorCreate.ValidateAsync(createCarModelRequest);

        if (result.IsValid)
        {
            await _carModelService.Create(createCarModelRequest);

            return Ok("CarModel successfully created!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateCarModelRequest updateCarModelRequest)
    {
        var result = await _validatorUpdate.ValidateAsync(updateCarModelRequest);

        if (result.IsValid)
        {
            await _carModelService.Update(updateCarModelRequest);

            return Ok("CarModel successfully updated!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _carModelService.Delete(id);

        return Ok("CarModel successfully deleted!");
    }
}