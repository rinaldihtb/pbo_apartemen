using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartemen
{
    class Manajemen
    {
        public string kode { set; get; }
        public string nama { set; get; }
        public int jumlahPendapatan { set; get; }

        public Manajemen()
        {
            this.kode = "";
            this.nama = "";
            this.jumlahPendapatan = 0;
        }
    }
}
