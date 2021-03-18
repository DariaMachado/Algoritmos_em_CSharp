using System;

namespace soma_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.Write("Quantos valores vai ter cada vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];

            Console.WriteLine("Digite os valores do vetor A:");
            for(i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B:");
            for (i = 0; i < n; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }

            for(i = 0; i < n; i++)
            {
                C[i] = A[i] + B[i];
            }

            Console.WriteLine("VETOR RESULTANTE:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(C[i]);
            }
        }
    }
}
