using _05_ProdutosEstoque;
using System;
using System.Globalization;

namespace _01_EstoqueProduto_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 300, 10);

            Console.WriteLine(p.Nome + p.Quantidade + p.Valor);

            p.Nome = "Geladeira";
            Console.WriteLine(p.Nome + p.Quantidade + p.Valor);
            
            p.Nome = " ";
            Console.WriteLine(p.Nome + p.Quantidade + p.Valor);
           

        }
    }
}
