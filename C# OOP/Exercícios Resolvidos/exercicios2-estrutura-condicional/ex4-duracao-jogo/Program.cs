// See https://aka.ms/new-console-template for more information

using System;

namespace ex4DuracaoJogo
{
   class Program
    {
        static void Main(string[] args)
        {

            double hI, hF, duracao;

            Console.WriteLine("Digite o horário inicial do jogo:");
            hI = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o horário final do jogo:");
            hF = double.Parse(Console.ReadLine());

            if (hI < hF)
            {
                duracao = hF - hI;
            } else
            {
                duracao = 24 - hI + hF;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}