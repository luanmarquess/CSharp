using System;
using System.Globalization;


namespace _10_ExercicioCotacaoDolar
{
    public class Dolar
    {
        double Cotacao;
        double Iof = 0.06;

        public string Comprar(double qtdaDolar)
        {
            return ((Cotacao * qtdaDolar) + CalculaIof(qtdaDolar)).ToString("f2", CultureInfo.InvariantCulture);
        }

        private double CalculaIof(double qtdaDolar)
        {
            return (Cotacao * qtdaDolar) * Iof;
        }

        public void SetCotacao(double cotacao)
        {
            this.Cotacao = cotacao;
        }


    }
}
