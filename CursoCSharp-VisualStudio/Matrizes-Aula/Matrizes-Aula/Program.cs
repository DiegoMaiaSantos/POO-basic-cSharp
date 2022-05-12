using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizTeste = new double[2, 3];

            Console.WriteLine(matrizTeste.Length);

            Console.WriteLine(matrizTeste.Rank);

            Console.WriteLine(matrizTeste.GetLength(0));

            Console.WriteLine(matrizTeste.GetLength(1));

        }
    }
}