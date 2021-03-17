using System;
using System.Globalization;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            char escala;
            double tempC, tempF;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            escala = char.Parse(Console.ReadLine());

            if(escala == 'F')
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                tempF = double.Parse(Console.ReadLine(), CI);

                tempC = 5.0 / 9.0 * (tempF - 32);
                Console.WriteLine("Temperatura equivalente em Celsius: " + tempC.ToString("F2", CI));
            }
            else if(escala == 'C')
            {
                Console.Write("Digite a temperatura em Celsius: ");
                tempC = double.Parse(Console.ReadLine(), CI);

                tempF = tempC * 9.0 / 5.0 + 32;
                Console.WriteLine("Temperatura equivalente em Fahrenheit: " + tempF.ToString("F2", CI));
            }
        }
    }
}
