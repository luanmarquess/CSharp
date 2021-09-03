using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula CIRCUNFERÊNCIA e VOLUME de uma esfera, passando Raio no construtor.");

            Esfera esfera = new Esfera(3.0);

            Console.WriteLine($"Circunferência: {esfera.Circunferencia()}");
            Console.WriteLine($"Volume: {esfera.Volume()}");
            Console.WriteLine($"Pi: {esfera.getPi()}");

        }
    }
}
