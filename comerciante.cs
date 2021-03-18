using System;
using System.Globalization;

namespace comerciante
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int i, n, abaixo = 0, entre = 0, acima = 0;
            double totalC = 0, totalV = 0, totalL;

            Console.Write("Serao digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            string[] produto = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];
            double[] percentual = new double[n];

            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Produto " + (i + 1) + ":");
                Console.Write("Nome: ");
                produto[i] = Console.ReadLine();

                Console.Write("Preco de compra: ");
                compra[i] = double.Parse(Console.ReadLine(), CI);

                Console.Write("Preco de venda: ");
                venda[i] = double.Parse(Console.ReadLine(), CI);
            }

            for(i = 0; i < n; i++)
            {
                percentual[i] = (venda[i] - compra[i]) / compra[i] * 100.0;
            }

            for(i = 0; i < n; i++)
            {
                if(percentual[i] < 10.0)
                {
                    abaixo++;
                }
                else if(percentual[i] <= 20.0)
                {
                    entre++;
                }
                else
                {
                    acima++;
                }
            }

            for(i = 0; i < n; i++)
            {
                totalC = totalC + compra[i];
                totalV = totalV + venda[i];
            }

            totalL = totalV - totalC;

            Console.WriteLine("\nRELATORIO:");
            Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre);
            Console.WriteLine("Lucro acima de 20%: " + acima);
            Console.WriteLine("Valor total de compra: " + totalC.ToString("F2", CI));
            Console.WriteLine("Valor total de venda: " + totalV.ToString("F2", CI));
            Console.WriteLine("Lucro total: " + totalL.ToString("F2", CI));
        }
    }
}
