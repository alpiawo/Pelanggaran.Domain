using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface IJurusanRepository
    {
        List<Jurusan> GetAllJurusan();
        Jurusan GetJurusanById(int id);
        Jurusan CreateJurusan(Pelanggaran.Domain.Jurusan jurusan);
        void UpdateJurusan(Pelanggaran.Domain.Jurusan jurusan);
        void DeleteJurusan(int id);
    }
}
