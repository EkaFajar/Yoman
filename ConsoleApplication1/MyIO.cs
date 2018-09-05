using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class MyIO
    {
        static public void BuatKotak(int kiri, int atas, int kanan, int bawah, ConsoleColor warnateks, ConsoleColor warnabackground)
        {
            Console.SetCursorPosition(kiri, atas);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackground;
            Console.Write("┌");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Thread.Sleep(200);

            for (int i = kiri + 1; i <= kanan - 1; i++)
            {
                Console.SetCursorPosition(i, atas);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackground;
                Console.Write("─");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;

                //System.Threading.Tread.Sleep(50);
            }

            Console.SetCursorPosition(kanan, atas);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackground;
            Console.Write("┐");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Tread.Sleep(50);

            for (int i = atas + 1; i <= bawah - 1; i++)
            {
                Console.SetCursorPosition(kanan, i);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackground;
                Console.Write("│");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;

                //System.Threading.Tread.Sleep(50);
            }

            Console.SetCursorPosition(kanan, bawah);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackground;
            Console.Write("┘");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Tread.Sleep(50);


            for (int i = kanan - 1; i >= kiri + 1; i--)
            {
                Console.SetCursorPosition(i, bawah);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackground;
                Console.Write("─");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                //System.Threading.Tread.Sleep(50);


            }

            Console.SetCursorPosition(kiri, bawah);
            Console.ForegroundColor = warnateks;
            Console.BackgroundColor = warnabackground;
            Console.Write("└");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            //System.Threading.Tread.Sleep(50);

            for (int i = bawah - 1; i >= atas + 1; i--)
            {
                Console.SetCursorPosition(kiri, i);
                Console.ForegroundColor = warnateks;
                Console.BackgroundColor = warnabackground;
                Console.Write("│");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                //Thread.Sleep(300);

            }


        }//tutup kotak
        static public void Tulis(int kiri, int atas, string teks)
        {
            Console.SetCursorPosition(kiri, atas);
            Console.Write(teks);

        }
        static public void TulisWarna(int kiri, int atas, string teks, ConsoleColor warnaTeks, ConsoleColor warnabackground)
        {
            Console.SetCursorPosition(kiri, atas);
            Console.ForegroundColor = warnaTeks;
            Console.BackgroundColor = warnabackground;
            Console.Write(teks);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        }
        static public string Input(int kiri, int atas)
        {
            string hasil;
            do
            {
                Console.SetCursorPosition(kiri, atas);
                hasil = Console.ReadLine();
            } while (hasil == "");
            return hasil;
        }
    }
}
