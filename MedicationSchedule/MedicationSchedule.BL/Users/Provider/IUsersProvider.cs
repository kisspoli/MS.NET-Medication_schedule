using MedicationSchedule.BL.Users.Model;

namespace MedicationSchedule.BL.Users.Provider;

public interface IUsersProvider
{
    IEnumerable<UserModel> GetUsers();
    UserModel GetUserInfo(int id);
}