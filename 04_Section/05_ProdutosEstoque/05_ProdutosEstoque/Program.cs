using System;
using System.Globalization;

namespace _05_ProdutosEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aplicação para adicionar, produto: contendo NOME, PREÇO E QUANTIDADE EM ESTOQUE. Realizar a inclusão e retirada desse produto, atulizando quantidade em estoque e preço total em estoque;

            Console.WriteLine("Entre com os dados do produto");

            Produto TV = new Produto();
            Console.WriteLine("Informe o nome do Produto:");
            TV.Nome = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto:");
            TV.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe quantas unidades:");
            TV.Quantidade = int.Parse(Console.ReadLine());

            TV.GetProduto();

            Console.WriteLine("Quantos produtos deseja adicionar:");
            int qtdaNovosProdutos = int.Parse(Console.ReadLine());
            TV.AdicionarProdutos(qtdaNovosProdutos);

            Console.WriteLine("Quantos produtos deseja remover:");
            int qtdaRemoverProdutos = int.Parse(Console.ReadLine());
            TV.RemoverPorduto(qtdaRemoverProdutos);

        }
    }
}
