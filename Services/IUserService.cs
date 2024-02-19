using haunted_house_backend.Models;

namespace haunted_house_backend.Services
{
    public interface IUserService
    {
        LoginUser Getuser(string id);

        void CreateUser(LoginUser user);

        void UpdateUser(LoginUser user);

        void DeleteUser(string id);
    }
}
