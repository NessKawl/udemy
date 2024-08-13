// See https://aka.ms/new-console-template for more information
using System;

namespace ex1SomaDeDoisNumeros {
    class Program {
        static void Main(string[] args) {

            int n1, n2, soma;

            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}