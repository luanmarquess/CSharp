using System;
using System.Globalization;

namespace _03_Vect
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            
            for(int i = 0; i<vect.Length; i++)
            {
                vect[i] = int.Parse(Console.ReadLine());
            };

            double sum = 0;
            foreach(int posicao in vect)
            {
                sum += posicao;
            }
            Console.WriteLine($"A soma dos vetores é: {sum}");

        }
    }
}
