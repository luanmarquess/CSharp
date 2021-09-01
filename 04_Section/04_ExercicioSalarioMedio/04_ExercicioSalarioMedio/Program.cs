using System;

namespace _04_ExercicioSalarioMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classe recebe nome e salário de funcionarios e calcula o salário médio");

            Funcionario Luan = new Funcionario("Luan", 200.000);
            Funcionario Fulano = new Funcionario("Fulano", 100.000);

            Console.WriteLine($"A média salaria é: {(Luan.salario + Fulano.salario)/2}"); 
        }
    }
}
