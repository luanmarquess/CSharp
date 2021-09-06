using System;

namespace _01_TipoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.X = 10;
            point.Y = 20;

            Console.WriteLine(point);

            Point p = new Point();
            Console.WriteLine(p);

            Point p1 = new Point( 10, 40);
            Console.WriteLine(p1);
        }
    }
}
