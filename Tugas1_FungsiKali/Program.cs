using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_FungsiKali
{
    internal class Program
    {
        // Fungsi Kali: menerima tiga bilam
        static void Kali(int a, int b, int c)
        {
            int hasil = a * b * c;
            Console.WriteLine("Hasil perkalian: " + hasil);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===PROGRAM PERKALIAN TIGA===");

            //Meminta input dari pengguna
            Console.Write("Masukkan bilangan pertama: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan kedua: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan ketiga: ");
            int z = int.Parse(Console.ReadLine());

            //Memanggil fungsi kali
            Kali(x, y, z);
        }
    }
}
