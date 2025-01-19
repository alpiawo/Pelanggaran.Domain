using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.Infrastructure
{
    public class KelasRepository:IKelasRepository
    {
        private readonly AppDbContext _dbContext;

        public KelasRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Kelas CreateKelas(Kelas kelas)
        {
            _dbContext.Kelas.Add(kelas);
            _dbContext.SaveChanges();
            return kelas;
        }

        public void DeleteKelas(int id)
        {
            var kelas = _dbContext.Kelas.FirstOrDefault(k => k.Id == id);
            if (kelas != null)
            {
                _dbContext.Kelas.Remove(kelas);
                _dbContext.SaveChanges();
            }
        }

        public List<Kelas> GetAllKelas()
        {
            return _dbContext.Kelas.ToList();
        }

        public Kelas GetKelasById(int id)
        {
            return _dbContext.Kelas.FirstOrDefault(k => k.Id == id);
        }

        public void UpdateKelas(Kelas kelas)
        {
            _dbContext.Kelas.Update(kelas);
            _dbContext.SaveChanges();
        }
    }
}
