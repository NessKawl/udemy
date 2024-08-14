// See https://aka.ms/new-console-template for more information
using System;

namespace ex3Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Digite dois números inteiros:");

            string[] valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]); 
            b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine(a + " e "+ b +" são múltiplos");
            }
            else
            {
                Console.WriteLine(a + " e " + b + " não são múltiplos");
            }

        }
    }
}