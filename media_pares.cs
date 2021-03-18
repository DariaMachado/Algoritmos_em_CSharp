using System;
using System.Globalization;

namespace media_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, somaPares = 0, contPares = 0;
            double media;

            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for(i = 0; i < n; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    somaPares = somaPares + vet[i];
                    contPares++;
                }
            }

            if(contPares == 0)
            {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
            else
            {
                media = (double) somaPares / contPares;
                Console.WriteLine("MEDIA DOS PARES = " + media.ToString("F1", CI));
            }
        }
    }
}
