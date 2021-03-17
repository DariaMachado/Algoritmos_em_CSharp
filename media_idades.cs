using System;
using System.Globalization;

namespace media_idades
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade, soma = 0, contIdade = 0;
            double media;

            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            if(idade < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                while(idade >= 0)
                {
                    soma = soma + idade;
                    contIdade++;
                    idade = int.Parse(Console.ReadLine());
                }

                media = (double) soma / contIdade;
                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }
        }
    }
}
