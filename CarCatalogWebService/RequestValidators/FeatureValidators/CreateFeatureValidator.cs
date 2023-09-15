using CarCatalogWebService.Services.Features.Requests;
using FluentValidation;

namespace CarCatalogWebService.RequestValidators.FeatureValidators;

public class CreateFeatureValidator : AbstractValidator<CreateFeatureRequest>
{
    public CreateFeatureValidator()
    {
        RuleFor(t => t.Name)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(3, 30)
            .WithMessage("Длина Name не должна быть меньше 3 символов и больше 30 символов!");
    }
}