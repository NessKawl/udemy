// See https://aka.ms/new-console-template for more information

using System;

namespace ex4Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario;
            float valor, horas, salario;

            Console.WriteLine("Informe o ID do funcionário:");

            nFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Infomrme o valor recebido por hora:");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas:");
            horas = float.Parse(Console.ReadLine());

            salario = valor * horas;

            Console.WriteLine("--------------------------");

            Console.WriteLine("ID: " + nFuncionario);
            Console.WriteLine("Salário: R$" + salario.ToString("F2"));
        }
    }
}