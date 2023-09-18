using CarCatalogWebService.Services.Photos.Requests;
using FluentValidation;

namespace CarCatalogWebService.RequestValidators.PhotoValidators;

public class CreatePhotoValidator : AbstractValidator<CreatePhotoRequest>
{
    public CreatePhotoValidator()
    {
        RuleFor(t => t.CarId)
            .NotEmpty()
            .WithMessage("Поле CarId не должно быть пустым!");
        
        RuleFor(t => t.PhotoURL)
            .NotEmpty()
            .WithMessage("Поле PhotoURL не должно быть пустым!")
            .Length(3, 255)
            .WithMessage("Длина PhotoURL не должна быть меньше 3 символов и больше 255 символов!");

        RuleFor(t => t.CreatedDateTime)
            .NotEmpty()
            .WithMessage("Поле CreatedDateTime не должно быть пустым!");

        RuleFor(t => t.CreatedByUserId)
            .NotEmpty()
            .WithMessage("Поле CreatedByUserId не должно быть пустым!");
    }
}