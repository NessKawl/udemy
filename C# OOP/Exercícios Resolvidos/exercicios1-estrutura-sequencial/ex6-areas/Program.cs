// See https://aka.ms/new-console-template for more information

using System;

namespace ex6Areas
{
    class Program
    {
        static void Main(string[] args)
        {

            float a, b, c, areaT, areaC, areaTp, areaQ, areaR, pi;

            pi = 3.14159F;

            Console.WriteLine("Digite em sequencia 3 valores, A, B e C:");
            string[] valores = Console.ReadLine().Split(' ');
            a = float.Parse(valores[0]);
            b = float.Parse(valores[1]);  
            c = float.Parse(valores[2]);

            areaT = (a * c) / 2;
            Console.WriteLine("TRIANGULO: " + areaT.ToString("F3"));

            areaC = pi * (c * c);
            Console.WriteLine("CIRCULO: " + areaC.ToString("F3"));

            areaTp = ((a + b) * c) / 2;
            Console.WriteLine("TRAPÉZIO: " + areaTp.ToString("F3"));

            areaQ = b * b;
            Console.WriteLine("QUADRADO: " + areaQ.ToString("F3"));

            areaR = a * b;
            Console.WriteLine("RETÂNGULO: "  + areaR.ToString("F3"));




        }
    }
}