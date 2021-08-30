using System;
using System.Globalization;

namespace _04_EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Parte 1:");
           Console.WriteLine("Informe uma string, int, double, char:");
            
            
           string x = Console.ReadLine();
           int y = int.Parse(Console.ReadLine());
           double z = double.Parse(Console.ReadLine());
           char w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            string[] l = Console.ReadLine().Split(' ');
            Console.WriteLine(l.Length);
            for( var i = 0; i<l.Length; i++)
            {
                Console.WriteLine(l[i]);
            }

            Console.WriteLine("Parte 2:");
            Console.WriteLine("Informe: Nome, sexo, idade, altura. Separando-os por espaço.");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome}. Sexo: {sexo}. Idade: {idade}. Altura: {altura.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
