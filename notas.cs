using System;
using System.Globalization;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double nota1, nota2, notaF;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            notaF = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + notaF.ToString("F1", CI));

            if(notaF < 60)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
