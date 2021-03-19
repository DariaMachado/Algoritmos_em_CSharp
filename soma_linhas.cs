using System;
using System.Globalization;

namespace soma_linhas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int m, n, i, j;
            double somaLinha;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de colunas da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[m, n];
            double[] vet = new double[m];

            for(i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os elementos da " + (i + 1) + "a. linha:");
                for(j = 0; j < n; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            for(i = 0; i < m; i++)
            {
                somaLinha = 0;
                for(j = 0; j < n; j++)
                {
                    somaLinha = somaLinha + mat[i, j];
                }
                vet[i] = somaLinha;
            }

            Console.WriteLine("VETOR GERADO:");
            for(i = 0; i < m; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CI));
            }

        }
    }
}
