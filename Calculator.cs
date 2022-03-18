using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static int Penambahan(int a, int b)
        { return a + b; }
        static int Pengurangan(int a, int b)
        { return a - b; }
        static int Perkalian(int a, int b)
        { return a * b; }
        static int Pembagian(int a, int b)
        { return a / b; }

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.Title = "Aplikasi Calculator";
            Console.Write("Pilih Menu Calculator: \n");
            Console.Write("1. Penambahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");
            Console.Write("\nInput nomor menu [1/2/3/4] : ");
            string pilihan = Console.ReadLine().ToLower();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case "2":
                    Console.Write("Inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;
                case "3":
                    Console.Write("Inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;
                case "4":
                    Console.Write("Inputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;
                default:
                    Console.Write("Maaf, menu yang Anda Pilih tidak tersedia");
                    break;
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}