using System;
using System.Globalization;

namespace maior_posicao
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, posicao;
            double maior;

            Console.Write("Quanto numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            maior = vet[0];
            posicao = 0;
            for(i = 1; i < n; i++)
            {
                if(vet[i] > maior)
                {
                    maior = vet[i];
                    posicao = i;
                }
            }

            Console.WriteLine("\nMAIOR VALOR = " + maior.ToString("F1", CI));
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posicao);
        }
    }
}
