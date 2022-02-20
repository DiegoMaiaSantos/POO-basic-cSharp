using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alu = new Aluno();

            Console.WriteLine("====== NOTAS ANUAIS DOS ALUNOS ======");
            Console.WriteLine("=====================================");
            Console.Write("Nome do aluno: ");
            alu.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            alu.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alu.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alu.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("=====================================");
            Console.WriteLine("Nota final: " + alu.Media().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("=====================================");
            if (alu.Aprovado())
            {
                Console.WriteLine("APROVADO");
                Console.WriteLine("=====================================");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + alu.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("=====================================");
            }
        }
    }
}