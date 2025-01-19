using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface ISiswaService
    {
        List<Siswa> GetAllSiswa();
        Siswa GetSiswaById(int id);
        Siswa CreateSiswa(Pelanggaran.Domain.Siswa siswa);
        Siswa UpdateSiswa(int id, Pelanggaran.Domain.Siswa siswa);
        void DeleteSiswa(int id);
    }
}
