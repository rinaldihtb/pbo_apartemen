using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartemen
{
    class Pembeli : Manusia
    {
        public enum Status 
        {
            Beli = 1,
            Kontrak = 2
        }
        public int id { set; get; }
        public string nik { set; get; }
        public int jumlahPenghuni { set; get; }
        public TimeSpan jangkaWaktu { set; get; }
        public DateTime tgl { set; get; }
        public Status status { set; get; }

        public Pembeli()
            :base()
        {
            this.id = 0;
            this.nama = "";
            this.notelp = "";
            this.nik = "";
            this.jumlahPenghuni = 0;
            this.jangkaWaktu = new TimeSpan();
            this.tgl = new DateTime();
            this.jk = (JK)1;
            this.status = new Status();
        }
    }
}
