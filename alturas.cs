using System;
using System.Globalization;

namespace alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, contMenores = 0;
            double somaAlt = 0, mediaAlt, porcentagem;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);
            }

            for(i = 0; i < n; i++)
            {
                somaAlt = somaAlt + altura[i];
            }

            mediaAlt = somaAlt / n;

            Console.WriteLine();
            Console.WriteLine("Altura média: " + mediaAlt.ToString("F2", CI));

            for(i = 0; i < n; i++)
            {
                if(idade[i] < 16)
                {
                    contMenores++;
                }
            }

            porcentagem = contMenores * 100.0 / n;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CI) + "%");

            for (i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
