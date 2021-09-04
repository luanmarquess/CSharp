using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_This
{
    class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;

        public Produto(){
            quantidade = 10;
        }

        public Produto(string nome, double valor) : this()
        {
            this.nome = nome;
            this.valor = valor;
        }

        public override string ToString()
        {
            return "Produto: " + nome + ". Valor: " + valor + ". Quantidade: " + quantidade;
        }

    }
}
