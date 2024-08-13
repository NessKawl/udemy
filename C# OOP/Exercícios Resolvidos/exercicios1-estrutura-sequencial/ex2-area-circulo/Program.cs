// See https://aka.ms/new-console-template for more information
using System;

namespace ex2AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {

            float raio, area, pi;

            Console.WriteLine("Digite o raio do círculo:");

            raio = float.Parse(Console.ReadLine());

            pi = 3.14159F;
            
            area = pi * (raio * raio);

            Console.WriteLine("A = " + area.ToString("F4"));

        }
    }
}