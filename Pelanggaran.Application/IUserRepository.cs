using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface IUserRepository
    {
        List<User> GetAllUser();
        User GetUserById(int id);
        User CreateUser(Pelanggaran.Domain.User user);
        void UpdateUser(Pelanggaran.Domain.User user);
        void DeleteUser(int id);
    }
}
