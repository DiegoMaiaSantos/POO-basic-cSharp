using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("== CADASTRO E CONTRO DE PRODUTOS ==");
            Console.WriteLine("===================================");
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço R$: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("===================================");
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("===================================");
            Console.Write("Digite o número de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("===================================");
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("===================================");
            Console.Write("Digite o número de produtos a serem removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("===================================");
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}