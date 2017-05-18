using Sample.Abstractions.Models.Model;

namespace Sample.Abstractions.Services
{
    public interface IUserService
    {
        void AddUser(IUser user);
        IUser[] GetUsers();
    }
}
