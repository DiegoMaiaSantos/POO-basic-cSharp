using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== CADASTRO E CONTRO DE PRODUTOS ==");
            Console.WriteLine("===================================");
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço R$: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

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