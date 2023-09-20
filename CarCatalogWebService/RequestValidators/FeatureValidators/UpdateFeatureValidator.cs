using CarCatalogWebService.Services.Features.Requests;
using FluentValidation;

namespace CarCatalogWebService.RequestValidators.FeatureValidators;

public class UpdateFeatureValidator : AbstractValidator<UpdateFeatureRequest>
{
    public UpdateFeatureValidator()
    {
        RuleFor(t => t.Name)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(3, 30)
            .WithMessage("Длина Name не должна быть меньше 3 символов и больше 30 символов!");
    }
}