using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Features.Requests;

namespace CarCatalogWebService.Mappers.FeatureMappers;

public class CreateFeatureMapper : Profile
{
    public CreateFeatureMapper()
    {
        CreateMap<CreateFeatureRequest, Feature>();
    }
}