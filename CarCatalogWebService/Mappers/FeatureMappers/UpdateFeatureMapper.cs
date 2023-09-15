using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Features.Requests;

namespace CarCatalogWebService.Mappers.FeatureMappers;

public class UpdateFeatureMapper : Profile
{
    public UpdateFeatureMapper()
    {
        CreateMap<UpdateFeatureRequest, Feature>();
    }
}