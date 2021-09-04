using System;
using System.Globalization;

namespace _05_ExercicioContaBanco
{
    public class Conta
    {
        private int TaxaSaque = 5;

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta() { }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo;
        }

        public void Deposito(double valor)
        {
            if(valor > 0)
            {
                this.Saldo += valor;
            }
            else
            {
                Console.WriteLine("Informe um valor válido!");
            }

             Console.WriteLine("Dados da conta atualizados: " + this);
        }

        public void Saque(double valor)
        {
            if(valor > 0)
            {
                this.Saldo -= (valor + TaxaSaque);
            }
            else
            {
                Console.WriteLine("Informe um Valor válido");
            }
            Console.WriteLine("Dados da conta atualizados: " + this);
        }
    }
}
