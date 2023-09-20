using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalogWebService.Interfaces;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.CarModels.Requests;
using CarCatalogWebService.Services.CarModels.Responses;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebService.Services.CarModels;

public class CarModelService : ICarModelService
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CarModelService(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Create(CreateCarModelRequest request)
    {
        var model = _mapper.Map<CarModel>(request);

        await _context.CarModels.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Update(UpdateCarModelRequest request)
    {
        var model = await _context.CarModels
            .FirstOrDefaultAsync(t => t.Id == request.Id)
                    ?? throw new Exception("CarModel not found!");

        _mapper.Map(request, model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var model = await _context.CarModels
                        .FirstOrDefaultAsync(t => t.Id == id)
                    ?? throw new Exception("CarModel not found!");

        _context.CarModels.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<GetCarModelsResponse>> GetAll()
    {
        return await _context.CarModels
            .AsNoTracking()
            .ProjectTo<GetCarModelsResponse>(_mapper.ConfigurationProvider)
            .ToListAsync()
               ?? throw new Exception("CarModels list is empty!");
    }

    public async Task<GetCarModelsResponse> GetById(Guid id)
    {
        return await _context.CarModels
            .AsNoTracking()
            .Where(t => t.Id == id)
            .ProjectTo<GetCarModelsResponse>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync()
               ?? throw new Exception("CarModel not found!");
    }
}