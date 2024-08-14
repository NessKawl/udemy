// See https://aka.ms/new-console-template for more information

using System;

namespace ex2Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dgite uma coordenada X e Y: ");
            string[] coord = Console.ReadLine().Split(' ');
            double x = double.Parse(coord[0]);
            double y = double.Parse(coord[1]);

            while (x != 0 && y != 0)
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                } else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                } else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                } else
                {
                    Console.WriteLine("Quarto");
                }

                Console.Write("Dgite outra coordenada X e Y: ");
                coord = Console.ReadLine().Split(' ');
                x = double.Parse(coord[0]);
                y = double.Parse(coord[1]);
            }

            Console.WriteLine(" ");
        }
    }
}