
using ex1_conversor;
using System;
using System.Globalization;

namespace Ex1Conversor
{
    class Program
    {
        static void Main(string[] args)
        {

            ConversorDeMoeda conversor = new ConversorDeMoeda();    

            Console.Write("Qual é a cotação do dólar? ");
            conversor.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            conversor.ComprarDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + conversor.ValorEmReais().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}