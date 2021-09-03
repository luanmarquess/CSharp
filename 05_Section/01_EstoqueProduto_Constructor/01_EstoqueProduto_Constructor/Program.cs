using _05_ProdutosEstoque;
using System;
using System.Globalization;

namespace _01_EstoqueProduto_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aplicação para adicionar, produto: contendo NOME, PREÇO E QUANTIDADE EM ESTOQUE. Realizar a inclusão e retirada desse produto, atulizando quantidade em estoque e preço total em estoque;

            Console.WriteLine("Entre com os dados do produto");


            Console.WriteLine("Informe o nome do Produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o preço do Produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe quantas unidades:");
            int unidade = int.Parse(Console.ReadLine());

            Produto TV = new Produto(nome, preco, unidade);

            TV.GetProduto();

            Console.WriteLine("Quantos produtos deseja adicionar:");
            int qtdaNovosProdutos = int.Parse(Console.ReadLine());
            TV.AdicionarProdutos(qtdaNovosProdutos);

            Console.WriteLine("Quantos produtos deseja remover:");
            int qtdaRemoverProdutos = int.Parse(Console.ReadLine());
            TV.RemoverPorduto(qtdaRemoverProdutos);

            // testando sobrecarga construtor

            Produto p1 = new Produto();
            Produto p2 = new Produto(nome, preco);
            Produto p3 = new Produto(nome, preco, unidade);

            //Diferente sintaxe para instânciar quando há construtor Default (sem parâmetro); 

            Produto p4 = new Produto
            {
                Nome = "Geladeira",
                Valor = 1000
            };

            Console.WriteLine(p4);

        }
    }
}
