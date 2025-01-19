using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelanggaran.Application
{
    public class JurusanService : IJurusanService
    {
        private readonly IJurusanRepository _repository;

        public JurusanService(IJurusanRepository repository)
        {
            _repository = repository;
        }

        public Pelanggaran.Domain.Jurusan CreateJurusan(Pelanggaran.Domain.Jurusan jurusan)
        {
            _repository.CreateJurusan(jurusan);
            return jurusan;
        }

        public void DeleteJurusan(int id)
        {
            _repository.DeleteJurusan(id);
        }

        public List<Pelanggaran.Domain.Jurusan> GetAllJurusan()
        {
            return _repository.GetAllJurusan();
        }

        public Pelanggaran.Domain.Jurusan GetJurusanById(int id)
        {
            return _repository.GetJurusanById(id);
        }

        public Pelanggaran.Domain.Jurusan UpdateJurusan(int id, Pelanggaran.Domain.Jurusan jurusan)
        {
            var existing = _repository.GetJurusanById(id);
            if (existing == null)
                return null;

            existing.Nama = jurusan.Nama;
            _repository.UpdateJurusan(existing);
            return existing;
        }
    }
}

