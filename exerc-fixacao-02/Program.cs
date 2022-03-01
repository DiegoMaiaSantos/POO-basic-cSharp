using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria dadosUsuario;

            Console.WriteLine("==================================================");
            Console.WriteLine("================= CONTA BANCARIA =================");
            Console.WriteLine("==================================================");
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor de depósito inicial R$: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dadosUsuario = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                dadosUsuario = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(dadosUsuario);
            Console.WriteLine("==================================================");
        }
    }
}