using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface ISiswaRepository
    {
        List<Pelanggaran.Domain.Siswa> GetAllSiswa();
        Pelanggaran.Domain.Siswa GetSiswaById(int id);
        Pelanggaran.Domain.Siswa CreateSiswa(Pelanggaran.Domain.Siswa siswa);
        void UpdateSiswa(Pelanggaran.Domain.Siswa siswa);
        void DeleteSiswa(int id);
    }
}
