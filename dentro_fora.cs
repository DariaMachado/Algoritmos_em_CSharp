﻿using System;

namespace dentro_fora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, x, dentro = 0, fora = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if(x < 10 || x > 20)
                {
                    fora++;
                }
                else
                {
                    dentro++;
                }
            }

            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");
        }
    }
}
