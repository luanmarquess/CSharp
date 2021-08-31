using System;
using System.Globalization;

namespace _08_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double x = Math.Sqrt(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"A raiz é: {x.ToString("f3", CultureInfo.InvariantCulture)}.");

            while( x >= 0)
            {
                Console.WriteLine("Digite um número positivo para saber a raiz ou NEGATIVO para sair:");
                x = Math.Sqrt(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                if(x >= 0)
                {
                    Console.WriteLine($"A raiz é: {x.ToString("f3", CultureInfo.InvariantCulture)}.");
                }
            }

            Console.WriteLine("Tchau, Obrigado!");
            
        }
    }
}
