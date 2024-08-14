// See https://aka.ms/new-console-template for more information

using System;

namespace ex3Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha o tipo de combustível: ");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");
            int comb = int.Parse(Console.ReadLine());

            while (comb != 1 && comb != 2 && comb != 3 && comb != 4)
            {
                Console.WriteLine("Digite outro código");
                comb = int.Parse(Console.ReadLine());
            }

            while (comb != 4)
            {

                Console.WriteLine("Digite a quantidade de clientes: ");
                int clientes = int.Parse(Console.ReadLine());

                if (comb == 1)
                {
                    Console.WriteLine("Álcool: " + clientes);
                }
                else if (comb == 2)
                {
                    Console.WriteLine("Gasolina: " + clientes);
                }
                else if (comb == 3)
                {
                    Console.WriteLine("Diesel: " + clientes);
                }

                Console.WriteLine("Escolha o tipo de combustível: ");
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Fim");
                comb = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Muito obrigado!");
            
            // LÓGICA APLICADA NO CURSO

            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;

            //int tipo = int.Parse(Console.ReadLine());

            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        alcool = alcool + 1;
            //    }
            //    else if (tipo == 2)
            //    {
            //        gasolina = gasolina + 1;
            //    }
            //    else if (tipo == 3)
            //    {
            //        diesel = diesel + 1;
            //    }

            //    tipo = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine("Alcool: " + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: " + diesel);

        }
    }
}