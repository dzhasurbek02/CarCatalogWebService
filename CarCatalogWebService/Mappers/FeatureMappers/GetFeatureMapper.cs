using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Features.Responses;

namespace CarCatalogWebService.Mappers.FeatureMappers;

public class GetFeatureMapper : Profile
{
    public GetFeatureMapper()
    {
        CreateMap<Feature, GetFeaturesResponse>()
            .ForMember(f => f.Cars, t => t.MapFrom(m => m.CarFeatures!.Select(p => p.Car)));
    }
}