using System;

namespace par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, numero;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                if(numero == 0)
                {
                    Console.WriteLine("NULO");
                }
                else if(numero % 2 != 0 && numero > 0)
                {
                    Console.WriteLine("IMPAR POSITIVO");
                }
                else if(numero % 2 != 0 && numero < 0)
                {
                    Console.WriteLine("IMPAR NEGATIVO");
                }
                else if(numero % 2 == 0 && numero > 0)
                {
                    Console.WriteLine("PAR POSITIVO");
                }
                else if (numero % 2 == 0 && numero < 0)
                {
                    Console.WriteLine("PAR NEGATIVO");
                }
            }
        }
    }
}
