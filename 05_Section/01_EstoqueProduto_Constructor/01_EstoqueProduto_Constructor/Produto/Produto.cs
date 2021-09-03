using System;
using System.Globalization;

namespace _05_ProdutosEstoque
{
    public class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public Produto(string nome, double valor, int quantidade)
         {
             this.Nome = nome;
             this.Valor = valor;
             this.Quantidade = quantidade;
         }
        public Produto(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
        public Produto() { }
   
        public double ValorTotalEmEstoque()
        {
            return Valor * Quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ": Preço: $" + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ". Quantidade: " + Quantidade
                + ". Valor total em estoque: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void GetProduto()
        {
            Console.WriteLine($"Dados do produto: {this.ToString()}");
        }

        public void AdicionarProdutos(int quantidadeNovosProdutos)
        {
            this.Quantidade += quantidadeNovosProdutos;
            Console.WriteLine("Dados atualizados: " + this.ToString());
            //Console.WriteLine($"Dados atualizados: {this.Nome}, {this.Quantidade} unidades, ${this.ValorTotalEmEstoque()}.");
        }

        public void RemoverPorduto(int quantidadeProdutosRemover)
        {
            this.Quantidade -= quantidadeProdutosRemover;
            Console.WriteLine("Dados atualizados: " + this.ToString());
            //Console.WriteLine($"Dados atualizados: {this.Nome}, {this.Quantidade} unidades, ${this.ValorTotalEmEstoque()}.");
        }
    }
}
