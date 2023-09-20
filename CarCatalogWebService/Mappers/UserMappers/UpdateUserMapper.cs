using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Users.Requests;

namespace CarCatalogWebService.Mappers.UserMappers;

public class UpdateUserMapper : Profile
{
    public UpdateUserMapper()
    {
        CreateMap<UpdateUserRequest, User>();
    }
}