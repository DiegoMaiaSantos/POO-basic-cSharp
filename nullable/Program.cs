using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // Vai pegar o valor atribuido ou 
            Console.WriteLine(y.GetValueOrDefault()); // o valor padrão.

            Console.WriteLine(x.HasValue); // Para saber se tem algum valor.
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null.");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null.");
            }
        }
    }
}