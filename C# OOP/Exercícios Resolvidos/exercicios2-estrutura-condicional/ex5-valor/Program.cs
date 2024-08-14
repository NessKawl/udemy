// See https://aka.ms/new-console-template for more information

using System;

namespace ex5Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;

            Console.WriteLine("Digite o código e a quantidade de um item:");
            string[] valores = Console.ReadLine().Split(' ');

            cod = int.Parse(valores[0]);
            qtd = int.Parse(valores[1]);
            double valor = 0;

            if (cod == 1)
            {
                valor = qtd * 4;
            }
            else if (cod == 2)
            {
                valor = qtd * 4.5;
            }
            else if (cod == 3)
            {
                valor = qtd * 5;
            }
            else if (cod == 4)
            {
                valor = qtd * 2;
            }
            else if (cod == 5)
            {
                valor = qtd * 1.5;
            }

            Console.WriteLine("Total: R$ " + valor.ToString("F2"));
        }
    }
}