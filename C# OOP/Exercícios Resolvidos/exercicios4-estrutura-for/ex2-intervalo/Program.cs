// See https://aka.ms/new-console-template for more information

using System;

namespace ex2Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int numIn = 0;
            int numOut = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());  

                if (x >= 10 && x <= 20)
                {
                    numIn += 1;
                } else
                {
                    numOut += 1;
                }

            }

            Console.WriteLine(numIn + " in");
            Console.WriteLine(numOut + " out");
        }
    }
}
