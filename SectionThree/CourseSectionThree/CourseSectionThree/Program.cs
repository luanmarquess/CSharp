using System;
using System.Globalization;

namespace CourseSectionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Exibe 2 casas decimais: " + saldo.ToString("F2"));
            Console.WriteLine("Exibe 4 casas decimais: " + saldo.ToString("F4"));
            Console.WriteLine("Exibe 4 casas decimais e substitui a ',' por '.': " + saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------PLACE HOLDER E INTERPOLAÇÃO--------------");
            Console.WriteLine("PLACEHOLDER: {0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"INTERPOLAÇÃO: {nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
        }
    }
}
