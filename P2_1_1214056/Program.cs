using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator Rachma");
            Console.Write("Input Nilai Pertama: ");
            var angka1 = int.Parse(Console.ReadLine());
            Console.Write("Input Nilai Kedua: ");
            var angka2 = int.Parse(Console.ReadLine());

            double penjumlahan = angka1 + angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penjumlahan);
            double pengurangan = angka1 - angka2;
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, pengurangan);
            double perkalian = angka1 * angka2;
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);
            double pembagian = angka1 / angka2;
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);

        }
    }
}
