using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, multiplicacao;

            Console.Write("Deseja a tabuada para qual valor?  ");
            n = int.Parse(Console.ReadLine());

            for(i = 1; i <=10; i++)
            {
                multiplicacao = n * i;
                Console.WriteLine(n + " X " + i + " = " + multiplicacao);
            }
        }
    }
}
