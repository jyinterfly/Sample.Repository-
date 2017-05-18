using Sample.Abstractions.Models.Model;

namespace Sample.Abstractions.Repositories
{
    public interface IUsersRepository
    {
        void Add(IUser product);
        IUser[] GetAll();
        IUser GetById(int Id);
    }
}
