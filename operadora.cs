using System;
using System.Globalization;

namespace operadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int minutos;
            double valor;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            valor = 50.00;

            if(minutos > 100)
            {
                valor = valor + 2.0 * (minutos - 100);
            }

            Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", CI));
        }
    }
}
