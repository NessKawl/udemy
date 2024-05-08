using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // adicionar o sufixo L a números longs armazenados manualmente para explicitar que está sendo utilizado o long
            float n5 = 4.5f; // necessita do sufixo f para identificar como float, senão conflita com o double
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int n = int.MinValue; // MinValue retorna o valor mínimo que cabe dentro do tipo de dado especificado
            Console.WriteLine(n);

            int nn = int.MaxValue; // MaxValue retorna o valor máximo que cabe dentro do tipo de dado especificado
            Console.WriteLine(nn);

        }
    }
}