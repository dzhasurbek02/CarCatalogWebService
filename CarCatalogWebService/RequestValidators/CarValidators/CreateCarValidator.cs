using CarCatalogWebService.Services.Cars.Requests;
using FluentValidation;

namespace CarCatalogWebService.RequestValidators.CarValidators;

public class CreateCarValidator : AbstractValidator<CreateCarRequest>
{
    public CreateCarValidator()
    {
        RuleFor(t => t.BrandId)
            .NotEmpty()
            .WithMessage("Поле BrandId не должно быть пустым!");

        RuleFor(t => t.CarModelId)
            .NotEmpty()
            .WithMessage("Поле CarModelId не должно быть пустым!");

        RuleFor(t => t.BodyStyleId)
            .NotEmpty()
            .WithMessage("Поле BodyStyleId не должно быть пустым!");

        RuleFor(t => t.Year)
            .NotNull()
            .WithMessage("Поле Year не должно быть пустым!");

        RuleFor(t => t.Set)
            .NotNull()
            .WithMessage("Поле Set не должно быть пустым!")
            .Length(2, 30)
            .WithMessage("Длина комплектации не должна превышать 30 символов!");

        RuleFor(t => t.EngineCapacity)
            .NotNull()
            .WithMessage("Поле EngineCapacity не должно быть пустым!");

        RuleFor(t => t.HorsePower)
            .NotNull()
            .WithMessage("Поле HorsePower не должно быть пустым!");

        RuleFor(t => t.FuelTypeId)
            .NotEmpty()
            .WithMessage("Поле FuelTypeId не должно быть пустым!");

        RuleFor(t => t.TransmissionId)
            .NotEmpty()
            .WithMessage("Поле TransmissionId не должно быть пустым!");

        RuleFor(t => t.DriveTrainId)
            .NotEmpty()
            .WithMessage("Поле DriveTrainId не должно быть пустым!");

        RuleFor(t => t.CarColorId)
            .NotEmpty()
            .WithMessage("Поле CarColorId не должно быть пустым!");

        RuleFor(t => t.Description)
            .Length(0, 1000)
            .WithMessage("Длина описания превышает 1000 символов!");

        RuleFor(t => t.Price)
            .NotNull()
            .WithMessage("Поле Price не должно быть пустым!");
    }
}