using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalogWebService.Context;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Cars.Requests;
using CarCatalogWebService.Services.Cars.Responses;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebService.Services.Cars;

public class CarService : ICarService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CarService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Create(CreateCarRequest request)
    {
        var car = _mapper.Map<Car>(request);

        await _context.Cars.AddAsync(car);
        await _context.SaveChangesAsync();
    }

    public async Task Update(UpdateCarRequest request)
    {
        var car = await _context.Cars
            .FirstOrDefaultAsync(t => t.Id == request.Id)
                ?? throw new Exception("Автомобиль не найден!");

        _mapper.Map(request, car);
        await _context.SaveChangesAsync();

    }

    public async Task Delete(Guid id)
    {
        var car = await _context.Cars
            .FirstOrDefaultAsync(t => t.Id == id)
                ?? throw new Exception("Автомобиль не найден!");

        _context.Cars.Remove(car);
        await _context.SaveChangesAsync();
    }

    public async Task<List<GetCarsResponse>> GetAll()
    {
        return await _context.Cars
            .AsNoTracking()
            .ProjectTo<GetCarsResponse>(_mapper.ConfigurationProvider)
            .ToListAsync()
                ?? throw new Exception("Список автомобилей пуст!");
    }

    public async Task<GetCarsResponse> GetById(Guid id)
    {
        return await _context.Cars
            .AsNoTracking()
            .Where(t => t.Id == id)
            .ProjectTo<GetCarsResponse>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync()
                ?? throw new Exception("Автомобиль не найден!");
    }
}