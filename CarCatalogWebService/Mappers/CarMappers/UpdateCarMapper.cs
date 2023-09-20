using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Cars.Requests;

namespace CarCatalogWebService.Mappers.CarMappers;

public class UpdateCarMapper : Profile
{
    public UpdateCarMapper()
    {
        CreateMap<UpdateCarRequest, Car>();
    }
}