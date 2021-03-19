using System;

namespace cada_linha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, maior;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int[] maiorLinha = new int[n];

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for(i = 0; i < n; i++)
            {
                maior = mat[i, 0];
                for(j = 0; j < n; j++)
                {
                    if(mat[i,j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                maiorLinha[i] = maior;
            }

            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA:");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(maiorLinha[i]);
            }            
        }
    }
}
