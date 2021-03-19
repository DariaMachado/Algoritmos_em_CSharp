using System;

namespace acima_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, soma = 0;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if(j > i)
                    {
                        soma = soma + mat[i, j];
                    }
                }
            }

            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
        }
    }
}
