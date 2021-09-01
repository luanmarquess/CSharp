using System;

namespace _02_ClasseTriangulo
{
    class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;
        private double perimetro;

        public double area;

        public Triangulo(double x, double y, double z)
        {
            this.lado1 = x;
            this.lado2 = y;
            this.lado3 = z;
        }

        private void CalculaPerimetro()
        {
            perimetro = (lado1 + lado2 + lado3) / 2;
            
        }

        public double CalculaArea()
        {
            this.CalculaPerimetro();
            return area = Math.Sqrt(perimetro * (perimetro - lado1) * (perimetro - lado2) * (perimetro - lado3));
        }

        public double getArea()
        {
           return this.area;
        }
            

    }
}
