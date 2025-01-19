using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public interface IPeraturanRepository
    {
        List<Peraturan> GetAllPeraturan();
        Peraturan GetPeraturanById(int id);
        Peraturan CreatePeraturan(Pelanggaran.Domain.Peraturan peraturan);
        void UpdatePeraturan(Pelanggaran.Domain.Peraturan peraturan);
        void DeletePeraturan(int id);
    }
}
