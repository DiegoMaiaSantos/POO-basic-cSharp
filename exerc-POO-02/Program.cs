using System;
using System.Globalization;

namespace Course 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Funcionario fun = new Funcionario();

            Console.WriteLine("========= PLANILHA DE DADOS =========");            
            Console.WriteLine("====================================="); 
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário bruto R$: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto R$: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("====================================="); 
            Console.WriteLine("Funcionário: " + fun);

            Console.WriteLine("====================================="); 
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porce = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(porce);

            Console.WriteLine("====================================="); 
            Console.WriteLine("Dados atualizados: " + fun);

            Console.WriteLine("====================================="); 
        }
    }
}