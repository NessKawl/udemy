// See https://aka.ms/new-console-template for more information

using ex2_salario_medio;
using System;
using System.Globalization;

namespace ex2SalarioMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Slário: ");
            funcionario1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
