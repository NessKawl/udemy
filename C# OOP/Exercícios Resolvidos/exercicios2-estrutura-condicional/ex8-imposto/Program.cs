// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.Intrinsics.Arm;

namespace ex8Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());

            double imposto = 0;

            if (salario <= 2000)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 3000) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$: " + imposto.ToString("F2"));
            }
        }
    }
}