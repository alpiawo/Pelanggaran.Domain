using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelanggaran.Domain
{
    public class Peraturan
    {
        public int Id { get; set; }
        public string? Nama { get; set; }
        public string? Deskripsi { get; set; }
        public int? Poin { get; set; }
    }
}
