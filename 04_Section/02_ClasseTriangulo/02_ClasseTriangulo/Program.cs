using System;

namespace _02_ClasseTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula área dois triangulos e compara qual é maior");

            Triangulo x = new Triangulo(3.00, 4.00, 5.00);
            Triangulo y = new Triangulo(6.00, 7.00, 8.00);
            
            //Triangulo x = new Triangulo(6.00, 9.00, 10.00);
            //Triangulo y = new Triangulo(6.00, 7.00, 8.00);

            x.CalculaArea();
            y.CalculaArea();

            if(x.getArea() > y.getArea())
            {
                Console.WriteLine($"A área do triangulo x é maior que a do y. AREA DO TRIANGULO X: {x.getArea()}. AREA DO TRIANGULO Y: {y.getArea()}");
            }
            else
            {
                Console.WriteLine($"A área do triangulo y é maior que a do x. AREA DO TRIANGULO X: {x.getArea()}. AREA DO TRIANGULO Y: {y.getArea()}");

            }
        }
    }
}
