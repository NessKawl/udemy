using System.Globalization;

namespace ex_estoque
{
    internal class Produto
    {
        public string Nome = "";
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        } 

        public void RemoverProdutos (int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ "
                + Preco.ToString("F2") + ", "
                + Quantidade + " unidades, $ "
                + ValorTotalEmEstoque().ToString("F2");    
        }
    }
}
