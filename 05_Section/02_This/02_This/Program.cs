using System;

namespace _02_This
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observando comportamento da diretiva this na classe");

            Produto x = new Produto("tv", 200);
            Console.WriteLine(x);
        }
    }
}
