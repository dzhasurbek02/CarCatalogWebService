using CarCatalogWebService.Services.CarModels.Requests;
using CarCatalogWebService.Services.CarModels.Responses;

namespace CarCatalogWebService.Services.CarModels;

public interface ICarModelService
{
    public Task Create(CreateCarModelRequest request);

    public Task Update(UpdateCarModelRequest request);

    public Task Delete(Guid id);

    public Task<List<GetCarModelsResponse>> GetAll();

    public Task<GetCarModelsResponse> GetById(Guid id);
}