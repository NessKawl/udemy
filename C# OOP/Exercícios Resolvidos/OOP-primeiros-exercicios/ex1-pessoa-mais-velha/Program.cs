// See https://aka.ms/new-console-template for more information

using ex1_pessoa_mais_velha;
using System;

namespace ex1PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();   
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            string maisVelho = " ";

            if (pessoa1.idade > pessoa2.idade)
            {
                maisVelho = pessoa1.nome;
            }else
            {
                maisVelho = pessoa2.nome;
            }

            Console.WriteLine("Nome: " + pessoa1.nome);
            Console.WriteLine("Idade: " + pessoa1.idade);
            Console.WriteLine(" ");
            Console.WriteLine("Nome: " + pessoa2.nome);
            Console.WriteLine("Idade: " + pessoa2.idade);
            Console.WriteLine(" ");
            Console.WriteLine("Pessoa mais velha: " + maisVelho);
        }
    }
}