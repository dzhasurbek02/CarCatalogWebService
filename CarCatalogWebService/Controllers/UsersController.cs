using CarCatalogWebService.Services.Users;
using CarCatalogWebService.Services.Users.Requests;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IValidator<CreateUserRequest> _validatorCreate;
    private readonly IValidator<UpdateUserRequest> _validatorUpdate;

    public UsersController(IUserService userService,
        IValidator<CreateUserRequest> validatorCreate,
        IValidator<UpdateUserRequest> validatorUpdate)
    {
        _userService = userService;
        _validatorCreate = validatorCreate;
        _validatorUpdate = validatorUpdate;
    }
    
    
    [HttpGet(Name = "useList")]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userService.GetAll();

        return Ok(users);
    }
    
    
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var user = await _userService.GetById(id);

        return Ok(user);
    }



    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest createUserRequest)
    {
        var result = await _validatorCreate.ValidateAsync(createUserRequest);

        if (result.IsValid)
        {
            await _userService.Create(createUserRequest);

            return Ok("User successfully created!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateUserRequest updateUserRequest)
    {
        var result = await _validatorUpdate.ValidateAsync(updateUserRequest);

        if (result.IsValid)
        {
            await _userService.Update(updateUserRequest);

            return Ok("User successfully updated!");
        }

        return BadRequest(result.Errors.Select(t => t.ErrorMessage));
    }



    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await _userService.Delete(id);

        return Ok("User successfully deleted!");
    }
}