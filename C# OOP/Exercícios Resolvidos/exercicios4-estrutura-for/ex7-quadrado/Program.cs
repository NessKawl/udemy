// See https://aka.ms/new-console-template for more information

using System;

namespace ex7Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;

                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
    
        }
    }
}