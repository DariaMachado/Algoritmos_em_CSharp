using System;

namespace negativos_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de colunas da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for(i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for(i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }
        }
    }
}
