using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface IUserService
    {
        List<User> GetAllUser();
        User GetUserById(int id);
        User CreateUser(Pelanggaran.Domain.User user);
        User UpdateUser(int id, Pelanggaran.Domain.User user);
        void DeleteUser(int id);
    }
}
