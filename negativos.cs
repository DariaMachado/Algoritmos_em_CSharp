using System;

namespace negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS:");
            for(i = 0; i < n; i++)
            {
                if(vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }

        }
    }
}
