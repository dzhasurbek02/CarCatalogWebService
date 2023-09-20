using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Users.Responses;

namespace CarCatalogWebService.Mappers.UserMappers;

public class GetUserMapper : Profile
{
    public GetUserMapper()
    {
        CreateMap<User, GetUsersResponse>();
    }
}