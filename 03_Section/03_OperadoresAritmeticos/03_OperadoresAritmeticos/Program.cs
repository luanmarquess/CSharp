using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;

            int n3 = 17 % 3;

            double n4 = 10 / 8;
            double n5 = 10.0 / 8.0;
            double n6 = (double)10 / 8; // casting

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double baskara = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("Resultado esperado: 11" + " Resultado obtido: " + n1);
            Console.WriteLine("Resultado esperado: 14" + " Resultado obtido: " + n2);
            Console.WriteLine("Resultado esperado : 2 " + " Resultado obtido: " + n3);
            Console.WriteLine("Resultado esperado : 1" + " Resultado obtido: " + n4);
            Console.WriteLine("Resultado esperado : 1.25" + " Resultado obtido: " + n5);
            Console.WriteLine("Resultado esperado : 1.25" + " Resultado obtido: " + n6);
            Console.WriteLine("Resultado esperado : 25" + " Resultado obtido: " + delta);
            Console.WriteLine("Resultado esperado : 4" + " Resultado obtido: " + baskara);

            Console.ReadLine();
        }
    }
}

