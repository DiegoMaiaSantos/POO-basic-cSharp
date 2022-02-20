using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário(a):");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário R$: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("================================");

            Console.WriteLine("Dados do segundo funcionário(a):");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário R$: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("==================================================");

            double salarioMedia = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio dos funcionários(as) R$: " + salarioMedia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("==================================================");

        }
    }
}