namespace GerenciadorEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Cliente cliente = new Cliente();

            Console.WriteLine("Bem vindo ao sistema DistribuX!");
            Console.WriteLine("Selecione para onde deseja ir:");
            Console.WriteLine("1 - Cadastro de produtos");
            Console.WriteLine("2 - Estoque");
            Console.WriteLine("3 - Cadastro de clientes");
            Console.WriteLine("4 - Clientes cadastrados");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Cadastro de produtos");
                Console.WriteLine();

                Console.Write("Digite o nome do produto: ");
                produto.NomeProduto = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite a descrição do produto: ");
                produto.DescProduto = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o preço do produto: ");
                produto.PrecoProduto = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Digite a quantidade do produto: ");
                produto.QtdProduto = double.Parse(Console.ReadLine());
                Console.WriteLine();
            } else if (option == 2)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Estoque");
            } else if (option == 3)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Cadastro de clientes");
                Console.WriteLine();

                Console.Write("Digite o nome do cliente: ");
                cliente.NomeCliente = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Digite o CPF:");
                cliente.CpfCliente = Console.ReadLine();
            } else if (option == 4)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Clientes cadastrados");
                Console.WriteLine();

                Console.WriteLine();
            } else
            {
                Console.WriteLine("ERRO: SELECIONE UMA OPÇÃO VÁLIDA!");
            }
        }
    }
}
