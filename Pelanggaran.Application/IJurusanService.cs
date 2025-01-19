using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface IJurusanService
    {
        List<Jurusan> GetAllJurusan();
        Jurusan GetJurusanById(int id);
        Jurusan CreateJurusan(Pelanggaran.Domain.Jurusan jurusan);
        Jurusan UpdateJurusan(int id, Pelanggaran.Domain.Jurusan jurusan);
        void DeleteJurusan(int id);
    }
}
