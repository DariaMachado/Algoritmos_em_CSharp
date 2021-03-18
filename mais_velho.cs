using System;

namespace mais_velho
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, maisVelho, posicao;

            Console.Write("Quantas pessoas voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];

            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            maisVelho = idade[0];
            posicao = 0;

            for(i = 0; i < n; i++)
            {
                if(idade[i] > maisVelho)
                {
                    maisVelho = idade[i];
                    posicao = i;
                }
            }

            Console.WriteLine("PESSOA MAIS VELHA: " + nome[posicao]);
        }
    }
}
