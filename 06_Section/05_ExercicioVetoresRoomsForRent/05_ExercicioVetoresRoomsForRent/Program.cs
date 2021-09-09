using System;

namespace _05_ExercicioVetoresRoomsForRent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented?");
            int n = int.Parse(Console.ReadLine());
            Room[] rent = new Room[n];

            for(int i = 0; i < rent.Length; i++)
            {
                int contador = 1;
                Console.WriteLine($"Rent #{contador}");

                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Qual quarto gostaria? 0 - 9");
                int numRoom = int.Parse(Console.ReadLine());
                if(numRoom < 0 && numRoom > 9)
                {
                    Console.WriteLine("Temos quartos de 0 a 9. Qual quarto gostaria? 0 - 9");
                    numRoom = int.Parse(Console.ReadLine());
                }

                rent[i] = new Room(name, email, numRoom);
                contador++;

            }
            // problem para organizar;
            for(int i = 0; i<rent.Length; i++)
            {
                if(rent[i] != null && rent[i].NumRoom < rent[i++].NumRoom)
                {
                    Console.WriteLine(rent[i]);
                }
                else
                {
                    Room[] room = new Room[n];
                    room[i] = rent[i];
                    rent[i] = rent[i++];
                    rent[i++] = room[i];
                    Console.WriteLine(rent[i]);
                }
            }
        }
    }
}
