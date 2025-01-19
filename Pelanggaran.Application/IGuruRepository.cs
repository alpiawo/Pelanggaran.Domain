using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface IGuruRepository
    {
        List<Guru> GetAllGuru();
        Guru GetGuruById(int id);
        Guru CreateGuru(Pelanggaran.Domain.Guru guru);
        void UpdateGuru(Pelanggaran.Domain.Guru guru);
        void DeleteGuru(int id);
    }
}
