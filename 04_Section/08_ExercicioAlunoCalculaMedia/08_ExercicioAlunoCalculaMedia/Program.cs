using System;
using System.Globalization;

namespace _08_ExercicioAlunoCalculaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Informe o nome do Aluno:");

            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota:");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a segunda nota:");
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a terceira nota:");
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            aluno.CalculaMedia();
            aluno.PassouDeAno();




        }
    }
}
