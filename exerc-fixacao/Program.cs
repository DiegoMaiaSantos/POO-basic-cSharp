using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria dadosCliente;

            Console.WriteLine("==========================================");
            Console.WriteLine("======= PROGRAMA CONTA BANCARIA ==========");
            Console.WriteLine("==========================================");
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S')
            {
                Console.Write("Digite o valor de depósito inicial R$: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dadosCliente = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                dadosCliente = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(dadosCliente);
            Console.WriteLine("==========================================");
        }
    }
}