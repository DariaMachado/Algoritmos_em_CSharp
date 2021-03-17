using System;

namespace soma_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, maior, i, soma = 0;

            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                maior = x;
                x = y;
                y = maior;
            }

            for(i = x + 1; i < y; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);

        }
    }
}
