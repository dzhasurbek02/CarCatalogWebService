using CarCatalogWebService.Services.Users.Requests;
using CarCatalogWebService.Services.Users.Responses;

namespace CarCatalogWebService.Services.Users;

public interface IUserService
{
    public Task Create(CreateUserRequest request);

    public Task Update(UpdateUserRequest request);

    public Task Delete(Guid id);

    public Task<List<GetUsersResponse>> GetAll();

    public Task<GetUsersResponse> GetById(Guid id);
}