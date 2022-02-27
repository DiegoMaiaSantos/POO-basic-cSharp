using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria dadosCliente = new ContaBancaria();

            Console.WriteLine("======= PROGRAMA CONTA BANCARIA ==========");
            Console.WriteLine("==========================================");
            Console.Write("Digite o número da conta: ");
            dadosCliente.Numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            dadosCliente.Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            dadosCliente.Escolha() = Console.ReadLine();            
            // Aqui vai ter a escolha, que vai ser contruida com o if.            
        }
    }
}