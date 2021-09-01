using System;

namespace _03_ExerciciosPessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cria classe para receber nome e idade.");

            Pessoa x = new Pessoa("Luan", 23);
            Pessoa y = new Pessoa("Beltrano", 20);

            //Pessoa x = new Pessoa("Luan", 23);
            //Pessoa y = new Pessoa("Beltrano", 25);

            if(x.idade > y.idade)
            {
                Console.WriteLine($"{x.nome} é mais velho");
            }
            else
            {
                Console.WriteLine($"{y.nome} é mais velho");
            }
        }
    }
}
