using System;
using System.Globalization;

namespace _05_ProdutosEstoque
{
    public class Produto
    {
        private string _nome;
        public double Valor { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { }
        public Produto(string nome, double valor, int quantidade)
        {
            this._nome = nome;
            this.Valor = valor;
            this.Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set 
            {
                if (value != null && value.Length > 1)
                {
                    this._nome = value;
                }
                else
                {
                    Console.WriteLine("Não foi possível realizar o update. Nome Inválido!");
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Valor * Quantidade;
        }
        public override string ToString()
        {
            return _nome
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
