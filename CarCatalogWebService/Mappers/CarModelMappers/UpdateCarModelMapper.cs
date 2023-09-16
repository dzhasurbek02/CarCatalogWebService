using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.CarModels.Requests;

namespace CarCatalogWebService.Mappers.CarModelMappers;

public class UpdateCarModelMapper : Profile
{
    public UpdateCarModelMapper()
    {
        CreateMap<UpdateCarModelRequest, CarModel>();
    }
}