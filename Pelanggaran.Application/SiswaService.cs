using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public class SiswaService:ISiswaService
    {
        private readonly ISiswaRepository _repository;
        public SiswaService(ISiswaRepository repository)
        {
            _repository = repository;
        }

        public Siswa CreateSiswa(Siswa siswa)
        {
            _repository.CreateSiswa(siswa);
            return siswa;
        }

        public void DeleteSiswa(int id)
        {
            _repository.DeleteSiswa(id);
        }

        public List<Siswa> GetAllSiswa()
        {
            return _repository.GetAllSiswa();
        }

        public Siswa GetSiswaById(int id)
        {
            return _repository.GetSiswaById(id);
        }

        public Siswa UpdateSiswa(int id, Siswa siswa)
        {
            var exSiswa = _repository.GetSiswaById(id);
            if (exSiswa == null)
            {
                return null;
            }

            exSiswa.Nama = siswa.Nama;
            exSiswa.Nis = siswa.Nis;
            exSiswa.Alamat = siswa.Alamat;
            exSiswa.GuruPencatatId = siswa.GuruPencatatId;

            _repository.UpdateSiswa(exSiswa);
            return exSiswa;
        }
    }
}
