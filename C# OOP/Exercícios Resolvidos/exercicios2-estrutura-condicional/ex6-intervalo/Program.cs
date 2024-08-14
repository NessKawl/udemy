// See https://aka.ms/new-console-template for more information

using System;

namespace ex6Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número qualquer:");

            double n = double.Parse(Console.ReadLine());

            if (n >= 0 && n <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            } else if (n >= 25 && n <= 0)
            {
                Console.WriteLine("Intervalo [25, 50]");
            } else if (n >= 50 && n <= 75)
            {
                Console.WriteLine("Intervalo [50, 75]");
            } else if (n >= 75 && n <= 100)
            {
                Console.WriteLine("Intervalo [75, 100]");
            } else
            {
                Console.WriteLine( "FORA DE INTERVALO!");
            }
        }
    }
}