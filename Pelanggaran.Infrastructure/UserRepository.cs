using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User CreateUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            var delete = _context.User.FirstOrDefault(s => s.id == id);
            if (delete != null)
            {
                _context.User.Remove(delete);
                _context.SaveChanges();
            }
        }

        public List<User> GetAllUser()
        {
            return _context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(s => s.id == id);
        }

        public void UpdateUser(User user)
        {
            _context.User.Update(user);
            _context.SaveChanges();
        }
    }
}
