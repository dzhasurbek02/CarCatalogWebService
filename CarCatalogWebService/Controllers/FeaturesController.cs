using CarCatalogWebService.Services.Features;
using CarCatalogWebService.Services.Features.Requests;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class FeaturesController : ControllerBase
{
    private readonly IFeatureService _featureService;
    private readonly IValidator<CreateFeatureRequest> _validatorCreate;
    private readonly IValidator<UpdateFeatureRequest> _validatorUpdate;

    public FeaturesController(IFeatureService featureService,
        IValidator<CreateFeatureRequest> validatorCreate,
        IValidator<UpdateFeatureRequest> validatorUpdate)
    {
        _featureService = featureService;
        _validatorCreate = validatorCreate;
        _validatorUpdate = validatorUpdate;
    }
    
    
    [HttpGet(Name = "featureList")]
    public async Task<IActionResult> GetAll()
    {
        var users = await _featureService.GetAll();

        return Ok(users);
    }
    
    
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var user = await _featureService.GetById(id);

        return Ok(user);
    }



    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateFeatureRequest createFeatureRequest)
    {
        var result = await _validatorCreate.ValidateAsync(createFeatureRequest);

        if (result.IsValid)
        {
            await _featureService.Create(createFeatureRequest);

            return Ok("Feature successfully created!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateFeatureRequest updateFeatureRequest)
    {
        var result = await _validatorUpdate.ValidateAsync(updateFeatureRequest);

        if (result.IsValid)
        {
            await _featureService.Update(updateFeatureRequest);

            return Ok("Feature successfully updated!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _featureService.Delete(id);

        return Ok("Feature successfully deleted!");
    }
}