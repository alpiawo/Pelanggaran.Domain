using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.Infrastructure
{
    public class PeraturanRepository:IPeraturanRepository
    {
        private readonly AppDbContext _dbContext;

        public PeraturanRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Peraturan CreatePeraturan(Peraturan peraturan)
        {
            _dbContext.Peraturan.Add(peraturan);
            _dbContext.SaveChanges();
            return peraturan;
        }

        public void DeletePeraturan(int id)
        {
            var peraturan = _dbContext.Peraturan.FirstOrDefault(p => p.Id == id);
            if (peraturan != null)
            {
                _dbContext.Peraturan.Remove(peraturan);
                _dbContext.SaveChanges();
            }
        }

        public List<Peraturan> GetAllPeraturan()
        {
            return _dbContext.Peraturan.ToList();
        }

        public Peraturan GetPeraturanById(int id)
        {
            return _dbContext.Peraturan.FirstOrDefault(p => p.Id == id);
        }

        public void UpdatePeraturan(Peraturan peraturan)
        {
            _dbContext.Peraturan.Update(peraturan);
            _dbContext.SaveChanges();
        }
    }
}
