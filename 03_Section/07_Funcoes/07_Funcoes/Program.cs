using System;
using System.Globalization;

namespace _07_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontra maior número entre três números.");
            Console.WriteLine("Informe três número: (EM CASO DE DECIMAIS UNSAR VÍRGULA!)");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

                double resultado = achaMaior(n1, n2, n3);
            Console.WriteLine($"O maior número é: {resultado}");

        }

        static double achaMaior(double n1, double n2, double n3)
        {
            if(n1 > n2 && n1 > n3)
            {
                return n1;

            }else if(n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
    }
}
