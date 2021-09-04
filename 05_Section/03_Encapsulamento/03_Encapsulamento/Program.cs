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

            Console.WriteLine(p.GetNome() + p.GetQuantidade() + p.GetValor());

            p.SetNome("Geladeira");
            Console.WriteLine(p.GetNome() + p.GetQuantidade() + p.GetValor());
            p.SetNome(" ");
            Console.WriteLine(p.GetNome() + p.GetQuantidade() + p.GetValor());

        }
    }
}
