
namespace ex1_conversor
{
    internal class ConversorDeMoeda
    {
        public double Cotacao;
        public double ComprarDolar;

        public double ValorEmReais ()
        {
            double imposto = (Cotacao * ComprarDolar) * 0.06;
            return Cotacao * ComprarDolar + imposto;
        }

    }
}
