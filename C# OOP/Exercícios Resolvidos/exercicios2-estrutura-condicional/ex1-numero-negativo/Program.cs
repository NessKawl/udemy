// See https://aka.ms/new-console-template for more information

using System;

namespace ex1NumeroNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine(n1 + " É NEGATIVO");
            } else
            {
                Console.WriteLine(n1 + " É POSITIVO");
            }
        }
    }
}