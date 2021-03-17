using System;
using System.Globalization;

namespace experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, qtd, coelho = 0, rato = 0, sapo = 0, total;
            char tipo;
            double perC, perR, perS;

            Console.Write("Quantos casos de teste serao digitados? ");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i < n; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                qtd = int.Parse(Console.ReadLine());

                Console.Write("Tipo de cobaia: ");
                tipo = char.Parse(Console.ReadLine());

                if(tipo == 'C')
                {
                    coelho = coelho + qtd;
                }
                else if(tipo == 'R')
                {
                    rato = rato + qtd;
                }
                else if(tipo == 'S')
                {
                    sapo = sapo + qtd;
                }
            }

            total = coelho + rato + sapo;
            perC = coelho * 100.0 / total;
            perR = rato * 100.0 / total;
            perS = sapo * 100.0 / total;

            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL:");
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + perC.ToString("F2", CI));
            Console.WriteLine("Percentual de ratos: " + perR.ToString("F2", CI));
            Console.WriteLine("Percentual de sapos: " + perS.ToString("F2", CI));

        }
    }
}
