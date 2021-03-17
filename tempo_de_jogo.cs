using System;

namespace tempo_de_jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int hInicial, hFinal, duracao;

            Console.Write("Hora inicial: ");
            hInicial = int.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            hFinal = int.Parse(Console.ReadLine());

            if(hInicial >= hFinal)
            {
                duracao = 24 - hInicial + hFinal;
            }
            else
            {
                duracao = hFinal - hInicial;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
