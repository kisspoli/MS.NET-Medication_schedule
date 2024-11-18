using MedicationSchedule.BL.Roles.Model;

namespace MedicationSchedule.BL.Roles.Manager;

public interface IRolesManager
{
    RoleModel CreateRole(CreateRoleModel createRoleModel);
    RoleModel UpdateRole(UpdateRoleModel updateRoleModel);
    void DeleteRole(int id);
}