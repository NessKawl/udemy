// See https://aka.ms/new-console-template for more information

using System;

namespace ex2NumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número inteiro:");

            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("O número " + n1 + " é PAR");
            } else
            {
                Console.WriteLine("O número " + n1 + " é ÍMPAR");
            }

        }
    }
}