using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.Infrastructure
{
    public class GuruRepository : IGuruRepository
    {
        private readonly AppDbContext _appDbContext;
        public GuruRepository(AppDbContext Context)
        {
            _appDbContext = Context;
        }

        public Guru CreateGuru(Guru guru)
        {
            _appDbContext.guru.Add(guru);
            _appDbContext.SaveChanges();
            return guru;
        }

        public void DeleteGuru(int id)
        {
            var peraturan = _appDbContext.guru.FirstOrDefault(g => g.Id == id);
            if (peraturan != null)
            {
                _appDbContext.guru.Remove(peraturan);
                _appDbContext.SaveChanges();
            }
        }

        public List<Guru> GetAllGuru()
        {
            return _appDbContext.guru.ToList();
        }

        public Guru GetGuruById(int id)
        {
            return _appDbContext.guru.FirstOrDefault(g => g.Id == id);
        }

        public void UpdateGuru(Guru guru)
        {
            _appDbContext.guru.Update(guru);
            _appDbContext.SaveChanges();
        }
    }
}
