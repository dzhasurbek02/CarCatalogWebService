using CarCatalogWebService.Services.Photos.Requests;
using FluentValidation;

namespace CarCatalogWebService.RequestValidators.PhotoValidators;

public class UpdatePhotoValidator : AbstractValidator<UpdatePhotoRequest>
{
    public UpdatePhotoValidator()
    {
        RuleFor(t => t.Id)
            .NotEmpty()
            .WithMessage("Поле Id не должно быть пустым!");
        
        RuleFor(t => t.CarId)
            .NotEmpty()
            .WithMessage("Поле CarId не должно быть пустым!");
        
        RuleFor(t => t.PhotoURL)
            .NotEmpty()
            .WithMessage("Поле PhotoURL не должно быть пустым!")
            .Length(3, 255)
            .WithMessage("Длина PhotoURL не должна быть меньше 3 символов и больше 255 символов!");

        RuleFor(t => t.UpdatedDateTime)
            .NotEmpty()
            .WithMessage("Поле CreatedDateTime не должно быть пустым!");

        RuleFor(t => t.UpdatedByUserId)
            .NotEmpty()
            .WithMessage("Поле CreatedByUserId не должно быть пустым!");
    }
}