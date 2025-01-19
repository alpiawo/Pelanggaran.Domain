using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface IKelasRepository
    {
        List<Kelas> GetAllKelas();
        Kelas GetKelasById(int id);
        Kelas CreateKelas(Pelanggaran.Domain.Kelas kelas);
        void UpdateKelas(Pelanggaran.Domain.Kelas kelas);
        void DeleteKelas(int id);
    }
}
