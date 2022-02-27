using System;
using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set;}
        public double Saldo { get; set;}

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia - 5.0;
        }

        public char Escolha(char escolha)
        {
            if (escolha == 's')
            {
                Console.Write("Digite o valor de depósito inicia R$: ");
                dadosCliente.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}