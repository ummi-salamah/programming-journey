using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_fungsikonversisuhu
{
    internal class Program
    {
        static double KonversiSuhu(double C)
        {
            double F = (C * 9 / 5) + 32;
            return F;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===Program Konversi Suhu Celcius ke Fahrenheit===");

            //Meminta Input dari Pengguna
            Console.Write("Masukkan suhu dalam Celcius: ");
            double suhuC = double.Parse(Console.ReadLine());

            //Memanggil fungsi KonversiSuhu dan menampilkan hasilnya
            double suhuF = KonversiSuhu(suhuC);
            Console.Write("Suhu Dalam Fahrenhait: " + suhuF);
        }
    }
}
