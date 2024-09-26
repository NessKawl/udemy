// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace ex_estoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.Write("Digite a quantidade de produtos a serem adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a serem removidos: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}