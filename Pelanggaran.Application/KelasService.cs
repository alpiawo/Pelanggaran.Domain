using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public class KelasService : IKelasService
    {
        private readonly IKelasRepository _kelasRepository;
        public KelasService(IKelasRepository kelasRepository)
        {
            _kelasRepository = kelasRepository;
        }

        public Kelas CreateKelas(Kelas kelas)
        {
            _kelasRepository.CreateKelas(kelas);
            return kelas;
        }

        public void DeleteKelas(int id)
        {
            _kelasRepository.DeleteKelas(id);
        }

        public List<Kelas> GetAllKelas()
        {
            return _kelasRepository.GetAllKelas();
        }

        public Kelas GetKelasById(int id)
        {
            return _kelasRepository.GetKelasById(id);
        }

        public Kelas UpdateKelas(int id, Kelas kelas)
        {
            var exKelas = _kelasRepository.GetKelasById(id);
            if (exKelas == null)
            {
                return null;
            }
            exKelas.Nama = kelas.Nama;
            exKelas.IdJurusan = kelas.IdJurusan;
            
            _kelasRepository.UpdateKelas(exKelas);
            return exKelas;
        }
    }
}
