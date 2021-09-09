using System;
using System.Globalization;

namespace _04_VetorClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de produtos:");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i = 0; i<vect.Length; i++)
            {
                Console.WriteLine("Informe o nome do produto:");
                string name = Console.ReadLine();
                Console.WriteLine("Informe o preço do produto:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto(name, price);

            }

            double sum = 0.0;
            for(int i = 0; i < vect.Length; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine($"A média é: {avg}");
            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
