using System;


namespace _05_ExercicioVetoresRoomsForRent
{
    class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumRoom { get; set; }

        public Room(string name, string email, int numRoom)
        {
            Name = name;
            Email = email;
            NumRoom = numRoom;
        }

        public override string ToString()
        {
            return $"Número do quarto: {this.NumRoom}. Nome: {this.Name}. Email: {this.Email}";
        }
    }
}
