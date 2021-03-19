using System;

namespace soma_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Quantas colunas vai ter cada matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] A = new int[m, n];
            int[,] B = new int[m, n];
            int[,] C = new int[m, n];

            Console.WriteLine("Digite os valores da matriz A:");
            for(i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    A[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for(i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("MATRIZ SOMA:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
