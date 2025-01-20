using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User CreateUser(User user)
        {
            _repository.CreateUser(user);
            return user;
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
        }

        public List<User> GetAllUser()
        {
            return _repository.GetAllUser();
        }

        public User GetUserById(int id)
        {
            return _repository.GetUserById(id);
        }

        public User UpdateUser(int id, User user)
        {
            var exUser = _repository.GetUserById(id);
            if (exUser == null)
            {
                return null;
            }

            exUser.nama = user.nama;
            exUser.email = user.email;
            exUser.password = user.password;

            _repository.UpdateUser(exUser);
            return exUser;
        }
    }
}
