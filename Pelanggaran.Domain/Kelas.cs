using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelanggaran.Domain
{
    public class Kelas
    {
        public int Id { get; set; }
        public string? Nama { get; set; }
        public int? IdJurusan { get; set; }
    }
}
