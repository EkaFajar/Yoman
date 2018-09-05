using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyIO.Tulis(20, 8, MySiswa.UangPendaftaran.ToString());

            //MySiswa Ahmad = new MySiswa ();
            //MySiswa Udin  = new MySiswa ();

            //Ahmad.TambahTotalBayar(100000);
            //Udin.TambahTotalBayar(200000);
            //Udin.TambahTotalBayar(50000);

            //MyIO.Tulis(20, 9, Udin.GetTotalBayar().ToString());


            MyIO.BuatKotak(5, 1, 115, 5, ConsoleColor.Blue, ConsoleColor.Black);
            MyIO.BuatKotak(5, 6, 29, 25, ConsoleColor.Blue, ConsoleColor.Black);
            MyIO.BuatKotak(30,6, 115, 25, ConsoleColor.Blue, ConsoleColor.Black);
            
           

            
            string judul = ">>Data Mahasiswa<<";
            MyIO.Tulis((120 - judul.Length) / 2, 2, judul);

            string subJudul = ">>TH 2018/2019<<";
            MyIO.Tulis((120 - subJudul.Length) / 2, 3, subJudul);

            MyIO.TulisWarna(6, 7, " >> MENU << ", ConsoleColor.Blue, ConsoleColor.Black);

            
            string[] menu = new string[7];
            menu[0] = "   SISWA      "; 
            menu[1] = "   DOSEN      ";
            menu[2] = "   MATKUL     ";
            menu[3] = "   NILAI      ";
            menu[4] = "   ABSEN      ";
            menu[5] = "   BAYAR      ";
            menu[6] = "   MINGGAT    ";

            for (int i = 0; i < 7; i++)
            {
                
                MyIO.Tulis(6, 8 + i, menu[i]);
            }

            int pilihan = 0; 
            
            MyIO.TulisWarna(6, 8, menu[pilihan], ConsoleColor.Black, ConsoleColor.Blue);

            
            ConsoleKeyInfo tombol;
            do
            {
                
                tombol = Console.ReadKey(true);
                
                if (tombol.Key == ConsoleKey.DownArrow)
                {
                    
                    MyIO.TulisWarna(6, 8 + pilihan, menu[pilihan], ConsoleColor.White, ConsoleColor.Black);
                    pilihan++; 
                    
                    MyIO.TulisWarna(6, 8 + pilihan, menu[pilihan], ConsoleColor.Black, ConsoleColor.Blue);
                }
                
            } while (tombol.Key != ConsoleKey.Enter);


            MyIO.Tulis(35, 10, "Nama Siswa        : ");
            MyIO.Tulis(35, 12, "NIS               : ");
            MyIO.Tulis(35, 14, "Kelas             : ");
            MyIO.Tulis(35, 16, "TTL               : ");
            MyIO.Tulis(35, 18, "Alamat            : ");

            string nama = MyIO.Input(55, 10);
            string nis = MyIO.Input(55, 12);
            string kelas = MyIO.Input(55, 14);
            string ttl = MyIO.Input(55, 16);
            string alamat = MyIO.Input(55, 18);

            Console.ReadKey();

        }

         
    }
}
