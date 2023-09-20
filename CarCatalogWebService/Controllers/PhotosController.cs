using CarCatalogWebService.Services.Photos;
using CarCatalogWebService.Services.Photos.Requests;
using CarCatalogWebService.Services.Users;
using CarCatalogWebService.Services.Users.Requests;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class PhotosController : ControllerBase
{
    private readonly IPhotoService _photoService;
    private readonly IValidator<CreatePhotoRequest> _validatorCreate;
    private readonly IValidator<UpdatePhotoRequest> _validatorUpdate;

    public PhotosController(IPhotoService photoService,
        IValidator<CreatePhotoRequest> validatorCreate,
        IValidator<UpdatePhotoRequest> validatorUpdate)
    {
        _photoService = photoService;
        _validatorCreate = validatorCreate;
        _validatorUpdate = validatorUpdate;
    }
    
    
    [HttpGet(Name = "photoList")]
    public async Task<IActionResult> GetAll()
    {
        var photos = await _photoService.GetAll();

        return Ok(photos);
    }
    
    
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var photo = await _photoService.GetById(id);

        return Ok(photo);
    }



    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreatePhotoRequest createPhotoRequest)
    {
        var result = await _validatorCreate.ValidateAsync(createPhotoRequest);

        if (result.IsValid)
        {
            await _photoService.Create(createPhotoRequest);

            return Ok("Photo successfully created!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdatePhotoRequest updatePhotoRequest)
    {
        var result = await _validatorUpdate.ValidateAsync(updatePhotoRequest);

        if (result.IsValid)
        {
            await _photoService.Update(updatePhotoRequest);

            return Ok("Photo successfully updated!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _photoService.Delete(id);

        return Ok("Photo successfully deleted!");
    }
}