using AutoMapper;
using MedicationSchedule.BL.Roles.Exceptions;
using MedicationSchedule.BL.Roles.Model;
using MedicationSchedule.DataAccess.Entities;
using MedicationSchedule.DataAccess.Repository;

namespace MedicationSchedule.BL.Roles.Manager;

public class RolesManager : IRolesManager
{
    private readonly IRepository<RoleEntity> _rolesRepository;
    private readonly IMapper _mapper;

    public RolesManager(IRepository<RoleEntity> rolesRepository, IMapper mapper)
    {
        _rolesRepository = rolesRepository;
        _mapper = mapper;
    }

    public RoleModel CreateRole(CreateRoleModel createRoleModel)
    {
        var role = _mapper.Map<RoleEntity>(createRoleModel);
        role = _rolesRepository.Save(role);
        return _mapper.Map<RoleModel>(role);
    }

    public RoleModel UpdateRole(UpdateRoleModel updateRoleModel)
    {
        var role = _mapper.Map<RoleEntity>(updateRoleModel);
        role = _rolesRepository.Save(role);
        return _mapper.Map<RoleModel>(role);
    }

    public void DeleteRole(int id)
    {
        var role = _rolesRepository.GetById(id);
        if (role == null)
        {
            throw new RoleNotPresentException("Role does not exist.");
        }
            
        _rolesRepository.Delete(role);
    }
}