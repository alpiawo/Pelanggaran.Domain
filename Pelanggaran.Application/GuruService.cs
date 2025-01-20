using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelanggaran.Domain;

namespace Pelanggaran.Application
{
    public class GuruService:IGuruService
    {
        private readonly IGuruRepository _GuruRepository;
        public GuruService(IGuruRepository guruRepository)
        {
            _GuruRepository = guruRepository;
        }

        public Guru CreateGuru(Guru guru)
        {
            _GuruRepository.CreateGuru(guru);
            return guru;
        }

        public void DeleteGuru(int id)
        {
            _GuruRepository.DeleteGuru(id);
        }

        public List<Guru> GetAllGuru()
        {
            return _GuruRepository.GetAllGuru();
        }

        public Guru GetGuruById(int id)
        {
            return _GuruRepository.GetGuruById(id);
        }

        public Guru UpdateGuru(int id, Guru guru)
        {
            var exGuru = _GuruRepository.GetGuruById(id);
            if (exGuru == null)
            {
                return null;
            }
            exGuru.Nama = guru.Nama;
            exGuru.Alamat = guru.Alamat;
            exGuru.Telp = guru.Telp;
            _GuruRepository.UpdateGuru(exGuru);
            return exGuru;
        }
    }
}
