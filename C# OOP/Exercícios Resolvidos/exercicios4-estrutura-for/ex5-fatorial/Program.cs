// See https://aka.ms/new-console-template for more information

using System;

namespace ex5Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número para ver seu fatorial: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
