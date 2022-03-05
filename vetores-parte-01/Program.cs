using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());     

            double[] vect = new double[n]; 

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[i];
            } 

            double media = soma / n;   

            Console.WriteLine("A média das alturas é: " + ((float)media).ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}