// See https://aka.ms/new-console-template for more information

using System;

namespace ex3Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d, calculo;

            Console.WriteLine("Digite um número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite mais um número:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            d = int.Parse(Console.ReadLine());

            calculo = (a*b) - (c*d);

            Console.WriteLine("DIFERENCA = " + calculo);
        }
    }
}