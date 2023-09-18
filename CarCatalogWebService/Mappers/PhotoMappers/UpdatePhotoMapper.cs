using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Photos.Requests;

namespace CarCatalogWebService.Mappers.PhotoMappers;

public class UpdatePhotoMapper : Profile
{
    public UpdatePhotoMapper()
    {
        CreateMap<UpdatePhotoRequest, Photo>();
    }
}