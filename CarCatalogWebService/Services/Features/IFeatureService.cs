using CarCatalogWebService.Services.Features.Requests;
using CarCatalogWebService.Services.Features.Responses;

namespace CarCatalogWebService.Services.Features;

public interface IFeatureService
{
    public Task Create(CreateFeatureRequest request);

    public Task Update(UpdateFeatureRequest request);

    public Task Delete(Guid id);

    public Task<List<GetFeaturesResponse>> GetAll();

    public Task<GetFeaturesResponse> GetById(Guid id);
}