using CarCatalogWebService.Services.Users.Requests;
using FluentValidation;

namespace CarCatalogWebService.RequestValidators.UserValidators;

public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserValidator()
    {
        RuleFor(t => t.Name)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(3, 30)
            .WithMessage("Длина Name не должна быть меньше 3 символов и больше 30 символов!");

        RuleFor(t => t.Password)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(6, 30)
            .WithMessage("Длина Password не должна быть меньше 6 символов и больше 30 символов!");

        RuleFor(t => t.EMail)
            .NotEmpty()
            .WithMessage("Поле EMail не должно быть пустым!")
            .Length(10, 48)
            .WithMessage("Длина EMail не должна быть меньше 10 символов и больше 48 символов!");
    }
}