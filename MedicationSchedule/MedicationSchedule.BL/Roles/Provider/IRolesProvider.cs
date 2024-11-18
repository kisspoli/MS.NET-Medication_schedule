using MedicationSchedule.BL.Roles.Model;

namespace MedicationSchedule.BL.Roles.Provider;

public interface IRolesProvider
{
    IEnumerable<RoleModel> GetRoles();
    RoleModel GetRoleInfo(int id);
}