using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartemen
{
    abstract class Manusia
    {
        protected string nama { set; get; }
        protected string notelp { set; get; }
        protected enum JK
        {
            Pria = 1,
            Wanita = 2
        }
        protected JK jk { set; get; }
        public Manusia()
        {
            nama = "";
            jk = (JK)1;
            notelp = "";
        }
    }
}
