// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace ex4Divisao
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            Console.WriteLine("Digite um número inteiro como limite: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite " + n + " pares de números inteiros: ");
            
            for (int i = 0; i <n; i++)
            {
                string[] par = Console.ReadLine().Split(' ');
                a = int.Parse(par[0]);
                b = int.Parse(par[1]);
                
                if (b == 0)
                {
                    Console.WriteLine("Divisão impossível!");
                } else
                {
                    double divisao = (double)a / b;

                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}