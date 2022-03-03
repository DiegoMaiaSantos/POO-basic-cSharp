using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("================ CONTA BANCARIA ================");
            Console.WriteLine("================================================");
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S')
            {
                Console.Write("Digite o valor do depósito inicial R$: ")
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                {

                }
            }
        }
    }
}