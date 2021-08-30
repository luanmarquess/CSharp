using System;
using System.Globalization;

namespace _05_ExercicioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa:");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e atura (mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');

            Console.WriteLine($"O nome informado é: {nome}");
            Console.WriteLine($"Quantidade de quartos na casa: {quartos}");
            Console.WriteLine($"Preço do produto: {precoProduto.ToString("f2", CultureInfo.InvariantCulture)}");

            for(var i = 0; i<dados.Length; i++)
            {
                if(i < 2)
                {
                    Console.WriteLine($"{dados[i]}");
                }
                else
                {
                    double altura = double.Parse(dados[i]);
                    Console.WriteLine($"{altura.ToString("f2", CultureInfo.InvariantCulture)}");
                }
            }


        }
    }
}
