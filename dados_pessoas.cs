using System;
using System.Globalization;

namespace dados_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, contF = 0, contM = 0;
            double maiorAlt, menorAlt, mediaAlt, somaAlt = 0;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            double[] altura = new double[n];
            char[] genero = new char[n];

            for(i = 0; i < n; i++)
            {
                Console.Write("Altura da " + (i + 1) + "a pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);

                Console.Write("Genero da " + (i + 1) + "a pessoa: ");
                genero[i] = char.Parse(Console.ReadLine());
            }

            menorAlt = altura[0];
            maiorAlt = altura[0];
            for(i = 0; i < n; i++)
            {
                if(altura[i] < menorAlt)
                {
                    menorAlt = altura[i];
                }

                if(altura[i] > maiorAlt)
                {
                    maiorAlt = altura[i];
                }
            }

            for(i = 0; i < n; i++)
            {
                if(genero[i] == 'F')
                {
                    somaAlt = somaAlt + altura[i];
                    contF++;
                }
                else
                {
                    contM++;
                }
            }

            mediaAlt = somaAlt / contF;

            Console.WriteLine("Menor altura = " + menorAlt.ToString("F2", CI));
            Console.WriteLine("Maior altura = " + maiorAlt.ToString("F2", CI));
            Console.WriteLine("Media das alturas das mulheres = " + mediaAlt.ToString("F2", CI));
            Console.WriteLine("Numero de homens = " + contM);
        }
    }
}
