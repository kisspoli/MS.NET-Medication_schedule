using AutoMapper;
using MedicationSchedule.BL.Users.Exceptions;
using MedicationSchedule.BL.Users.Model;
using MedicationSchedule.DataAccess.Entities;
using MedicationSchedule.DataAccess.Repository;

namespace MedicationSchedule.BL.Users.Provider;

public class UsersProvider : IUsersProvider
{
    private readonly IRepository<UserEntity> _usersRepository;
    private readonly IMapper _mapper;
    
    public UsersProvider(IRepository<UserEntity> usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }
    
    public IEnumerable<UserModel> GetUsers()
    {
        var users = _usersRepository.GetAll().ToList();

        return _mapper.Map<IEnumerable<UserModel>>(users);
    }

    public UserModel GetUserInfo(int id)
    {
        var user = _usersRepository.GetById(id);
        if (user == null)
        {
            throw new UserNotPresentException("User does not exist.");
        }

        return _mapper.Map<UserModel>(user);
    }
}