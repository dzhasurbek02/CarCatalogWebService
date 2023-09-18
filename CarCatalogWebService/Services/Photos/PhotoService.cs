using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalogWebService.Interfaces;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Photos.Requests;
using CarCatalogWebService.Services.Photos.Responses;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebService.Services.Photos;

public class PhotoService : IPhotoService
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public PhotoService(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task Create(CreatePhotoRequest request)
    {
        var photo = _mapper.Map<Photo>(request);

        await _context.Photos.AddAsync(photo);
        await _context.SaveChangesAsync();
    }

    public async Task Update(UpdatePhotoRequest request)
    {
        var photo = await _context.Photos
            .FirstOrDefaultAsync(t => t.Id == request.Id) 
                    ?? throw new Exception("Photo not found!");

        _mapper.Map(request, photo);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var photo = await _context.Photos
            .FirstOrDefaultAsync(t => t.Id == id)
                    ?? throw new Exception("Photo not found!");

        _context.Photos.Remove(photo);
        await _context.SaveChangesAsync();
    }

    public async Task<List<GetPhotosResponse>> GetAll()
    {
        return await _context.Photos
            .AsNoTracking()
            .ProjectTo<GetPhotosResponse>(_mapper.ConfigurationProvider)
            .ToListAsync()
               ?? throw new Exception("List of photos is empty!");
    }

    public async Task<GetPhotosResponse> GetById(Guid id)
    {
        return await _context.Photos
            .AsNoTracking()
            .Where(t => t.Id == id)
            .ProjectTo<GetPhotosResponse>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync()
               ?? throw new Exception("Photo not found!");
    }
}