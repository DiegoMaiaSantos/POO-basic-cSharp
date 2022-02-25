using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        // Sempre que usar private as variáveis devem ser iniciadas com _. Exemplo: _nome.
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

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

        public double Preco
        {
            get { return _preco; }
        }

        public int quantidade
        {
            get { return _quantidade; }
        }
    }
    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
        _quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        _quantidade -= quantidade;
    }

    public override string ToString()
    {
        return _nome + ", R$: " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidade(s), total R$: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}
