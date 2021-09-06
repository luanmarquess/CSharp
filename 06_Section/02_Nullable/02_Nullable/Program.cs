using System;

namespace _02_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<double> x = null;
            double? x = null;
            Console.WriteLine(x);

            double? a = null;
            double? b = 10;
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());

            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            else
            {
                Console.WriteLine("a is null");
            }

            if (b.HasValue)
            {
                Console.WriteLine(b.Value);
            }
            else
            {
                Console.WriteLine("b is null");
            }
         

            //Console.WriteLine(a.Value); // lança uma exceção caso não tenha valor;
            Console.WriteLine("Teste value." + b.Value);

            double? c = null;
            double? d = 10.0;

            double? e = c ?? 999; // ?? == se primeiro valor == a null, variável "e" recebe o próximo valor "999"
            double? f = d ?? 999;

            Console.WriteLine(e);
            Console.WriteLine(f);

        }
    }
}
