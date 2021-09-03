using System;
using System.Globalization;


namespace ConsoleApp1
{
    public class Esfera
    {
        public double Pi = 3.14;
        public double Raio;

        public Esfera(double raio)
        {
            this.Raio = raio;
        }

        public string Circunferencia()
        {
            return (2 * this.Pi * this.Raio).ToString("f2", CultureInfo.InvariantCulture);
        }
       
        public string Volume()
        {
            return (4 / 3 * Pi * Math.Pow(Raio, 3)).ToString("f2", CultureInfo.InvariantCulture);
        }
        public string getPi()
        {
            return this.Pi.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
