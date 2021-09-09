using System;
using System.Globalization;


namespace _04_VetorClasse
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return "Nome do produto: " + Name + ". Preço: $" + Price;
        }
    }
}
