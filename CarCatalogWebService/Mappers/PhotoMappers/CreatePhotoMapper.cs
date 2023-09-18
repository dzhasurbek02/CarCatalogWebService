using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Photos.Requests;

namespace CarCatalogWebService.Mappers.PhotoMappers;

public class CreatePhotoMapper : Profile
{
    public CreatePhotoMapper()
    {
        CreateMap<CreatePhotoRequest, Photo>();
    }
}