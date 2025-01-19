using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.Infrastructure
{
    public class SiswaRepository:ISiswaRepository
    {
        private readonly AppDbContext _context;
        public SiswaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Siswa CreateSiswa(Siswa siswa)
        {
            _context.Siswa.Add(siswa);
            _context.SaveChanges();
            return siswa;
        }

        public void DeleteSiswa(int id)
        {
            var delete = _context.Siswa.FirstOrDefault(s => s.Id == id);
            if (delete != null)
            {
                _context.Siswa.Remove(delete);
                _context.SaveChanges();
            }
        }

        public List<Siswa> GetAllSiswa()
        {
            return _context.Siswa.ToList();
        }

        public Siswa GetSiswaById(int id)
        {
            return _context.Siswa.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateSiswa(Siswa siswa)
        {
            _context.Siswa.Update(siswa);
            _context.SaveChanges();
        }
    }
}
