using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartemen
{
    class Pegawai : Manusia
    {
        public string id_pegawai { set; get; }
        public string alamat { set; get; }
        public Pegawai()
            :base()
        {
            this.nama = "";
            this.jk = (JK)1;
            this.alamat = "";
            this.notelp = "";
        }
    }
}
