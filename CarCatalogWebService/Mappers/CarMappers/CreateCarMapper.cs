using AutoMapper;
using CarCatalogWebService.Models;
using CarCatalogWebService.Services.Cars.Requests;

namespace CarCatalogWebService.Mappers.CarMappers;

public class CreateCarMapper : Profile
{
    public CreateCarMapper()
    {
        CreateMap<CreateCarRequest, Car>();
    }
}