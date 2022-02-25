using System;
using System.Globalization;

namespace Course
{
    class Produto
    {        
        // Ordem sugerida para implementação de membros e classes:

        // Primeiro Atributo privativo:
        private string _nome;

        // Depois as propriedades autoimplementadas:
        public double Preco { get; private set; }
        public int Quantidade { get; set; }        

        // Depois os construtores:
        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Depois Propriedades customizadas:
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // E por ultimo os outros métodos:
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", R$: " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidade(s), total R$: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}