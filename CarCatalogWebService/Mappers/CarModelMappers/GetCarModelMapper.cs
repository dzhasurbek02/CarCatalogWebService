using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.CarModels.Responses;

namespace CarCatalogWebService.Mappers.CarModelMappers;

public class GetCarModelMapper : Profile
{
    public GetCarModelMapper()
    {
        CreateMap<CarModel, GetCarModelsResponse>()
            .ForMember(c => c.BrandName, t => t.MapFrom(src => $"{src.Brand.Name}"));
    }
}