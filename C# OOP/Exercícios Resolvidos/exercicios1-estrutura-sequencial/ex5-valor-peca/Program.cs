// See https://aka.ms/new-console-template for more information

using System;

namespace ex5ValorPeca
{
    class Program
    {
        static void Main(string[] args)
        {

            int cod1, qtd1, cod2, qtd2;
            float val1, val2, total;


            Console.WriteLine("Digite em sequencia o código, quantidade e valor de uma peça:");
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            val1 = float.Parse(valores[2]);

            Console.WriteLine("Digite em sequencia o código, quantidade e valor de outra peça:");
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            val2 = float.Parse(valores[2]);

            total = (qtd1 * val1) + (qtd2 * val2);

            Console.WriteLine("Valor a pagar = " + total.ToString("F2"));

        }
    }
}