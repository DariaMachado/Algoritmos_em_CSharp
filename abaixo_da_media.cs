using System;
using System.Globalization;

namespace abaixo_da_media
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i;
            double somaVetor = 0, mediaVetor;

            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            for(i = 0; i < n; i++)
            {
                somaVetor = somaVetor + vet[i];
            }

            mediaVetor = somaVetor / n;

            Console.WriteLine("\nMEDIA DO VETOR = " + mediaVetor.ToString("F3", CI));
            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");

            for(i = 0; i < n; i++)
            {
                if(vet[i] < mediaVetor)
                {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }
        }
    }
}
