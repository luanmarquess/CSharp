using System;
using System.Globalization;

namespace _01_AreaTrianguloSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula área dois triangulos e compara qual é maior");
            Console.WriteLine("Informe a medida dos três lados do primeiro triângulo:");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Informe a medida dos três lados do segundo triângulo:");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = Perimetro(xA, xB, xC);
            double areaX = CalculaArea(pX, xA, xB, xC);
            
            double pY = Perimetro(yA, yB, yC);
            double areaY = CalculaArea(pY, yA, yB, yC);

            if(areaX > areaY)
            {
                Console.WriteLine($"A área dos triânguloss são: A: {areaX}. B: {areaY}. Area do A é maior!");
            }
            else
            {
                Console.WriteLine($"A área dos triânguloss são: A: {areaX}. B: {areaY}. Area do B é maior!");
            }
        }


        static double Perimetro(double lado1, double lado2, double lado3)
        {
            double p;
            return p = (lado1 + lado2 + lado3) / 2;
        }

        static double CalculaArea(double p, double lado1, double lado2, double lado3)
        {
            double area;
            return area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));
        }
    }
}
