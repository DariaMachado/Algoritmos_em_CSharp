using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, fatorial = 1;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            for(i = n; i > 0; i--)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("FATORIAL = " + fatorial);
        }
    }
}
