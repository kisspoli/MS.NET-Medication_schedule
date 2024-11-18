using FluentValidation;
using MedicationSchedule.BL.Roles.Model;

namespace MedicationSchedule.Service.Validators.Role;

public class CreateRoleValidator : AbstractValidator<CreateRoleModel>
{
    public CreateRoleValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .Matches(@"[\w_]+")
            .WithMessage("Name must be valid");
    }
}