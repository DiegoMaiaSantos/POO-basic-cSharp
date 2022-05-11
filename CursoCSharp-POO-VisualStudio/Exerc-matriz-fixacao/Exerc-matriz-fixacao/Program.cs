using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valorLinhaColuna = Console.ReadLine().Split(' ');
            int linha = int.Parse(valorLinhaColuna[0]);
            int coluna = int.Parse(valorLinhaColuna[1]);


            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine(matriz[0, 1]);

            Console.WriteLine("Position: 0, 1");
            Console.WriteLine("Left: " + matriz[0, 0]);
            Console.WriteLine("Right: " + matriz[0, 2]);
            Console.WriteLine("Down: " + matriz[1, 1]);
            Console.WriteLine("Position: 1, 3");
            Console.WriteLine("Left: " + matriz[1, 2]);
            Console.WriteLine("Up: " + matriz[0, 3]);
            Console.WriteLine("Down: " + matriz[2, 3]);
        }
    }
}