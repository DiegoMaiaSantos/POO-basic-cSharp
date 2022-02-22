using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== CADASTRO E CONTROLE DE PRODUTOS ==");
            Console.WriteLine("=====================================");
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço R$: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto 
            {
                Nome = "TV", 
                Preco = 900.00, 
                Quantidade = 5
            };

            Console.WriteLine("=====================================");
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("=====================================");
            Console.Write("Digite o número de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("=====================================");
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("=====================================");
            Console.Write("Digite o número de produtos a serem removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("=====================================");
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}