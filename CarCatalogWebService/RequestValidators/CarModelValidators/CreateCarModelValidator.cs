using CarCatalogWebService.Services.CarModels.Requests;
using FluentValidation;

namespace CarCatalogWebService.RequestValidators.CarModelValidators;

public class CreateCarModelValidator : AbstractValidator<CreateCarModelRequest>
{
    public CreateCarModelValidator()
    {
        RuleFor(t => t.BrandId)
            .NotEmpty()
            .WithMessage("Поле BrandId не должно быть пустым!");

        RuleFor(t => t.Name)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(3, 30)
            .WithMessage("Длина Name не должна быть меньше 3 символов и больше 30 символов!");
    }
}