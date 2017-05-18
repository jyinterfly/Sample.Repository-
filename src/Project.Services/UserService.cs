using Sample.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Abstractions.Models;
using Sample.Abstractions.Repositories;
using Sample.Abstractions.Models.Model;

namespace Sample.Services
{
    public class UserService : IUserService
    {
        public UserService( IUsersRepository userRepo)
        {
            if (userRepo == null)
                throw new ArgumentNullException(nameof(userRepo));

            UserRepository = userRepo;
        }

        private IUsersRepository UserRepository { get; }

        public void AddUser(IUser user)
        {
            UserRepository.Add(user);
        }

        public IUser[] GetUsers()
        {
            return UserRepository.GetAll();
        }

     
    }
}
