using System;
using System.Globalization;


namespace _06_ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler valores de altura e largura do retÂngulo e mostrar na tela o valor
            // da área, perímetro e diagonal.

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Informe o valor da BASE do retângulo:");
            retangulo.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor da ALTURA do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: "+ retangulo.CalculaArea() + "cm");
            Console.WriteLine("Preimetro: "+ retangulo.CalculaPerimetro() + "cm");
            Console.WriteLine("Diagonal: "+ retangulo.CalculaDiagonal() + "cm");
             


        }
    }
}
