using System;
using System.Globalization;

namespace matriz_geral
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, j, linha, coluna;
            double somaP = 0;

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if(mat[i,j] > 0)
                    {
                        somaP = somaP + mat[i, j];
                    }
                }
            }

            Console.WriteLine("\nSOMA DOS POSITIVOS: " + somaP.ToString("F1", CI));

            Console.Write("\nEscolha uma linha: ");
            linha = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");

            for(j = 0; j < n; j++)
            {
                Console.Write(mat[linha,j].ToString("F1", CI) + " ");
            }

            Console.Write("\n\nEscolha uma coluna: ");
            coluna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(mat[i, coluna].ToString("F1", CI) + " ");
            }

            Console.Write("\n\nDIAGONAL PRINCIPAL:");
            for(i = 0; i < n; i++)
            {
                Console.Write(mat[i,i].ToString("F1", CI) + " ");
            }

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        mat[i, j] = Math.Pow(mat[i, j], 2);
                    }
                }
            }

            Console.WriteLine("\n\nMATRIZ ALTERADA:");
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write(mat[i,j].ToString("F1", CI) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
