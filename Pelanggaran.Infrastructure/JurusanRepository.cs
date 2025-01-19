using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.Infrastructure
{
    public class JurusanRepository : IJurusanRepository
    {
        private readonly AppDbContext _dbContext;

        public JurusanRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Jurusan CreateJurusan(Jurusan jurusan)
        {
            _dbContext.jurusan.Add(jurusan);
            _dbContext.SaveChanges();
            return jurusan;
        }

        public void DeleteJurusan(int id)
        {
            var jurusan = _dbContext.jurusan.FirstOrDefault(j => j.Id == id);
            if (jurusan != null)
            {
                _dbContext.jurusan.Remove(jurusan);
                _dbContext.SaveChanges();
            }
        }

        public List<Jurusan> GetAllJurusan()
        {
            return _dbContext.jurusan.ToList();
        }

        public Jurusan GetJurusanById(int id)
        {
            return _dbContext.jurusan.FirstOrDefault(j => j.Id == id);
        }

        public void UpdateJurusan(Jurusan jurusan)
        {
            _dbContext.jurusan.Update(jurusan);
            _dbContext.SaveChanges();
        }
    }
}
