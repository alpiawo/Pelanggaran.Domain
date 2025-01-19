using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelanggaran.Domain
{
    public class Siswa
    {
        public int Id { get; set; }
        public string? Nama { get; set; }
        public string? Nis { get; set; }
        public string? Alamat { get; set; }
        public int KelasId { get; set; }
        public int PelanggaranId { get; set; }
        public int GuruPencatatId { get; set; }
    }
}
