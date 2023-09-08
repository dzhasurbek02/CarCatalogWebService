using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalogWebService.Context;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Users.Requests;
using CarCatalogWebService.Services.Users.Responses;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebService.Services.Users;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UserService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task Create(CreateUserRequest request)
    {
        var user = _mapper.Map<User>(request);

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task Update(UpdateUserRequest request)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(t => t.Id == request.Id)
                ?? throw new Exception("Пользователь не найден!");

        _mapper.Map(request, user);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(t => t.Id == id)
                ?? throw new Exception("Пользователь не найден!");

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task<List<GetUsersResponse>> GetAll()
    {
        return await _context.Users
            .AsNoTracking()
            .ProjectTo<GetUsersResponse>(_mapper.ConfigurationProvider)
            .ToListAsync()
               ?? throw new Exception("Список пользователей пуст!");
    }

    public async Task<GetUsersResponse> GetById(Guid id)
    {
        return await _context.Users
            .AsNoTracking()
            .Where(t => t.Id == id)
            .ProjectTo<GetUsersResponse>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync()
                ?? throw new Exception("Пользователь не найден!");
    }
}