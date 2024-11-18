using FluentValidation;
using MedicationSchedule.BL.Users.Model;

namespace MedicationSchedule.Service.Validators;

public class CreateUserModelValidator: AbstractValidator<CreateUserModel>
{
    public CreateUserModelValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .Matches(@"[\w_]+")
            .WithMessage("Name must be valid");
        RuleFor(x => x.Surname)
            .NotEmpty()
            .Matches(@"[\w_]+")
            .WithMessage("Surname must be valid");
        RuleFor(x => x.Patronymic)
            .Matches(@"[\w_]+")
            .WithMessage("Surname must be valid");
        RuleFor(x => x.Birthday)
            .NotEmpty()
            .WithMessage("Birthday must be valid");
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Email must be valid");
        RuleFor(x => x.RoleId)
            .NotEmpty()
            .WithMessage("Role must be valid");
    }
}