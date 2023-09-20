using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Users.Requests;

namespace CarCatalogWebService.Mappers.UserMappers;

public class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
    }
}