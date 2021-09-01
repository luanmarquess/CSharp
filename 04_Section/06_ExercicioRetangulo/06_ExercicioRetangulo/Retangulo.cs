using System;
using System.Globalization;


namespace _06_ExercicioRetangulo
{
    public class Retangulo
    {
        public double Base;
        public double Altura;


        public double CalculaArea()
        {
            return this.Base * this.Altura;
        }
        public double CalculaPerimetro()
        {
           return 2*(this.Base) + 2*(this.Altura);
        }

        public double CalculaDiagonal()
        {
            return Math.Sqrt(Math.Pow(this.Base, 2) + Math.Pow(this.Altura, 2));
        }

    }
}
