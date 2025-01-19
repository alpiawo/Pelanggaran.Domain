using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public class PelanggaranService:IPeraturanService
    {
        private readonly IPeraturanRepository _peraturanRepository;
        public PelanggaranService(IPeraturanRepository peraturanRepository)
        {
            _peraturanRepository = peraturanRepository;
        }

        public Peraturan CreatePeraturan(Peraturan peraturan)
        {
            _peraturanRepository.CreatePeraturan(peraturan);
            return peraturan;
        }

        public void DeletePeraturan(int id)
        {
            _peraturanRepository.DeletePeraturan(id);
        }

        public List<Peraturan> GetAllPeraturan()
        {
            return _peraturanRepository.GetAllPeraturan();
        }

        public Peraturan GetPeraturanById(int id)
        {
            return _peraturanRepository.GetPeraturanById(id);
        }

        public Peraturan UpdatePeraturan(int id, Peraturan peraturan)
        {
            var exPeraturan = _peraturanRepository.GetPeraturanById(id);
            if (exPeraturan == null)
            {
                return null;
            }

            exPeraturan.Nama = peraturan.Nama;
            exPeraturan.Deskripsi = peraturan.Deskripsi;
            exPeraturan.Poin =  peraturan.Poin;
            _peraturanRepository.UpdatePeraturan(peraturan);
            return exPeraturan;

        }
    }
}
