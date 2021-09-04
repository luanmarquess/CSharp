using System;
using System.Globalization;

namespace _05_ProdutosEstoque
{
    public class Produto
    {
        private string _nome;
        private double _valor;
        private int _quantidade;

        public Produto() { }
        public Produto(string nome, double valor, int quantidade)
        {
            this._nome = nome;
            this._valor = valor;
            this._quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                this._nome = nome;
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o update. Nome Inválido!");
            }
        }
        public double GetValor()
        {
            return _valor;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _valor * _quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ": Preço: $" + _valor.ToString("F2", CultureInfo.InvariantCulture)
                + ". Quantidade: " + _quantidade
                + ". Valor total em estoque: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void GetProduto()
        {
            Console.WriteLine($"Dados do produto: {this.ToString()}");
        }

        public void AdicionarProdutos(int quantidadeNovosProdutos)
        {
            this._quantidade += quantidadeNovosProdutos;
            Console.WriteLine("Dados atualizados: " + this.ToString());
            //Console.WriteLine($"Dados atualizados: {this.Nome}, {this.Quantidade} unidades, ${this.ValorTotalEmEstoque()}.");
        }

        public void RemoverPorduto(int quantidadeProdutosRemover)
        {
            this._quantidade -= quantidadeProdutosRemover;
            Console.WriteLine("Dados atualizados: " + this.ToString());
            //Console.WriteLine($"Dados atualizados: {this.Nome}, {this.Quantidade} unidades, ${this.ValorTotalEmEstoque()}.");
        }
    }
}
