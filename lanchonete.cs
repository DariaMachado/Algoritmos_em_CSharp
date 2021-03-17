using System;
using System.Globalization;

namespace lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int codigo, qtd;
            double valor = 0;

            Console.Write("Codigo do produto comprado ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                valor = qtd * 5.00;
            }
            else if(codigo == 2)
            {
                valor = qtd * 3.50;
            }
            else if(codigo == 3)
            {
                valor = qtd * 4.80;
            }
            else if(codigo == 4)
            {
                valor = qtd * 8.90;
            }
            else if(codigo == 5)
            {
                valor = qtd * 7.32;
            }

            Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", CI));
        }
    }
}
