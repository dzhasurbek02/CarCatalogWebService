using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Photos.Responses;

namespace CarCatalogWebService.Mappers.PhotoMappers;

public class GetPhotoMapper : Profile
{
    public GetPhotoMapper()
    {
        CreateMap<Photo, GetPhotosResponse>();
    }
}