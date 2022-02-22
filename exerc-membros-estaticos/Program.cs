using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.Write("Qual é a cotação do dólar? R$: "); 
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? R$: "); 
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversoDeMoeda.DolarParaReal(quantidade, cotacao);

            Console.WriteLine("Valor a ser pago em reais R$: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("=========================================");
        }
    }
}