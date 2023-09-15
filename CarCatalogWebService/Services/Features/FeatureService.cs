using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalogWebService.Interfaces;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Features.Requests;
using CarCatalogWebService.Services.Features.Responses;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebService.Services.Features;

public class FeatureService : IFeatureService
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public FeatureService(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task Create(CreateFeatureRequest request)
    {
        var feature = _mapper.Map<Feature>(request);

        await _context.Features.AddAsync(feature);
        await _context.SaveChangesAsync();
    }

    public async Task Update(UpdateFeatureRequest request)
    {
        var feature = _context.Features
            .FirstOrDefaultAsync(t => t.Id == request.Id)
                      ?? throw new Exception("Feature not found!");

        await _mapper.Map(request, feature);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var feature = await _context.Features
            .FirstOrDefaultAsync(t => t.Id == id)
                      ?? throw new Exception("Feature not found!");

        _context.Features.Remove(feature);
        await _context.SaveChangesAsync();
    }

    public async Task<List<GetFeaturesResponse>> GetAll()
    {
        return await _context.Features
            .AsNoTracking()
            .ProjectTo<GetFeaturesResponse>(_mapper.ConfigurationProvider)
            .ToListAsync()
               ?? throw new Exception("Feature list is empty!");
    }

    public async Task<GetFeaturesResponse> GetById(Guid id)
    {
        return await _context.Features
            .AsNoTracking()
            .Where(t => t.Id == id)
            .ProjectTo<GetFeaturesResponse>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync()
               ?? throw new Exception("Feature not found!");
    }
}