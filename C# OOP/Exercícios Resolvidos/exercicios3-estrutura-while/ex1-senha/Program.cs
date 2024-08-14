// See https://aka.ms/new-console-template for more information

using System; 

namespace ex1Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2102)
            {
                Console.WriteLine("Senha inválida!");
                Console.Write("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido, bem vindo!");
        }
    }
}