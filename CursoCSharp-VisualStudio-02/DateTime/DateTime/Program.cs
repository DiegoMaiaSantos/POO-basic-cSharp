using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("================ Parte 01 ================");
            Console.WriteLine();

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2022, 05, 11);
            DateTime d3 = new DateTime(2022, 05, 11, 13, 13, 13);
            DateTime d4 = new DateTime(2022, 05, 11, 13, 13, 13, 500);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            Console.WriteLine();
            Console.WriteLine("================ Parte 02 ================");
            Console.WriteLine();

            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2001-09-16 13:21:58");

            DateTime d10 = DateTime.Parse("11/05/2022");
            DateTime d11 = DateTime.Parse("16/11/2022 08:00:01");

            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);

            Console.WriteLine();
            Console.WriteLine("================ Parte 03 ================");
            Console.WriteLine();

            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d12);
            Console.WriteLine(d13);
        }
    }
}