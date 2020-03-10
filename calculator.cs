using System;

namespace kalkutator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program Kalkulator\r");
            Console.WriteLine("------------------\n");

            Console.WriteLine("Masukan angka pertama : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan angka kedua :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Pilih operasi : ");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Pembagian");
            Console.WriteLine("4. Perkalian");

            Console.WriteLine();

            Console.Write("Masukan pilihan anda : ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Hasil dari : {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"Hasil dari : {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":

                    Console.WriteLine($"Hasil dari : {num1} / {num2} = " + (num1 / num2));
                    break;
                case "4":

                    Console.WriteLine($"Hasil dari : {num1} * {num2} = " + (num1 * num2));
                    break;
            }
            Console.WriteLine();
            Console.Write("Tekan sembarang");
            Console.ReadKey();
        }
    }
}