using System;
using System.Globalization;

namespace media_ponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i;
            double valor1, valor2, valor3, mediaP;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Digite tres numeros:");
                valor1 = double.Parse(Console.ReadLine(), CI);
                valor2 = double.Parse(Console.ReadLine(), CI);
                valor3 = double.Parse(Console.ReadLine(), CI);

                mediaP = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;
                Console.WriteLine("MEDIA = " + mediaP.ToString("F1", CI));
            }

        }
    }
}
