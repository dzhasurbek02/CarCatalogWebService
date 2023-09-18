using CarCatalogWebService.Services.Photos.Requests;
using CarCatalogWebService.Services.Photos.Responses;

namespace CarCatalogWebService.Services.Photos;

public interface IPhotoService
{
    public Task Create(CreatePhotoRequest request);

    public Task Update(UpdatePhotoRequest request);

    public Task Delete(Guid id);

    public Task<List<GetPhotosResponse>> GetAll();

    public Task<GetPhotosResponse> GetById(Guid id);
}