using System;
using System.Globalization;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, c, areaQ, areaTri, areaTra;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(), CI);

            areaQ = Math.Pow(a, 2);
            areaTri = (a * b) / 2.0;
            areaTra = (a + b) * c / 2.0;

            Console.WriteLine("AREA DO QUADRADO = " + areaQ.ToString("F4", CI));
            Console.WriteLine("AREA DO TRIANGULO = " + areaTri.ToString("F4", CI));
            Console.WriteLine("AREA DO TRAPEZIO = " + areaTra.ToString("F4", CI));
        }
    }
}
