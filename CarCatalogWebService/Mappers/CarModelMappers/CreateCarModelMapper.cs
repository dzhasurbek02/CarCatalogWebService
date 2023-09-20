using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.CarModels.Requests;

namespace CarCatalogWebService.Mappers.CarModelMappers;

public class CreateCarModelMapper : Profile
{
    public CreateCarModelMapper()
    {
        CreateMap<CreateCarModelRequest, CarModel>();
    }
}