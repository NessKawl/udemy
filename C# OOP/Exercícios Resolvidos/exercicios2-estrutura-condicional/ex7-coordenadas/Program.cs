// See https://aka.ms/new-console-template for more information

using System;

namespace ex7Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Digite os valores de X e Y:");

            string[] valores = Console.ReadLine().Split(' ');

            x = double.Parse(valores[0]);
            y = double.Parse(valores[1]);  

            if (x < 0 && y > 0 )
            {
                Console.WriteLine("Q2");
            } else if (x > 0 && y > 0) 
            {
                Console.WriteLine("Q1");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            } else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
        }
    }
}