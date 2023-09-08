using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Cars.Requests;
using CarCatalogWebService.Services.Cars.Responses;

namespace CarCatalogWebService.Services.Cars;

public interface ICarService
{
    public Task Create(CreateCarRequest request);
    
    public Task Update(UpdateCarRequest request);
    
    public Task Delete(Guid id);
    
    public Task<List<GetCarsResponse>> GetAll();
    
    public Task<GetCarsResponse> GetById(Guid id);
}