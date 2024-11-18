using FluentValidation;
using MedicationSchedule.BL.Roles.Model;

namespace MedicationSchedule.Service.Validators.Role;

public class UpdateRoleValidator : AbstractValidator<UpdateRoleModel>
{
    public UpdateRoleValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Role must be valid");
        RuleFor(x => x.Name)
            .NotEmpty()
            .Matches(@"[\w_]+")
            .WithMessage("Name must be valid");
    }
}