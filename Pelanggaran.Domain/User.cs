using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelanggaran.Domain
{
    public class User
    {
        public int id {  get; set; }
        public string nama { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
