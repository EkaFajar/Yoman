
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MySiswa
    {
        static public int UangPendaftaran = 200000;

        private int TotalBayar = 0;

        public void TambahTotalBayar(int jumlahUang)
        {
            TotalBayar = TotalBayar + jumlahUang;
            TotalBayar += jumlahUang;

        }
        public int GetTotalBayar()
        {
            return TotalBayar;
        }
    }
}
