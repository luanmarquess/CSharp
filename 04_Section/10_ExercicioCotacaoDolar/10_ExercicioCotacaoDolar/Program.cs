using System;
using System.Globalization;

namespace _10_ExercicioCotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar();

            Console.WriteLine("Informe a cotação do dolar:");
            dolar.SetCotacao(double.Parse(Console.ReadLine()));

            Console.WriteLine("Quantos dolares você deseja comprar:");
            Console.WriteLine($"O valor a ser pago em REAIS é: R${dolar.Comprar(double.Parse(Console.ReadLine()))}");
        }
    }
}
