using Sample.Abstractions.Models;
using Sample.Abstractions.Models.Model;
using Sample.Abstractions.Repositories;
using System;

namespace Sample.Repositories
{
    public class UserRepository : DapperRepository<Users>, IUsersRepository
    {
        public UserRepository(IDatabaseConfig config) :
            base(config)
        {
        }

        public void Add(IUser user)
        {
            base.Create((Users)user);
        }

        public IUser[] GetAll()
        {

            return base.RetrieveAll();
        }

        public IUser GetById(int UsertId)
        {
            return base.RetrieveSingle(p => p.UserID, UsertId);
        }
    }
}
