using System;
using System.Globalization;

namespace aprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i;
            double media;

            Console.Write("Quantos alunos serao digitados? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for( i = 0; i < n; i++)
            {
                Console.WriteLine("Digite nome, primeira e segunda nota do " + (i + 1) + "o aluno:");
                nome[i] = Console.ReadLine();
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                nota2[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("Alunos aprovados:");

            for(i = 0; i < n; i++)
            {
                media = (nota1[i] + nota2[i]) / 2.0;

                if (media >= 6.0)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
