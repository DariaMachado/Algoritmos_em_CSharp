using System;

namespace numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, contPares = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNUMEROS PARES:");

            for(i = 0; i < n; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    contPares++;
                    Console.Write(vet[i] + " ");
                }
            }

            Console.WriteLine("\n\nQUANTIDADE DE PARES = " + contPares);
        }
    }
}
